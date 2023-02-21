using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   public class WriteHandValCommentsRequestResouce : IWriteHandValCommentsRequestResouce<WriteHandValCommentsPVDescription>
   {
      public AVComKinds AVComKind { get; set; }
      public DateTime TimeStamp { get; set; }
      public List<WriteHandValCommentsPVDescription> PVDescriptions { get; set; }
   }
}
