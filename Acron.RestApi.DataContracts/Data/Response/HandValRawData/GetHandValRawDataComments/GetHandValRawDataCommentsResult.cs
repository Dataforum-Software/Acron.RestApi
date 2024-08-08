using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData.GetHandVarRawDataCommentsResult;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawDataComments
{
   [DataContract]
   public class GetHandValRawDataCommentsResult : IGetHandValRawDataCommentsResult<HandValRawDataComment>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public CompTypes Kind { get; set; }

      [DataMember]
      [FormatDateTime(nameof(FromTime_FORMATTED))]
      public DateTime FromTime { get; set; }

      [DataMember]
      public string FromTime_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(ToTime_FORMATTED))]
      public DateTime ToTime { get; set; }

      [DataMember]
      public string ToTime_FORMATTED { get; set; }

      [DataMember]
      public uint ElementCount { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(TimeValues_FORMATTED), DateTimeFormatType.Default)]
      public List<DateTime> TimeValues { get; set; }

      [DataMember]
      public List<string> TimeValues_FORMATTED { get; set; }

      [DataMember]
      public List<HandValRawDataComment> CommentData { get; set; }



   }
}
