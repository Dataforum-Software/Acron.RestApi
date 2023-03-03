using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Response;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcBadCreateUpdateResponse : IApiControllerResponseBase
   {
      [SwaggerSchema("Requested API Method")]
      [SwaggerExampleValue("/api/v9.4/Test/HelloRestApi")]
      string RequestRoute { get; }

      [SwaggerSchema("User friendly error message")]
      [SwaggerExampleValue("Example error text!")]
      string ErrorText { get; }

      [SwaggerSchema("Type of the object(s) returned in Result")]
      [SwaggerExampleValue(nameof(IBaseObject))]
      string ResultType { get; }

      [SwaggerSchema("Number of objects returned in Result")]
      [SwaggerExampleValue(1)]
      int ResultCount { get; }

      [SwaggerSchema("Operation result")]
      [SwaggerExampleValue(typeof(IBaseObject))]
      ICreateUpdateResultList<ICreateUpdateResult> Result { get; }

   }
}
