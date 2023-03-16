using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcServiceUnavailableResponse : IApiControllerResponseBase
   {
      [SwaggerSchema("Send request again after timeout of n seconds")]
      [SwaggerExampleValue(10)]
      int RetryAfterSeconds { get; set; }
   }
}
