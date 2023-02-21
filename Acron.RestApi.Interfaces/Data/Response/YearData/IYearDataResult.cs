using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.YearData
{
   public interface IYearDataResult
   {
      public bool HasData { get; }
      public int PVCount { get; }

      public int TimeStampsCount { get; }

      public List<DateTime> TimeStamps { get; set; }

      //ToDo Swagger
      public List<string> TimeStamps_FORMATTED { get; set; }

      //ToDo Swagger
      public List<DateTime> TimeStamps_TIMEZONE { get; set; }

      public List<IYearData> Data { get; set; }
   }
}
