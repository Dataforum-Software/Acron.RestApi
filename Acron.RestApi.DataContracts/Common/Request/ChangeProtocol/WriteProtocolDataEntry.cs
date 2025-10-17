using Acron.RestApi.Interfaces.Common.Request.ChangeProtocol;
using Acron.RestApi.Interfaces.Common.Response.ChangeProtocol;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Request.ChangeProtocol
{
   [DataContract] 
   public class WriteProtocolDataEntry : IWriteProtocolDataEntry
   {
      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ACRON_MODULE Module { get; set; }

      [DataMember]
      public DateTime Timestamp { get; set; }

      [DataMember]
      public string PropertyName { get; set; }

      [DataMember]
      public string ObjectIndentification { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ACP_STATE ActionType { get; set; }

      [DataMember]
      public string OldValue { get; set; }

      [DataMember]
      public string NewValue { get; set; }

   }
}
