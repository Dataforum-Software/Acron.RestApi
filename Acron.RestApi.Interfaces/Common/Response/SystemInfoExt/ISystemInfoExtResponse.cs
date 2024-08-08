using Microsoft.AspNetCore.Routing.Constraints;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.SystemInfoExt
{
   public interface ISystemInfoExtResponse<T, U> where T : ISystemInfoExtProviderInfoResponse
                                                  where U : ISystemInfoExtServerConnectionResponse
   {
      [SwaggerSchema("Acron version and service pack as string")]
      [SwaggerExampleValue("9.4 SP3")]
      string VersionRAW { get; }

      [SwaggerSchema("Acron version as float (part of VersionRAW)")]
      [SwaggerExampleValue("9.4")]
      float Version { get; }

      [SwaggerSchema("Acron service pack as integer (part of VersionRAW)")]
      [SwaggerExampleValue("3")]
      int ServicePack { get; }

      [SwaggerSchema("Name of the device on which the server is running")]
      [SwaggerExampleValue("example-pc")]
      string ServerName { get; }

      [SwaggerSchema("Short name (identification) of the plant")]
      [SwaggerExampleValue("ExPlant")]
      string PlantShortName { get; }

      [SwaggerSchema("Name of the plant")]
      [SwaggerExampleValue("ExamplePlant")]
      string PlantLongName { get; }

      [SwaggerSchema("License number of the hardlock device")]
      [SwaggerExampleValue("12345")]
      uint LicenseNumber { get; }

      [SwaggerSchema("Amount of user licenses for the database server")]
      [SwaggerExampleValue(5)]
      short LicensedUsers { get; }

      [SwaggerSchema("Amount of active user licenses for the database server")]
      [SwaggerExampleValue(3)]
      short LicensedUsersUsed { get; }

      [SwaggerSchema("Amount of licensed process variables")]
      [SwaggerExampleValue(5)]
      object LicensedProcessVariables { get; }

      [SwaggerSchema("Amount of licensed process variables")]
      [SwaggerExampleValue(5)]
      int LicensedProcessVariablesUsed { get; }

      [SwaggerSchema("Amount reserved REST API clients")]
      [SwaggerExampleValue(3)]
      ushort ReservedClients { get; }

      [SwaggerSchema("Amount of current REST API connections")]
      [SwaggerExampleValue(3)]
      ushort RestApiConnections { get; }

      [SwaggerSchema("Free system memory in megabyte")]
      [SwaggerExampleValue(3210)]
      int MemoryFreeMB { get; }

      [SwaggerSchema("Used system memory in megabyte")]
      [SwaggerExampleValue(29250)]
      uint MemoryUsedMB { get; }

      [SwaggerSchema("Free data path memory")]
      [SwaggerExampleValue(629534.0)]
      double DataPathFreeMB { get; }

      [SwaggerSchema("Used data path memory")]
      [SwaggerExampleValue(344388.0)]
      double DataPathUsedMB { get; }

      [SwaggerSchema("Free compression path memory")]
      [SwaggerExampleValue(629534.0)]
      double CompressionPathFreeMB { get; }

      [SwaggerSchema("Used compression path memory")]
      [SwaggerExampleValue(344388.0)]
      double CompressionPathUsedMB { get; }

      [SwaggerSchema("Total CPU usage in percent")]
      [SwaggerExampleValue(2.0)]
      double PercentageCPUUsage { get; }

      [SwaggerSchema("DBServer CPU usage in percent")]
      [SwaggerExampleValue(2.0)]
      double PercentageCPUUsageDBServer { get; }

      //Enum 
      //TProgStatus RestApiStatus { get; }
      //DateTime RestApiTimeStamp { get; }
      //UInt16 RestApiStatusExt { get; }
      //bool RestApiIsConnected { get; }
      [SwaggerSchema("Current status of DBEngine")]
      [SwaggerExampleValue("AC_SERVICE_RUNNING")]
      TProgStatus DBEngineStatus { get; }

      [SwaggerSchema("Current status of DBServer")]
      [SwaggerExampleValue("AC_SERVICE_RUNNING")]
      TProgStatus DBServerStatus { get; }

      [SwaggerSchema("Current status of Mirror")]
      [SwaggerExampleValue("AC_SERVICE_RUNNING")]
      TProgStatus MirrorStatus { get; }

      [SwaggerSchema("Status of DBEngine calculations")]
      [SwaggerExampleValue("CALCULATING_DATA")]
      DBEngineCompStatusType DBEngineCompressionStatus { get; }

      [SwaggerSchema("Time of last DBEngine compression operation")]
      [SwaggerExampleValue("2024-06-17T08:31:19+02:00")]
      DateTime DBEngineCompressionDateTime { get; }

      [SwaggerSchema($"{nameof(DBEngineCompressionDateTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string DBEngineCompressionDateTime_FORMATTED { get; }

      [SwaggerSchema("Amount of current plants providers")]
      [SwaggerExampleValue(4)]
      ushort CountProviderConfig { get; }

      [SwaggerSchema("List of provider information for every provider of the current plant")]
      [SwaggerExampleValue(typeof(ISystemInfoExtProviderInfoResponse))]
      List<T> ProviderInfos { get; }

      [SwaggerSchema("List of connection information for every external connection of the current plant")]
      [SwaggerExampleValue(typeof(ISystemInfoExtServerConnectionResponse))]
      List<U> ServerConnectionInfos { get; }

      [SwaggerSchema("Amount of external connections")]
      [SwaggerExampleValue(2)]
      ushort CountServerConnections { get; }



   }
   public enum TProgStatus : int
   {
      Unknown = 0,

      AC_SERVICE_NOT_INSTALLED = 1,       // Service nicht installiert
      AC_SERVICE_SYSTEM_FAILURE = 2,      // System Fehler
      AC_SERVICE_RUNNING_DIAGNOSE = 3,    // Service läuft als Anwendung im Eingabefenster         
      AC_SERVICE_STOPPED = 4,             // Der Dienst ist eingerichtet aber gestoppt
      AC_SERVICE_RUNNING = 5,             // Service läuft als Dienst
      AC_SERVICE_RUNNING_APPLICATION = 6, // Service läuft als Anwendung

      Remote_Running = 255,                //Läuft als RemoteDienst, mehr kann nicht wegen einer älteren Version herausgefunden werden
   }

   public enum ProviderStatusType : byte
   {
      OK = 0,                       // Alles OK
      CONNECTION_PROBLEMS = 1,      // Verbindungsprobleme zum Partner (PLS)
      CRITICAL_ERRORS_FOUND = 2,    // aktuelle kritische Fehler vorhanden
      PROVIDER_NOT_RUNNING = 3,     // Provider läuft nicht

      UNKNOWN = 255,                 // Sonderstatus (nur im Admin), bedeutet "Status nicht ermittelbar"
   }

   public enum DBEngineCompStatusType
   {
      DBENGINE_NOT_RUNNING = 0,  // DBEngine läuft nicht
      DATA_IS_UPTODATE = 1,      // Daten sind aktuell
      AN_ERROR_HAS_OCCURED = 2,  // Ein Fehler ist aufgetreten
      CALCULATING_DATA,          // Daten werden gerade berechnet
   }
}
