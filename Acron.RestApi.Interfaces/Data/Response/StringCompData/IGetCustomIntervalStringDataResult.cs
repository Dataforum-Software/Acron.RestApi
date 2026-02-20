using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.StringCompData
{
   public interface IGetCustomIntervalStringDataResult<T> where T : ICustomIntervalStringData
   {
      [SwaggerSchema("List of time stamps, one per value")]
      [SwaggerExampleValue(new string[] { "2022-10-12T00:00:00Z", "2022-10-13T00:00:00Z", "2022-10-14T00:00:00Z" })]
      List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema("List of time stamps, one per value")]
      [SwaggerExampleValue(new string[] { "2022-10-12T00:00:00Z", "2022-10-13T00:00:00Z", "2022-10-14T00:00:00Z" })]
      List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema("List of compression values in selected time range")]
      [SwaggerExampleValue(typeof(ICustomIntervalStringData))]
      List<T> Values { get; set; }
   }
}
