using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   public interface IUpdateGroupBaseObjectRequestResource : IUpdateBaseObjectRequestResource
   {
      [SwaggerSchema("Check whether the group is a default group or not")]
      [SwaggerExampleValue("true")]
      bool IsDefaultGroup
      {
         get;
      }
   }
}