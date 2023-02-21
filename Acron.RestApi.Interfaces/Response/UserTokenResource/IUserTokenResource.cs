using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.Response.UserToken
{
   public interface IUserTokenResource
   {
      [SwaggerSchema("The Acron token representing an active ACRON user during subsequent API calls")]
      [SwaggerExampleValue("")]
      string UserToken { get; }

      [SwaggerSchema("Timestamp in UTC until which the token is valid")]
      [SwaggerExampleValue("")]
      DateTime ExpiresUTC { get; }

      [SwaggerSchema("Timestamp in UTC when the token was issued")]
      [SwaggerExampleValue("")]
      DateTime IssuedUTC { get; }

      [SwaggerSchema("Secondary token used to acquire a new Bearer token before it expires")]
      [SwaggerExampleValue("")]
      string RefreshToken { get; }

      [SwaggerSchema("Timestamp in UTC until which the refresh token is valid")]
      [SwaggerExampleValue("")]
      DateTime RefreshTokenExpiresUTC { get; }
   }
}
