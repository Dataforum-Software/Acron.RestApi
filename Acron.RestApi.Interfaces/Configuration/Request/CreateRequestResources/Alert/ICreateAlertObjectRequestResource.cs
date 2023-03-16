using Acron.RestApi.Interfaces.BaseObjects;
using static Acron.RestApi.Interfaces.BaseObjects.AlertDefines;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for alert objects
   /// </summary>
   public interface ICreateAlertObjectRequestResource : ICreateBaseObjectRequestResource
   {
      /// <summary> Alert state </summary>
      /// <remarks> Default value == AlertDefines.Disturbance</remarks>
      [SwaggerSchema("Alert state")]
      [SwaggerExampleValue(AlertState.Disturbance)]
      AlertDefines.AlertState PropState { get; set; }
   }
}