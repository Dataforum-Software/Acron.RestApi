using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.MonthWeekData
{
   [DataContract]
   public class GetCompressionForIntervalOfMonthWeekDataRequestResource : IGetCompressionForIntervalOfMonthWeekDataRequestResource<GetMonthWeekDataPVDescription, MonthWeekWhat>
   {
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
      [ObjectId]
      public List<GetMonthWeekDataPVDescription> PVDescriptions { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public MonthWeekTypes MonthWeekType { get; set; }

      [DataMember]
      public Guid ResultID { get; set; }

      [DataMember]
      public bool CancelOperation { get; set; }
   }
}
