using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.IntervalData
{
   public class GetCompressionForIntervalOfCustomIntervalDataRequestResource : IGetCompressionForIntervalOfCustomIntervalDataRequestResource<GetIntervalDataPVDescription, IntervalWhat>
   {
      [DataMember]
      public DateTime FromTime { get; set; }

      [DataMember]
      public DateTime ToTime { get; set; }

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
