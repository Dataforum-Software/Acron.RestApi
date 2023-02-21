using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IGetSubObjectsRequestResource
   {
      [SwaggerSchema("Identification of parent object")]
      [SwaggerExampleValue(301000001)]
      int? BaseObjectID { get; }

      [SwaggerSchema("Retrieve child objects and groups")]
      [SwaggerExampleValue(true)]
      bool? WithFolder { get; }

      [SwaggerSchema("Retrieve only a small subset of identifying properties")]
      [SwaggerExampleValue(false)]
      bool SmallObjects { get; }

      [SwaggerSchema("Retrieve only direct children instead of recursively")]
      [SwaggerExampleValue(false)]
      bool OnlyDirectChilds { get; }
   }
}