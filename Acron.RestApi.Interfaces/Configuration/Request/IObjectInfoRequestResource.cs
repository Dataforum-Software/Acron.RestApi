using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IObjectInfoRequestResource
   {
      [SwaggerSchema("Identification of object to retrieve")]
      [SwaggerExampleValue(302000001)]
      int? BaseObjectID { get; }
   }
}