using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.IntervalData
{
   [DataContract]
   public class IntervalDataResult : IIntervalDataResult
   {
      [DataMember]
      public bool HasData 
      { 
         get
         {
            return PVCount > 0;
         }
      }

      [DataMember]
      public int PVCount
      {
         get
         {
            if (Data == null)
               return 0;

            return Data.Count;
         }
      }

      [DataMember]
      public int TimeStampsCount 
      { 
         get
         {
            if (TimeStamps == null)
               return 0;

            return TimeStamps.Count;
         }
      }

      [DataMember]
      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.IntervalX)]
      public List<DateTime> TimeStamps { get; set; }

      [DataMember]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [DataMember]
      public List<IIntervalData> Data { get; set; }
   }
}
