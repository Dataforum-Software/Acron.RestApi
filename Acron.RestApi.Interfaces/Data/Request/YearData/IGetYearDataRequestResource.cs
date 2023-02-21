using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.YearData
{
   public interface IGetYearDataRequestResource<T, U> where T : IGetYearDataPVDescription<U> where U : IYearWhat
   {
      YearTypes YearType { get; set; }
      DateTime FromTime { get; set; }
      DateTime FromTime_UTC { get; set; }
      DateTime ToTime { get; set; }
      DateTime ToTime_UTC { get; set; }

      List<T> PVDescriptions { get; set; }
   }

   public enum YearTypes : short
   {
      DBN_YEAR_WEEK  = DBN_CompTypes.DBN_YEAR_WEEK,
      DBN_YEAR_MONTH = DBN_CompTypes.DBN_YEAR_MONTH
   }

}
