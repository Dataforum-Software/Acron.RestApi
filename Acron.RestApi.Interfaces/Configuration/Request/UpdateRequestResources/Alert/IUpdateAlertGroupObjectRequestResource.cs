using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   /// <summary>
   /// Interface for alert groups
   /// </summary>
   public interface IUpdateAlertGroupObjectRequestResource : IUpdateGroupBaseObjectRequestResource
   {
      /// <summary>
      /// Type of alert group - custom or predefined by ACRON
      /// </summary>
      /// 

      [SwaggerSchema("Type of alert group")]
      [SwaggerExampleValue("UserDefined")]
      AlertGroupDefines.GroupType PropGroupType { get; }
   }
}