using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.MonthWeekData
{
   public interface IMonthWeekDataResult
   {
      public bool HasData { get; }

      public int PVCount { get; }

      public int TimeStampsCount { get; }

      public List<DateTime> TimeStamps { get; set; }

      //ToDo Swagger
      public List<string> TimeStamps_FORMATTED { get; set; }

      //ToDo Swagger
      public List<DateTime> TimeStamps_TIMEZONE { get; set; }

      public List<IMonthWeekData> Data { get; set; }
   }
}
