using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   public class WriteHandValCommentsRequestResouce : IWriteHandValCommentsRequestResouce<WriteHandValCommentsPVDescription>
   {
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

      public List<WriteHandValCommentsPVDescription> PVDescriptions { get; set; }
   }
}
