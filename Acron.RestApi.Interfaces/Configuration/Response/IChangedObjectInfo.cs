using Swashbuckle.AspNetCore.Annotations;
using static Acron.RestApi.Interfaces.BaseObjects.BaseObjectDefines;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public enum ModificationMode : int 
   {
      /// <summary>Neuanlage</summary>
      [SwaggerEnumInfo("Object added")]
      New = 0,

      /// <summary>Änderung</summary>
      [SwaggerEnumInfo("Object changed")]
      Changed = 1,

      /// <summary>Löschung</summary>
      [SwaggerEnumInfo("Object deleted")]
      Deleted = 2,
   }

   public interface IChangedObjectInfo
   {
      [SwaggerSchema("Type of configuration object")]
      [SwaggerExampleValue(RestObjectTypeCode.VgAuto)]
      string RestTypeCode { get; }
      
      [SwaggerSchema("Unique ID of configuration object")]
      [SwaggerExampleValue(302000001)]
      int Id { get; }

      [SwaggerSchema("Identification of configuration object")]
      [SwaggerExampleValue("SW10IL002")]
      string ShortName { get; }

      [SwaggerSchema("Designation of configuration object")]
      [SwaggerExampleValue("Sickerwasserbehälter")]
      string LongName { get; }

      [SwaggerSchema("Type of modification (New/Changed/Deleted)")]
      [SwaggerExampleValue("Changed")]
      string ModificationMode { get; }

   }
}