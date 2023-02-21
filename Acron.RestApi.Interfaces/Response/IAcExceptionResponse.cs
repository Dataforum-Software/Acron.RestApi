using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcExceptionResponse : IApiControllerResponseBase
   {
      [SwaggerSchema("Requested API Method")]
      [SwaggerExampleValue("/api/v9.4/Test/HelloRestApi")]
      string RequestRoute { get; }

      [SwaggerSchema("User friendly exception message")]
      [SwaggerExampleValue("Example error text!")]
      string ExceptionMessage { get; }

      [SwaggerSchema("Dump of exception stack trace")]
      [SwaggerExampleValue(" ")]
      string StackTrace { get; }
   }
}
