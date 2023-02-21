using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcOkResponse : IAcOkResponseBase
   {
      [SwaggerSchema("Operation result")]
      [SwaggerExampleValue(typeof(IBaseObject))]
      object Result { get; }
   }
}
