using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Acron.RestApi.Interfaces.Data.Request.HandValStringData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IWritePvCommentsRequestResource<T> where T : IWriteCommentsPVDescription
   {
      [SwaggerSchema("Different comment type")]
      [SwaggerExampleValue(PvCommentsKind.PVMON)]
      public PvCommentsKind CommentKind { get; set; }

      [SwaggerSchema("Time stamp for manual values of process variables")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset TimeStamp { get; set; }

      public DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("List of process variable description")]
      [SwaggerExampleValue(typeof(IWriteCommentsPVDescription))]
      public List<T> PVDescriptions { get; set; }
   }
}
