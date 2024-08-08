using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.DayData;


namespace Acron.RestApi.DataContracts.Data.Response.DayData
{
   [DataContract]
   public class DayDataResult : IDayDataResult<DayData,DayDataFlag>
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
      public List<DateOnly> TimeStampDays { get; set; }

      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.DayX)]
      public List<DateTime> TimeStamps
      {
         get
         {
            if(TimeStampDays.Any())
            {
               return TimeStampDays.Select(x => x.ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc)).ToList();
            }
            else
            {
               return new List<DateTime>();
            }
         }

         set
         {
            if (value != null)
            {
               TimeStampDays = value.Select(x => DateOnly.FromDateTime(x)).ToList();
            }
         }
      }

      [DataMember]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [DataMember]
      public List<DayData> Data { get; set; }
   }

   [DataContract]
   public class DayDataResult__L9_4__10_0 : IDayDataResult__L9_4__10_0<DayData, DayDataFlag>
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
      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.DayX)]
      public List<DateTime> TimeStamps { get; set; }

      [DataMember]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [DataMember]
      public List<DayData> Data { get; set; }
   }
}
