using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.StringCompData;
using Acron.RestApi.Interfaces.Data.Response.StringCompData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.StringCompData
{
   [DataContract]
   public class GetGeneralCommentResult : IGetGeneralCommentResult
   {
      [DataMember]
      [FormatDateTime(nameof(Date_FORMATTED), DateTimeFormatType.Default)]
      public DateOnly Date { get; set; }

      [DataMember]
      public string Date_FORMATTED { get; set; }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public CDAT_Kind Kind { get; set; }

      [DataMember]
      public string Comment { get; set; }

      [DataMember]
      [FormatDateTime(nameof(EditDateTime_FORMATTED), DateTimeFormatType.Process)]
      public DateTime EditDateTime { get; set; }

      [DataMember]
      public string EditDateTime_FORMATTED { get; set; }

      [DataMember]
      public string User { get; set; }
   }
}
