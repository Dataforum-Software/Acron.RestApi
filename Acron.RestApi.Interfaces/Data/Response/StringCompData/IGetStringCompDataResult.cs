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
      [SwaggerExampleValue("[\"2022-10-12T00:00:00Z\", \"2022-10-13T00:00:00Z\", \"2022-10-14T00:00:00Z\"")]
      List<DateTime> TimeStamps { get; set; }

      [SwaggerSchema("List of compression values in selected time range")]
      [SwaggerExampleValue("[\"Drei-Vier-Fünf\", \"One-Two-Three\", \"Dix-Neuf-Sept\"]")]
      List<T> Values { get; set; }
   }
}
