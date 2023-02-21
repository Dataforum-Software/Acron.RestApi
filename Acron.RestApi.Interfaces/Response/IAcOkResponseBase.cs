using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcOkResponseBase : IApiControllerResponseBase
   {
      [SwaggerSchema("Type of the object(s) returned in Result")]
      [SwaggerExampleValue(nameof(IBaseObject))]
      string ResultType { get; }

      [SwaggerSchema("Number of objects returned in Result")]
      [SwaggerExampleValue(1)]
      int ResultCount { get; }
   }
}
