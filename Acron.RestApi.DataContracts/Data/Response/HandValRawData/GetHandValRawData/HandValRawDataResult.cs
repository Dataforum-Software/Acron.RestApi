using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData
{
   [DataContract]
    public class GetHandValRawDataResult : IGetHandValRawDataResult
    {
        [DataMember]
        public bool HasData
        {
            get { return PVList.Any(); }
        }

        [DataMember]
        public int PVCount
        {
            get { return PVList.Count; }
        }

        [DataMember]
        public List<IGetHandValRawData> PVList { get; set; } = new List<IGetHandValRawData>();
    }
}
