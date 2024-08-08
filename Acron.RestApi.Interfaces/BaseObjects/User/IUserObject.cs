using Swashbuckle.AspNetCore.Annotations;
using static Acron.RestApi.Interfaces.BaseObjects.AlertDefines;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for user objects
   /// </summary>
   public interface IUserObject : IBaseObject
   {
      /// <summary> Login </summary>
      [SwaggerSchema("Login")]
      [SwaggerExampleValue("acron")]
      string PropLogin { get; }

      /// <summary> First name </summary>
      [SwaggerSchema("First name")]
      [SwaggerExampleValue("Kevin")]
      string PropFirstName { get; }

      /// <summary> Last name </summary>
      [SwaggerSchema("Last name")]
      [SwaggerExampleValue("Smith")]
      string PropLastName { get; }

      /// <summary> Mail adress </summary>
      [SwaggerSchema("Mail adress")]
      [SwaggerExampleValue("ksmith@smiths.com")]
      string PropEmailAdress { get; }
   }

}