using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IResult<T>
   {
      [SwaggerSchema("Type of the object(s) returned in Result")]
      [SwaggerExampleValue(nameof(IBaseObject))]
      string ResultType { get; set; }

      [SwaggerSchema("Number of objects returned in Result")]
      [SwaggerExampleValue(1)]
      int ResultCount { get; set; }

      [SwaggerSchema("Operation result")]
      [SwaggerExampleValue(typeof(IBaseObject))]
      T Result { get; set; }
   }
}
