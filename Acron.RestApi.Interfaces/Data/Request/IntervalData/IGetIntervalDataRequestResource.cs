using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.DayData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.IntervalData
{
   public interface IGetIntervalDataRequestResource<T,U> where T : IGetIntervalDataPVDescription<U> where U : IIntervalWhat
   {
      [SwaggerSchema("Interval data from specific interval (Main, Secondary, custom)")]
      [SwaggerExampleValue(IntervalTypes.DBN_INT_1)]
      IntervalTypes IntervalType { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T12:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      DateTime FromTime_UTC { get; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-15T16:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      DateTime ToTime_UTC { get; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetIntervalDataPVDescription<IIntervalWhat>))]
      List<T> PVDescriptions { get; set; }
   }

   public enum IntervalTypes : short
   {
      [SwaggerEnumInfo("Main interval")]
      DBN_INT_1 = DBN_CompTypes.DBN_INT_1,    //Interval 1 Daten

      [SwaggerEnumInfo("Secondary interval")]
      DBN_INT_2 = DBN_CompTypes.DBN_INT_2,    //Interval 2 Daten

      [SwaggerEnumInfo("Custom interval 1")]
      DBN_INT_3 = DBN_CompTypes.DBN_INT_3,    //Interval 3 Daten

      [SwaggerEnumInfo("Custom interval 2")]
      DBN_INT_4 = DBN_CompTypes.DBN_INT_4,    //Interval 4 Daten

      [SwaggerEnumInfo("Custom interval 3")]
      DBN_INT_5 = DBN_CompTypes.DBN_INT_5,    //Interval 5 Daten

      [SwaggerEnumInfo("Custom interval 4")]
      DBN_INT_6 = DBN_CompTypes.DBN_INT_6,    //Interval 6 Daten

      [SwaggerEnumInfo("Custom interval 5")]
      DBN_INT_7 = DBN_CompTypes.DBN_INT_7,    //Interval 7 Daten

      [SwaggerEnumInfo("Custom interval 6")]
      DBN_INT_8 = DBN_CompTypes.DBN_INT_8,    //Interval 8 Daten
   }
}
