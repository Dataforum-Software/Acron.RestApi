using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.IntervalData;
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
   public class GetCompressionForIntervalOfCustomIntervalDataRequestResource : IGetCompressionForIntervalOfCustomIntervalDataRequestResource<GetIntervalDataPVDescription, IntervalWhat>
   {
      [DataMember]
      public DateTimeOffset FromTime { get; set; }

      public DateTime FromTime_UTC
      {
         get
         {
            return FromTime.UtcDateTime;
         }
      }

      [DataMember]
      public DateTimeOffset ToTime { get; set; }

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
      public CustomIntervalTypes CustomIntervalType { get; set; }

      [DataMember]
      public uint Interval { get; set; }

      [DataMember]
      public Guid ResultID { get; set; }

      [DataMember]
      public bool CancelOperation { get; set; }
   }
}
