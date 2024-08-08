using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData.GetHandVarRawDataCommentsResult;
using Acron.RestApi.Interfaces.Data.Response.HandValStringData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.HandValStringData
{
   [DataContract]
   public class GetHandValStringDataResult : IGetHandValStringDataResult<GetHandValStringDataResultItem>
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
            if (CommentData == null)
               return 0;

            return CommentData.Count;
         }
      }

   [DataMember]
   public int TimeStampsCount { get; set; }

   [DataMember]
   public DateOnly FromDate { get; set; }

   public DateTime FromTime
   {
      get => FromDate.ToDateTime(TimeOnly.MinValue);
      set => FromDate = DateOnly.FromDateTime(value);
   }

   [DataMember]
   public DateOnly ToDate { get; set; }

   public DateTime ToTime
   {
      get => ToDate.ToDateTime(TimeOnly.MinValue);
      set => ToDate = DateOnly.FromDateTime(value);
   }

   [DataMember]
   public List<DateOnly> TimeStampDays { get; set; }

   [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.DayX)]
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
   public List<GetHandValStringDataResultItem> CommentData { get; set; }
}
}
