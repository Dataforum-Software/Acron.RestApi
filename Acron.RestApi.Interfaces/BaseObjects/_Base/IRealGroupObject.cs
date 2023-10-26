using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   public interface IRealGroupObject : IGroupBaseObject
   {
      [SwaggerSchema("Additional text for this group")]
      [SwaggerExampleValue("This is additional text for this group")]
      string PropGroupInfo
      {
         get; set;
      }

      [SwaggerSchema("Color-Index of this group (0=default)")]
      [SwaggerExampleValue("0")]
      int PropColorIndex
      {
         get; set;
      }

   }

}
