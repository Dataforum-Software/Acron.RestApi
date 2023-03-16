using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for main groups (sections of the configuration)
   /// </summary>
   public interface ICreateDefaultGroupObjectRequestResource : ICreateGroupBaseObjectRequestResource
   {
      /// <summary>
      /// Type of default group
      /// </summary>
      /// <remarks>Every type denotes one section of the configuration.
      /// This default group is the uppermost parent base object of all base objects in this section.</remarks>
      /// 

      [SwaggerSchema("Type of default group")]
      [SwaggerExampleValue("DefaultProcessVariables")]
      DefaultGroupDefines.GroupType PropGroupType
      {
         get;
      }

   }
}