using Swashbuckle.AspNetCore.Annotations;
using static Acron.RestApi.Interfaces.BaseObjects.BaseObjectDefines;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface IRestObjectInfo
   {
      /// <summary> Typ des Objects </summary>
      [SwaggerSchema("Object type")]
      [SwaggerExampleValue(RestObjectTypeCode.Alert)]
      string RestTypeCode { get; }

      /// <summary> Hauptgruppe des Objects / Bereich </summary>
      [SwaggerSchema("Default group this object belongs to")]
      [SwaggerExampleValue(RestObjectTypeCode.AlertGroup)]
      string DefaultGroupType { get; }

      /// <summary>
      /// true - Objekte dieses Typs können nicht geändert werden
      /// </summary>
      [SwaggerSchema("Is this object editable")]
      [SwaggerExampleValue(false)]
      bool IsReadOnly { get; }

      /// <summary>
      /// Alle gültigen IDs für diesen Objekt-Typ
      /// </summary>
      [SwaggerSchema("Minimum and maximum permissible identifier")]
      [SwaggerExampleValue("301000000-301999999")]
      string NumberRange { get; }

   }
}
