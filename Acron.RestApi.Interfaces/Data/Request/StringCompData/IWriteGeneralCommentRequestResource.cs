using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.StringCompData
{
   public interface IWriteGeneralCommentRequestResource
   {
      [SwaggerSchema("Different comment type")]
      [SwaggerExampleValue(GeneralCommentKind.WEEK)]
      public GeneralCommentKind CommentKind { get; set; } 

      [SwaggerSchema("Time stamp for manual values of process variables")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset TimeStamp { get; set; } 

      public DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("General comment for given timeframe")]
      [SwaggerExampleValue("'Tis a comment!")]
      public string Comment { get; set; } 
   }
}
