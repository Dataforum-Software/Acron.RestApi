using Acron.RestApi.Interfaces.Data.Request.DayData;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.IntervalData
{
   public interface IGetIntervalDataPVDescription<T> where T : IIntervalWhat
   {
      [SwaggerSchema("Numeric ID of Process Variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }


      [SwaggerSchema("Set of flags to select which properties to include in result")]
      [SwaggerExampleValue(typeof(IIntervalWhat))]
      T IntervalWhat { get; set; }
   }
}
