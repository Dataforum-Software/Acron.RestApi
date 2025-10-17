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
   public class GetCompressionForIntervalOfMonthWeekDataRequestResource : IGetCompressionForIntervalOfMonthWeekDataRequestResource<GetMonthWeekDataPVDescription, MonthWeekWhat>
   {
      [DataMember]
      [RequestTimeStampValidator]
      public DateTime FromTime { get; set; }

      [DataMember]
      [RequestTimeStampValidator]
      public DateTime ToTime { get; set; }

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
