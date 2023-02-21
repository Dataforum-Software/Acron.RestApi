using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   public interface IGroupBaseObject : IBaseObject
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
