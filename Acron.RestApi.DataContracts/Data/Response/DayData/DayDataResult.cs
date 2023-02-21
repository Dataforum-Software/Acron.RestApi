using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.DayData;


namespace Acron.RestApi.DataContracts.Data.Response.DayData
{
   [DataContract]
   public class DayDataResult : IDayDataResult
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
      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), nameof(TimeStamps_TIMEZONE), DateTimeFormatType.DayX)]
      public List<DateTime> TimeStamps { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<string> TimeStamps_FORMATTED { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<DateTime> TimeStamps_TIMEZONE{ get; set; }

      [DataMember]
      public List<IDayData> Data { get; set; }
   }
}
