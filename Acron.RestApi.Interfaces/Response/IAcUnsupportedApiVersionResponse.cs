using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcUnsupportedApiVersionResponse : IAcBadRequestResponse
   {
      [SwaggerSchema("Exception error code")]
      [SwaggerExampleValue("")]
      string ErrorCode { get; }

      [SwaggerSchema("Detailed error description")]
      [SwaggerExampleValue("")]
      string ErrorDetail { get; }
   }
}
