using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.DayData;
using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.YearData
{
   public interface IGetYearDataRequestResource<T, U> where T : IGetYearDataPVDescription<U> where U : IYearWhat
   {
      [SwaggerSchema("Day data from main or secondary interval")]
      [SwaggerExampleValue(YearTypes.DBN_YEAR_WEEK)]
      YearTypes YearType { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T00:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      DateTime FromTime_UTC { get; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2021-08-14T00:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      DateTime ToTime_UTC { get; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetYearDataPVDescription<IYearWhat>))]
      List<T> PVDescriptions { get; set; }
   }

   public enum YearTypes : short
   {
      [SwaggerEnumInfo("Yearly value from weekly values")]
      DBN_YEAR_WEEK  = DBN_CompTypes.DBN_YEAR_WEEK,

      [SwaggerEnumInfo("Yearly value from monthly values")]
      DBN_YEAR_MONTH = DBN_CompTypes.DBN_YEAR_MONTH
   }

}
