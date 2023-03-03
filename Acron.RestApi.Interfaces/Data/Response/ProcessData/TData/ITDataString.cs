using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataString : ITDataBase
   {

      [SwaggerSchema("Text value")]
      [SwaggerExampleValue("Rainy")]
      string Value { get; set; }
   }
}
