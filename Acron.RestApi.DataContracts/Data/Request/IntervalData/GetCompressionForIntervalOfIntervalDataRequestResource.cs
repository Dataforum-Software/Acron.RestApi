using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.IntervalData
{
   [DataContract]
   public class GetCompressionForIntervalOfIntervalDataRequestResource : IGetCompressionForIntervalOfIntervalDataRequestResource<GetIntervalDataPVDescription, IntervalWhat>
   {
      [DataMember]
      [Required]
      public DateTimeOffset FromTime { get; set; }
      [Required]
      public DateTime FromTime_UTC
      {
         get
         {
            return FromTime.UtcDateTime;
         }
      }

      [DataMember]
      [Required]
      public DateTimeOffset ToTime { get; set; }
      [Required]
      public DateTime ToTime_UTC
      {
         get
         {
            return ToTime.UtcDateTime;
         }
      }

      [DataMember]
      [ObjectId]
      public List<GetIntervalDataPVDescription> PVDescriptions { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public IntervalTypes IntervalType { get; set; }

      [DataMember]
      public Guid ResultID { get; set; }

      [DataMember]
      public bool CancelOperation { get; set; }
   }
}
