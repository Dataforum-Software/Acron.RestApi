using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IObjectInfoEnhancedRequestResource
   {
      [SwaggerSchema("Identification of object to retrieve")]
      [SwaggerExampleValue(302000001)]
      int? BaseObjectID { get; }

      [SwaggerSchema("Include Identifications of config objects referenced by this object")]
      [SwaggerExampleValue(true)]
      bool ShowReferencedObjects { get; }

      [SwaggerSchema("Include Identifications of config objects that reference this object")]
      [SwaggerExampleValue(false)]
      bool ShowObjectUsages { get; }
   }
}