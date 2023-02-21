using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using static Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines.ConfigDefines;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IApiControllerResponseBase
   {
      [SwaggerSchema("HTTP status code as defined in RFC 9110")]
      [SwaggerExampleValue(200)]
      HttpStatusCode HttpStatusCode { get; }

      [SwaggerSchema("String representation of HTTP status code as defined in RFC 9110")]
      [SwaggerExampleValue("OK")]
      string HttpStatusCodeMessage { get; }

      [SwaggerSchema("Return code of REST API methods")]
      [SwaggerExampleValue(ConfigDefines.ApiActionResult.ApiToBusy)]
      ApiActionResult? ApiActionResult { get; }

      [SwaggerSchema("User friendly result message")]
      [SwaggerExampleValue("Example message.")]
      string Message { get; }
   }   
}
