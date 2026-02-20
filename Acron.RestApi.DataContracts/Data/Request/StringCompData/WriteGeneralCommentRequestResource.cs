using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Acron.RestApi.Interfaces.Data.Request.StringCompData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.StringCompData
{
   public class WriteGeneralCommentRequestResource : IWriteGeneralCommentRequestResource
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public GeneralCommentKind CommentKind { get; set; }

      [DataMember]
      public DateTimeOffset TimeStamp { get; set; }

      public DateTime TimeStamp_UTC
      {
         get
         {
            return TimeStamp.UtcDateTime;
         }
      }

      [DataMember]
      public string Comment { get; set; }
   }
}
