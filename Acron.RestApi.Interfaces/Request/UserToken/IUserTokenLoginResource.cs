using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Request.UserToken
{
   public interface IUserTokenLoginResource : IUserTokenLoginResourceWithoutPassword
   {
      [SwaggerSchema(Description = "Corresponding password of acron user")]
      [SwaggerExampleValue("")]
      string Password { get; }
   }
}
