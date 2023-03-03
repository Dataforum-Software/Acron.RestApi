using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.YearData
{
   public interface IGetYearDataPVDescription<T> where T : IYearWhat
   {
      [SwaggerSchema("Numeric ID of Process Variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Set of flags to select which properties to include in result")]
      [SwaggerExampleValue(typeof(IYearWhat))]
      T YearWhat { get; set; }
   }
}
