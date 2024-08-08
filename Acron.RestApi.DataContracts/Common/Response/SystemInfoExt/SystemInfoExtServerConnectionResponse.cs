using Acron.RestApi.Interfaces.Common.Response.SystemInfoExt;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.SystemInfoExt
{
    [DataContract]
    public class SystemInfoExtServerConnectionResponse : ISystemInfoExtServerConnectionResponse
    {
        [DataMember]
        public string ExternalConnectionID { get; set; }
        [DataMember]
        public string ExternalConnectionName { get; set; }
        [DataMember]
        public string ExternalTCPIPAdress { get; set; }
        [DataMember]
        public uint ExternalTCPIPPort { get; set; }
        [DataMember]
        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        public ConnectionStatusType ConnectionStatus { get; set; }
        [DataMember]
        public ulong ServerID { get; set; }
    }
}
