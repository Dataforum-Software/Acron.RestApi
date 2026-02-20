using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Common.Response.ChangeProtocol;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.ChangeProtocol
{
   [DataContract]
   public class DataProtocol : IDataProtocol
   {
      [DataMember]
      [FormatDateTime(nameof(Time_FORMATTED))]
      public DateTime Time { get; set; }

      [DataMember]
      public string Time_FORMATTED { get; set; }

      [DataMember]
      public string User { get; set; }

      [DataMember]
      [TranslateKey(FallbackTranslationType.Empty)]
      public string Dialog { get; set; }

      [DataMember]
      [TranslateKey(FallbackTranslationType.Empty)]
      public string Page { get; set; }

      [DataMember]
      [TranslateKey(FallbackTranslationType.Empty)]
      public string Field { get; set; }

      [DataMember]
      [TranslateKey(fallbackTranslationType: FallbackTranslationType.Key, usedParams: nameof(ObjectKey))]
      public string ActionType { get; set; }

      [DataMember]
      public string ObjectKey { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ACP_STATE Status { get; set; }

      [DataMember]
      [TranslateKey(FallbackTranslationType.Key)]
      public string Module { get; set; }

      [DataMember]
      public string OldValue { get; set; }

      [DataMember]
      public string NewValue { get; set; }

      [DataMember]
      [FormatDateTime(nameof(TimestampData_FORMATTED))]
      public DateTime TimestampData { get; set; }

      [DataMember]
      public string TimestampData_FORMATTED { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ArchiveType ArchiveType { get; set; }

      [DataMember]
      [TranslateKey]
      public string ProtocolType { get; set; }

      [DataMember]
      public bool DetailOnly { get; set; }
   }
}
