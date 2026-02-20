using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   [DataContract]
   public class WriteServiceHandValCommentsRequestResource : IWriteServiceHandValCommentsRequestResource<WriteServiceHandValCommentsEntityDescription>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public ServiceCommentKind CommentKind { get; set; }

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
      [ObjectId]
      public List<WriteServiceHandValCommentsEntityDescription> EntityDescriptions { get; set; }
   }
}
