using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.Response.AccessToken
{
   public interface IAccessTokenResource
   {
      [SwaggerSchema("The Bearer token used to authenticate subsequent API calls")]
      [SwaggerExampleValue("averylongbase64encodedstring")]
      string AccessToken { get; }

      [SwaggerSchema("Timestamp in UTC until which the token is valid")]
      [SwaggerExampleValue("2020-08-15T16:20:00")]
      DateTime ExpiresUTC { get; }

      [SwaggerSchema("Timestamp in UTC when the token was issued")]
      [SwaggerExampleValue("2020-08-15T16:00:00")]
      DateTime  IssuedUTC { get; }

      [SwaggerSchema("Secondary token used to acquire a new Bearer token before it expires")]
      [SwaggerExampleValue("averylongbase64encodedstring")]
      string RefreshToken { get; }

      [SwaggerSchema("Timestamp in UTC until which the refresh token is valid")]
      [SwaggerExampleValue("2020-08-15T16:40:00")]
      DateTime RefreshTokenExpiresUTC { get; }
   }
}