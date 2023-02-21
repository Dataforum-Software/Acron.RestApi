using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Request.AccessToken
{
   public interface IAccessTokenRefreshResource
   {
      [SwaggerSchema(Description = "Existing access token")]
      [SwaggerExampleValue("averylongbase64encodedstring")]
      string AccessToken { get; }

      [SwaggerSchema(Description = "Corresponding refresh token")]
      [SwaggerExampleValue("averylongbase64encodedstring")]
      string RefreshToken { get; }
   }
}
