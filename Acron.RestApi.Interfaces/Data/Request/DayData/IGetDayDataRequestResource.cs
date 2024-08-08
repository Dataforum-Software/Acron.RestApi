using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.DayData
{
   public interface IGetDayDataRequestResource<T, U> where T : IGetDayDataPVDescription<U> where U : IDayWhat
   {
      [SwaggerSchema("Day data from main or secondary interval")]
      [SwaggerExampleValue(DayTypes.DBN_DAY_1)]
      DayTypes DayType { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15")]
      DateOnly FromDate { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-16")]
      DateOnly ToDate { get; set; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetDayDataPVDescription<IDayWhat>))]
      List<T> PVDescriptions { get; set; }
   }

   public interface IGetDayDataRequestResource__L9_4__10_0<T, U> where T : IGetDayDataPVDescription<U> where U : IDayWhat
   {
      [SwaggerSchema("Day data from main or secondary interval")]
      [SwaggerExampleValue(DayTypes.DBN_DAY_1)]
      DayTypes DayType { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T00:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      DateTime FromTime_UTC { get; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-16T00:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      DateTime ToTime_UTC { get; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetDayDataPVDescription<IDayWhat>))]
      List<T> PVDescriptions { get; set; }
   }

   public enum DayTypes : short
   {
      [SwaggerEnumInfo("Daily value from main interval")]
      DBN_DAY_1 = DBN_CompTypes.DBN_DAY_1,   //Tagesdaten aus Intervall 1 (Hauptintervall)

      [SwaggerEnumInfo("Daily value from secondary interval")]
      DBN_DAY_2 = DBN_CompTypes.DBN_DAY_2,  //Tagesdaten aus Intervall 2 (Nebenintervall)
   }

}
