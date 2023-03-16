using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for main units
   /// </summary>
   public interface ICreateBaseUnitObjectRequestResource : ICreateUnitBaseRequestResource
   {
      /// <summary>
      /// Type of main unit (DaFo defined, user defined...)
      /// </summary>


      [SwaggerSchema("Type of main unit")]
      [SwaggerExampleValue(UnitDefines.UnitType.Default)]
      UnitDefines.UnitType RestApiUnitType { get; }

      /// <summary>
      /// Category of main unit
      /// </summary>

      [SwaggerSchema("Category of main unit")]
      [SwaggerExampleValue("")]
      string PropCategory { get; set; }

   }
}