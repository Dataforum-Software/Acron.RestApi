using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData
{
   [DataContract]
   public class GetHandValRawData : IGetHandValRawData<GetHandValRawDataDayValue, GetHandValRawDataValue, GetHandValRawDataFlag>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public int DaysCount
      {
         get { return DayList.Count; }
      }

      [DataMember]
      public List<GetHandValRawDataDayValue> DayList { get; set; } = new List<GetHandValRawDataDayValue>();
   }
}
