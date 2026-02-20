using Acron.RestApi.Interfaces.Data.Request.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.MonthWeekData
{
    public interface IGetCompressionForIntervalOfMonthWeekDataRequestResource<T, U> where T : IGetMonthWeekDataPVDescription<U> where U : IMonthWeekWhat
   {
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-01")]
      DateOnly FromDate { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-09-01")]
      DateOnly ToDate { get; set; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetDayDataPVDescription<IDayWhat>))]
      List<T> PVDescriptions { get; set; }

      [SwaggerSchema("Interval data from weekly or monthly intervals")]
      [SwaggerExampleValue(MonthWeekTypes.DBN_MONTH)]
      MonthWeekTypes MonthWeekType { get; set; }

      [SwaggerSchema("Guid of formerly requested result")]
      [SwaggerExampleValue("d9262d90-5feb-4d55-b9b8-2b12093abd25")]
      Guid ResultID { get; set; }

      [SwaggerSchema($"If this property is true, the operation with the given {nameof(ResultID)} will be canceled")]
      [SwaggerExampleValue(false)]
      bool CancelOperation { get; set; }
   }
}
