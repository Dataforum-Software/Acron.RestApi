using Swashbuckle.AspNetCore.Annotations;

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
      [SwaggerExampleValue("Disturbance")]
      AlertDefines.AlertState PropState { get; set; }
   }


   public static class AlertDefines
   {
      /// <summary>
      /// Possible alert states
      /// </summary>
      public enum AlertState : int
      {
         /// <summary> Malfunction </summary>
         Disturbance = 0x1,
         /// <summary> Message </summary>
         Message = 0x2,
         /// <summary> Malfunction + Message</summary>
         DisturbanceAndMessage = 0x4,
         /// <summary> Disabled </summary>
         Locked = 0x8
      }

   }

}
