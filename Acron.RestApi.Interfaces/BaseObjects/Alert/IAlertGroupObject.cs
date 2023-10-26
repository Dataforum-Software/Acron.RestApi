using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for alert groups
   /// </summary>
   public interface IAlertGroupObject : IRealGroupObject
   {
      /// <summary>
      /// Type of alert group - custom or predefined by ACRON
      /// </summary>
      /// 

      [SwaggerSchema("Type of alert group")]
      [SwaggerExampleValue("UserDefined")]
      AlertGroupDefines.GroupType PropGroupType { get; }
   }

   public static class AlertGroupDefines
   {
      public enum GroupType : int
      {
         [SwaggerEnumInfo("User created group")]
         UserDefined = 0,

         [SwaggerEnumInfo("ACRON default group")]
         Default = 1,
      }

   }
}
