using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Request.UserToken
{
   public interface IUserTokenRefreshResource
   {
      [SwaggerSchema(Description = "Corresponding refresh token")]
      [SwaggerExampleValue("averylongbase64encodedstring")]
      string RefreshToken { get; }
   }
}
