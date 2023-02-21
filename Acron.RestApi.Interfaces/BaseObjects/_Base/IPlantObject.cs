using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for plant designer  /// </summary>
   public interface IPlantObject : IBaseObject
   {
      /// <summary> Alert state </summary>
      /// <remarks> Default value == AlertDefines.Disturbance</remarks>
      // AlertDefines.AlertState PropState { get; set; }

      /// <summary> Plant version </summary>
      /// 
      [SwaggerSchema("Plant version")]
      [SwaggerExampleValue("9.4")]
      string PropVersion  { get; }
   }
}
