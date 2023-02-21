using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataResult
    {
        bool HasData { get; }
        int PVCount { get; }

        List<IGetHandValRawData> PVList { get; set; }
    }
}
