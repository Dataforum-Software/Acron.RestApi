using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData
{
   [DataContract]
   public class GetHandValRawDataDayValue : IGetHandValRawDataDayValue
   {
      [DataMember]
      [FormatDateTime(nameof(DayStartTime_FORMATTED), DateTimeFormatType.Day1)]
      public DateTimeOffset DayStartTime { get; set; }

      [DataMember]
      public string DayStartTime_FORMATTED { get; set; }

      [DataMember]
      public string DayComment { get; set; }

      [DataMember]
      public int DataCount
      {
         get { return Data.Count; }
      }

      [DataMember]
      public List<IGetHandValRawDataValue> Data { get; set; } = new List<IGetHandValRawDataValue>();
   }
}
