using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.MonthWeekData
{
   [DataContract]
   public class MonthWeekDataResult : IMonthWeekDataResult<MonthWeekData, MonthWeekDataFlag>
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

      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.WeekOrMonth)]
      public List<DateTime> TimeStamps
      {
         get
         {
            if (TimeStampDays.Any())
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
      public List<MonthWeekData> Data { get; set; }

   }

   [DataContract]
   public class MonthWeekDataResult__L9_4__10_0 : IMonthWeekDataResult__L9_4__10_0<MonthWeekData, MonthWeekDataFlag>
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
      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.WeekOrMonth)]
      public List<DateTime> TimeStamps { get; set; }

      [DataMember]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [DataMember]
      public List<MonthWeekData> Data { get; set; }

   }
}
