using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.MonthWeekData
{
   public interface IGetMonthWeekDataRequestResource<T, U> where T : IGetMonthWeekDataPVDescription<U> where U : IMonthWeekWhat
   {
      MonthWeekTypes MonthWeekType { get; set; }
      public DateTime FromTime { get; set; }
      public DateTime FromTime_UTC { get; set; }
      public DateTime ToTime { get; set; }
      public DateTime ToTime_UTC { get; set; }
      List<T> PVDescriptions { get; set; }
   }

   public enum MonthWeekTypes : short
   {
      DBN_WEEK    = DBN_CompTypes.DBN_WEEK,
      DBN_MONTH   = DBN_CompTypes.DBN_MONTH,
   }

}
