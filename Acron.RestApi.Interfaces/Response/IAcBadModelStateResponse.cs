using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Response
{
   public interface IAcBadModelStateResponse : IAcBadRequestResponse
   {
      [SwaggerSchema("")]
      [SwaggerExampleValue("")]
      object ModelStateDictionary { get; set; }
   }
}
