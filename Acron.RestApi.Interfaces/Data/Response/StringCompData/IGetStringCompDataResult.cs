using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.StringCompData
{
   public interface IGetStringCompDataResult<T> where T : IGetStringCompDataResultItem
   {
      [SwaggerSchema("List of time stamps, one per value")]
      [SwaggerExampleValue(new string[] { "2022-10-12T00:00:00Z", "2022-10-13T00:00:00Z", "2022-10-14T00:00:00Z" })]
      List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema($"{nameof(TimeStamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "12.10.2022 00:00:00", "13.10.2022 00:00:00", "14.10.2022 00:00:00" })]
      List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema("List of compression values in selected time range")]
      [SwaggerExampleValue(typeof(IGetStringCompDataResultItem))]
      List<T> Values { get; set; }
   }
}
