using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataDayValue
    {
        public DateTime DayStartTime { get; set; }
        public string DayComment { get; set; }

        public int DataCount { get; }

        public List<IGetHandValRawDataValue> Data { get; set; }
    }
}
