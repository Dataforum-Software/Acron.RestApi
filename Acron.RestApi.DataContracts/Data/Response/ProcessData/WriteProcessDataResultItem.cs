using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{
   [DataContract]
   public class WriteProcessDataResultItem : IWriteProcessDataResultItem
   {
      [DataMember]
      public string DBServerTimeZone { get; set; }

      [DataMember]
      [FormatDateTime(nameof(From_FORMATTED))]
      public DateTime From_UTC { get; set; }

      [DataMember]
      public string From_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(To_FORMATTED))]
      public DateTime To_UTC { get; set; }

      [DataMember]
      public string To_FORMATTED { get; set; }

      [DataMember]
      [DefaultValue("")]
      public string ErrorText { get; set; } = string.Empty;

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      [DefaultValue(WriteProcessDataErrors.Unknown)]
      public WriteProcessDataErrors Result { get; set; } = WriteProcessDataErrors.Unknown;
   }
}
