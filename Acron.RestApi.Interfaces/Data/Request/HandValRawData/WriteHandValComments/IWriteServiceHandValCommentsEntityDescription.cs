using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteServiceHandValCommentsEntityDescription
   {
      [SwaggerSchema("Numeric ID of service entity")]
      [SwaggerExampleValue(600200003)]
      public int ServiceEntityId { get; set; } 

      [SwaggerSchema("Comment")]
      [SwaggerExampleValue("New Comment")]
      public string Comment { get; set; } 
   }
}
