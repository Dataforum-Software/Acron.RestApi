using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.MonthWeekData
{
   public interface IGetMonthWeekDataPVDescription<T> where T : IMonthWeekWhat
   {
      [SwaggerSchema("Numeric ID of Process Variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Set of flags to select which properties to include in result")]
      [SwaggerExampleValue(typeof(IMonthWeekWhat))]
      T MonthWeekWhat { get; set; }
   }
}
