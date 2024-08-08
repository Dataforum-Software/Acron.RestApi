using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.YearData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.YearData
{
   [DataContract]
   public class YearDataResult : IYearDataResult<YearData, YearDataFlag>
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
      public List<int> TimeStampYears { get; set; }

      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.Year)]
      public List<DateTime> TimeStamps
      {
         get
         {
            if (TimeStampYears.Any())
            {
               return TimeStampYears.Select(x => new DateTime(x, 1, 1)).ToList();
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
               TimeStampYears = value.Select(x => (int)x.Year).ToList();
            }
         }
      }

      [DataMember]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [DataMember]
      public List<YearData> Data { get; set; }

   }

   [DataContract]
   public class YearDataResult__L9_4__10_0 : IYearDataResult__L9_4__10_0<YearData, YearDataFlag>
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
      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.Year)]
      public List<DateTime> TimeStamps { get; set; }

      [DataMember]
      public List<string> TimeStamps_FORMATTED { get; set; }

      [DataMember]
      public List<YearData> Data { get; set; }

   }
}
