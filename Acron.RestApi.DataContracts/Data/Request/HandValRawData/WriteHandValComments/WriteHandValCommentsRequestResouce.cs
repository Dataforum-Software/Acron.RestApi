using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   [DataContract]
   public class WriteHandValCommentsRequestResouce : IWriteHandValCommentsRequestResouce<WriteHandValCommentsPVDescription>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public AVComKinds AVComKind { get; set; }

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
      public List<WriteHandValCommentsPVDescription> PVDescriptions { get; set; }
   }
}
