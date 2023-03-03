using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.MonthWeekData
{
   public interface IGetMonthWeekDataRequestResource<T, U> where T : IGetMonthWeekDataPVDescription<U> where U : IMonthWeekWhat
   {
      [SwaggerSchema("Interval data from weekly or monthly intervals")]
      [SwaggerExampleValue(MonthWeekTypes.DBN_MONTH)]
      MonthWeekTypes MonthWeekType { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T00:00:00Z")]
      public DateTimeOffset FromTime { get; set; }

      public DateTime FromTime_UTC { get; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-25T00:00:00Z")]
      public DateTimeOffset ToTime { get; set; }

      public DateTime ToTime_UTC { get; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetMonthWeekDataPVDescription<IMonthWeekWhat>))]
      List<T> PVDescriptions { get; set; }
   }

   public enum MonthWeekTypes : short
   {
      [SwaggerEnumInfo("Weekly interval")]
      DBN_WEEK    = DBN_CompTypes.DBN_WEEK,

      [SwaggerEnumInfo("Monthly interval")]
      DBN_MONTH   = DBN_CompTypes.DBN_MONTH,
   }

}
