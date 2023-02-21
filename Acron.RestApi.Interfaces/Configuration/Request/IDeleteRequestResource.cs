using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IDeleteRequestResource
   {
      [SwaggerSchema("Identification of object to delete")]
      [SwaggerExampleValue(302000001)]
      int? BaseObjectID { get; }
   }
}