using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   public interface IUpdateRealGroupObjectRequestResource : IUpdateGroupBaseObjectRequestResource
   {
      [SwaggerSchema("Additional text for this group")]
      [SwaggerExampleValue("This is additional text for this group")]
      string PropGroupInfo
      {
         get; set;
      }

      [SwaggerSchema("Color-Index of this group (0-15 valid; 0-default)")]
      [SwaggerExampleValue("0")]
      int PropColorIndex
      {
         get; set;
      }

   }
}