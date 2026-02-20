using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValComments
{
   public interface IWriteCommentsResult
   {
      [SwaggerSchema("Writing comments succeeded")]
      [SwaggerExampleValue(true)]
      bool Result { get; set; }
   }
}
