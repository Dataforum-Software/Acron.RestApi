using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;
using static Acron.RestApi.Interfaces.BaseObjects.BaseObjectDefines;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface IErrorItem
   {
      /// <summary> Typ des Objects </summary>
      [SwaggerSchema("Object type")]
      [SwaggerExampleValue(RestObjectTypeCode.VgAuto)]
      BaseObjectDefines.RestObjectTypeCode RestTypeCode { get; set; }

      /// <summary> Id des Acron-BaseObjects </summary>
      [SwaggerSchema("Object identifier")]
      [SwaggerExampleValue(302000001)]
      int Id { get; set; }

      /// <summary> Name </summary>
      [SwaggerSchema("Object identifier")]
      [SwaggerExampleValue(302000001)]
      string[] AffectedPropertyKey { get; set; }

      /// <summary> Fehlertext </summary>
      [SwaggerSchema("Object identifier")]
      [SwaggerExampleValue(302000001)]
      string Text { get; set; }

   }
}