using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataNum : ITDataBase
   {

      [SwaggerSchema("Numeric value")]
      [SwaggerExampleValue(10.0)]
      double Value { get; set; }

      [SwaggerSchema("Numeric value formatted")]
      [SwaggerExampleValue("10,0")]
      string Value_FORMATTED { get; set; }
   }
}
