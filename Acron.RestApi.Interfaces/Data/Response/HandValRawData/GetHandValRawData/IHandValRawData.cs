using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawData
    {
        public uint PVID { get; set; }

        public int DaysCount { get; }

        public List<IGetHandValRawDataDayValue> DayList { get; set; }
    }
}
