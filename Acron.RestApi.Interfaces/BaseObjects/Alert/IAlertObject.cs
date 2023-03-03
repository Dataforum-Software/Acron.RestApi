using Swashbuckle.AspNetCore.Annotations;
using static Acron.RestApi.Interfaces.BaseObjects.AlertDefines;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for alert objects
   /// </summary>
   public interface IAlertObject : IBaseObject
   {
      /// <summary> Alert state </summary>
      /// <remarks> Default value == AlertDefines.Disturbance</remarks>
      [SwaggerSchema("Alert state")]
      [SwaggerExampleValue(AlertState.Disturbance)]
      AlertDefines.AlertState PropState { get; set; }
   }


   public static class AlertDefines
   {
      /// <summary>
      /// Possible alert states
      /// </summary>
      [SwaggerSchema("Possible alert states")]
      public enum AlertState : int
      {
         /// <summary> Malfunction </summary>
         [SwaggerEnumInfo("Malfunction")]
         Disturbance = 0x1,
         /// <summary> Message </summary>
         [SwaggerEnumInfo("Message")]
         Message = 0x2,
         /// <summary> Malfunction + Message</summary>
         [SwaggerEnumInfo("Malfunction and Message")]
         DisturbanceAndMessage = 0x4,
         /// <summary> Disabled </summary>
         [SwaggerEnumInfo("Disabled")]
         Locked = 0x8
      }

   }

}
