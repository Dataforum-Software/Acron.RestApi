using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   public interface ICreateGroupBaseObjectRequestResource : ICreateBaseObjectRequestResource
   {
      //IGroupBaseObject PropParentGroup
      //{
      //   get;set;
      //}

      //BaseObjectDefines.GroupType PropGroupType
      //{
      //   get;
      //}

      [SwaggerSchema("Check whether the group is a default group or not")]
      [SwaggerExampleValue("true")]
      bool IsDefaultGroup
      {
         get;
      }

   }
}