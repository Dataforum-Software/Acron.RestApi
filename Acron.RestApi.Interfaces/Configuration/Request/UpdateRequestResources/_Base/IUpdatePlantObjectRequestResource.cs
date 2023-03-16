using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   /// <summary>
   /// Interface for plant designer  /// </summary>
   public interface IUpdatePlantObjectRequestResource : IUpdateBaseObjectRequestResource
   {
      /// <summary> Alert state </summary>
      /// <remarks> Default value == AlertDefines.Disturbance</remarks>
      // AlertDefines.AlertState PropState { get; set; }

      /// <summary> Plant version </summary>
      /// 
      [SwaggerSchema("Plant version")]
      [SwaggerExampleValue("9.4")]
      string PropVersion { get; }
   }
}