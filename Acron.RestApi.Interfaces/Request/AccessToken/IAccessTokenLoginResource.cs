using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Request.AccessToken
{
   public interface IAccessTokenLoginResource
   {
      [SwaggerSchema(Description = "Valid AppName as configured in ACRON Admin")]
      [SwaggerExampleValue("testapp")]
      string AppName { get; }

      [SwaggerSchema(Description = "Corresponding password as configured in ACRON Admin")]
      [SwaggerExampleValue("test")]
      string Password { get; }
   }
}
