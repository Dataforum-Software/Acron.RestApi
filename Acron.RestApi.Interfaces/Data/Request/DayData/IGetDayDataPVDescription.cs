using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.DayData
{
   public interface IGetDayDataPVDescription<T> where T : IDayWhat
   {
      [SwaggerSchema("Identification of Process Variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Set of flags to select which properties to include in result")]
      [SwaggerExampleValue(typeof(IDayWhat))]
      T DayWhat { get; set; }
   }
}
