using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.IntervalData
{
   public interface IGetIntervalDataRequestResource<T,U> where T : IGetIntervalDataPVDescription<U> where U : IIntervalWhat
   {
      IntervalTypes IntervalType { get; set; }
      DateTime FromTime { get; set; }
      DateTime FromTime_UTC { get; set; }
      DateTime ToTime { get; set; }
      DateTime ToTime_UTC { get; set; }
      List<T> PVDescriptions { get; set; }
   }

   public enum IntervalTypes : short
   {
      DBN_INT_1 = DBN_CompTypes.DBN_INT_1,    //Interval 1 Daten
      DBN_INT_2 = DBN_CompTypes.DBN_INT_2,    //Interval 2 Daten
      DBN_INT_3 = DBN_CompTypes.DBN_INT_3,    //Interval 3 Daten
      DBN_INT_4 = DBN_CompTypes.DBN_INT_4,    //Interval 4 Daten
      DBN_INT_5 = DBN_CompTypes.DBN_INT_5,    //Interval 5 Daten
      DBN_INT_6 = DBN_CompTypes.DBN_INT_6,    //Interval 6 Daten
      DBN_INT_7 = DBN_CompTypes.DBN_INT_7,    //Interval 7 Daten
      DBN_INT_8 = DBN_CompTypes.DBN_INT_8,    //Interval 8 Daten
   }
}
