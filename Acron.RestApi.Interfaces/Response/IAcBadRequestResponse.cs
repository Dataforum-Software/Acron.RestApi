using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcBadRequestResponse : IApiControllerResponseBase
   {
      [SwaggerSchema("Requested API Method")]
      [SwaggerExampleValue("/api/v9.4/Test/HelloRestApi")]
      string RequestRoute { get; }

      [SwaggerSchema("User friendly error message")]
      [SwaggerExampleValue("Example error text!")]
      string ErrorText { get; }
   }
}
