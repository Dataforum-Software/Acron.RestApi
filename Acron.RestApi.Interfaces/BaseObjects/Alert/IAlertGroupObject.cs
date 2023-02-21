using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for alert groups
   /// </summary>
   public interface IAlertGroupObject : IGroupBaseObject
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
         UserDefined = 0,
         Default = 1,
      }

   }
}
