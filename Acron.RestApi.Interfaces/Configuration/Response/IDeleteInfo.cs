using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface IDeleteInfo
   {
      [SwaggerSchema($"Indicates whether the selected item was deleted successfully")]
      [SwaggerExampleValue(true)]
      bool Deleted { get; set; }
   }
}