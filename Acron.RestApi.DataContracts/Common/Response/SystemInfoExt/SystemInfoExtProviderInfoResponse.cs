using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Common.Response.SystemInfoExt;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.SystemInfoExt
{
   [DataContract]
   public class SystemInfoExtProviderInfoResponse : ISystemInfoExtProviderInfoResponse
   {
      [DataMember]
      public ushort ProviderNumber { get; set; }

      [DataMember]
      public string PartnerName { get; set; }

      [DataMember]
      public string PartnerAddress { get; set; }

      [DataMember]
      public string RedundantPartnerName { get; set; }

      [DataMember]
      public string RedundantPartnerAddress { get; set; }

      [DataMember]
      [DefaultValue("string")]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ProviderStatusType ProviderStatus { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public TProgStatus ProviderServerStatus { get; set; }

      [DataMember]
      [FormatDateTime(nameof(LastValueTime_FORMATTED))]
      public DateTime LastValueTime { get; set; }

      [DataMember]
      public string LastValueTime_FORMATTED { get; set; }
   }
}
