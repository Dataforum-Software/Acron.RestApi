using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.StringCompData
{
   public interface ICustomIntervalStringData
   {
      [SwaggerSchema("Numeric ID of a process value")]
      [SwaggerExampleValue(302000028)]
      uint PVID { get; set; }

      [SwaggerSchema("Unique shortname (identifikation) of a process value")]
      [SwaggerExampleValue("Charge")]
      string ShortName { get; set; }

      [SwaggerSchema("List of result values")]
      [SwaggerExampleValue("{\"test\", \"test\", \"test\"}")]
      public List<string> Values { get; set; }
   }
}
