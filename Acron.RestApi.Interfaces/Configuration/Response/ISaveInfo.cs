using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface ISaveInfo
   {
      [SwaggerSchema($"Indicates whether the changes where saved successfully")]
      [SwaggerExampleValue(true)]
      bool Saved { get; set; }
   }
}