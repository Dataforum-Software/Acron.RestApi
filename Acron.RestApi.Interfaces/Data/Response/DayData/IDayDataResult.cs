using System;
using System.Collections.Generic;


namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface IDayDataResult
   {
      bool HasData { get; }
      int PVCount { get; }

      int TimeStampsCount { get; }

      List<DateTime> TimeStamps { get; set; }

      //ToDo Swagger
      List<string> TimeStamps_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> TimeStamps_TIMEZONE { get; set; }

      List<IDayData> Data { get; set; }      
   }
}
