using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.SystemInfoExt
{
   public interface ISystemInfoExtServerConnectionResponse
   {
      [SwaggerSchema("Unique ID of the external connection")]
      [SwaggerExampleValue("Connection_1")]
      string ExternalConnectionID { get; }

      [SwaggerSchema("Name of the external connection")]
      [SwaggerExampleValue("Connection 1")]
      string ExternalConnectionName { get; }

      [SwaggerSchema("IP adress or DNS name")]
      [SwaggerExampleValue("Connection_1")]
      string ExternalTCPIPAdress { get; }

      [SwaggerSchema("Port")]
      [SwaggerExampleValue(3997)]
      uint ExternalTCPIPPort { get; }

      [SwaggerSchema("Status of connection")]
      [SwaggerExampleValue("MAX_PATHDEPTH_REACHED")]
      ConnectionStatusType ConnectionStatus { get; }

      [SwaggerSchema("ID of the connections terminal server")]
      [SwaggerExampleValue("15539326718939894481")]
      ulong ServerID { get; }
   }

   public enum ConnectionStatusType : ushort
   {
      NOCONNECTION = 0,                      // Keine Verbindung zum externen Verbindungsobjekt
      CONNECTION_OK_NO_EXTENDET_INFOS = 1,   // Verbindung OK aber der Server unterstützt keine weiteren Infos
      MAX_PATHDEPTH_REACHED = 2,             // Maximale Pfadtiefe (MAX_EXT_SERVER_DEPTH = 8) erreicht
      DEADLOCK = 3,                          // Deadlock
      OK = 4,                                // OK
      CONNECTION_OK_NO_VG = 5,               // OK, aber Verbindung gibt keine VGs zurück, Verbindung unnötig
      CONNECTION_OK_NOT_AUTHORIZED           // Ab Acron 9.0 = Verbindung OK aber Benutzer / Passwort stimmen nicht
   }
}
