using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Common.Response.SystemInfoExt;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.SystemInfoExt
{
   [DataContract]
   public class SystemInfoExtResponse : ISystemInfoExtResponse<SystemInfoExtProviderInfoResponse, SystemInfoExtServerConnectionResponse>
   {
      [DataMember]
      public string VersionRAW { get; set; }

      [DataMember]
      public float Version { get; set; }

      [DataMember]
      [DefaultValue(-1)]
      public int ServicePack { get; set; }

      [DataMember]
      public string ServerName { get; set; }

      [DataMember]
      public string PlantShortName { get; set; }

      [DataMember]
      public string PlantLongName { get; set; }

      [DataMember]
      public uint LicenseNumber { get; set; }

      [DataMember]
      public short LicensedUsers { get; set; }

      [DataMember]
      public short LicensedUsersUsed { get; set; }

      [DataMember]
      public object LicensedProcessVariables { get; set; }

      [DataMember]
      public int LicensedProcessVariablesUsed { get; set; }

      [DataMember]
      public ushort ReservedClients { get; set; }

      [DataMember]
      public ushort RestApiConnections { get; set; }

      [DataMember]
      public int MemoryFreeMB { get; set; }

      [DataMember]
      public uint MemoryUsedMB { get; set; }

      [DataMember]
      public double DataPathFreeMB { get; set; }

      [DataMember]
      public double DataPathUsedMB { get; set; }

      [DataMember]
      public double CompressionPathFreeMB { get; set; }

      [DataMember]
      public double CompressionPathUsedMB { get; set; }

      [DataMember]
      public double PercentageCPUUsage { get; set; }

      [DataMember]
      public double PercentageCPUUsageDBServer { get; set; }

      //[DataMember]
      //[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      //public TProgStatus RestApiStatus { get; set; }
      //[DataMember]
      //public DateTime RestApiTimeStamp { get; set; }
      //[DataMember]
      //public ushort RestApiStatusExt { get; set; }
      //[DataMember]
      //public bool RestApiIsConnected { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public TProgStatus DBEngineStatus { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public TProgStatus DBServerStatus { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public TProgStatus MirrorStatus { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public DBEngineCompStatusType DBEngineCompressionStatus { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DBEngineCompressionDateTime_FORMATTED))]
      public DateTime DBEngineCompressionDateTime { get; set; }

      [DataMember]
      public string DBEngineCompressionDateTime_FORMATTED { get; set; }

      [DataMember]
      public ushort CountProviderConfig { get; set; }

      [DataMember]
      public List<SystemInfoExtProviderInfoResponse> ProviderInfos { get; set; }

      [DataMember]
      public ushort CountServerConnections { get; set; }

      [DataMember]
      public List<SystemInfoExtServerConnectionResponse> ServerConnectionInfos { get; set; }


   }
}
