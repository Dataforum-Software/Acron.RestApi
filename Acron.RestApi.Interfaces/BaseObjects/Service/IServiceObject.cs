using Swashbuckle.AspNetCore.Annotations;
using static Acron.RestApi.Interfaces.BaseObjects.AlertDefines;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for service objects
   /// </summary>
   public interface IServiceObject : IBaseObject
   {
      ///// <summary> Alert state </summary>
      ///// <remarks> Default value == AlertDefines.Disturbance</remarks>
      //[SwaggerSchema("Alert state")]
      //[SwaggerExampleValue(AlertState.Disturbance)]
      //AlertDefines.AlertState PropState { get; set; }
   }

}
