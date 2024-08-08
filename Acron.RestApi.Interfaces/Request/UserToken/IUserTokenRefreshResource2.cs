using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Request.UserToken
{
   public interface IUserTokenRefreshResource2
   {
      [SwaggerSchema(Description = "The Acron token representing an active ACRON user")]
      [SwaggerExampleValue("averylongbase64encodedstring")]
      string UserToken { get; }
      [SwaggerSchema(Description = "Corresponding refresh token")]
      [SwaggerExampleValue("averylongbase64encodedstring")]
      string RefreshToken { get; }
   }
}
