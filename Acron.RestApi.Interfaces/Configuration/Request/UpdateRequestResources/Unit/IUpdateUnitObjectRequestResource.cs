using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   /// <summary>
   /// Interface for units
   /// </summary>
   public interface IUpdateUnitObjectRequestResource : IUpdateUnitBaseRequestResource
   {

      /// <summary>
      /// Type of main unit (DaFo defined, user defined...)
      /// </summary>

      [SwaggerSchema("Type of main unit")]
      [SwaggerExampleValue("User")]

      UnitDefines.UnitType RestApiUnitType { get; }

      /// <summary>
      /// Factor to be multiplied with base unit
      /// </summary>

      [SwaggerSchema("Factor to multiply with base unit")]
      [SwaggerExampleValue("10")]
      double PropFactor { get; set; }

      /// <summary>
      /// Offset to base unit
      /// </summary>
      [SwaggerSchema("Offset to base unit")]
      [SwaggerExampleValue("502")]
      double PropOffset { get; set; }

   }
}