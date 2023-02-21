using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.DayData
{
   public interface IGetDayDataRequestResource<T, U> where T : IGetDayDataPVDescription<U> where U : IDayWhat
   {
      DayTypes DayType { get; set; }
      DateTime FromTime { get; set; }
      DateTime FromTime_UTC { get; set; }
      DateTime ToTime { get; set; }
      DateTime ToTime_UTC { get; set; }
      List<T> PVDescriptions { get; set; }
   }

   public enum DayTypes : short
   {
      DBN_DAY_1 = DBN_CompTypes.DBN_DAY_1,   //Tagesdaten aus Intervall 1 (Hauptintervall)
      DBN_DAY_2 = DBN_CompTypes.DBN_DAY_2,  //Tagesdaten aus Intervall 2 (Nebenintervall)
   }

}
