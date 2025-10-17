using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.StringCompData
{
   public interface IGetStringCompDataResultItem
   {
      [SwaggerSchema("Numeric ID of process value")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Identification of process value")]
      [SwaggerExampleValue("Temperature")]
      string ShortName { get; set; }

      [SwaggerSchema("List of result values")]
      [SwaggerExampleValue("{\"test\", \"test\", \"test\"}")]
      public List<string> Values { get; set; }
   }
}
