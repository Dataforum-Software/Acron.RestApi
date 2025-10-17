using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.DataContracts.Data.Request.DayData;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{
   [DataContract]
   public class GetCompressionForIntervalOfProcessDataRequestResource : IGetCompressionForIntervalOfProcessDataRequestResource<GetProcessDataPVDescriptionForTemporaryCompression, DayWhat>
   {
      [DataMember]
      [RequestTimeStampValidator]
      public DateTime FromTime { get; set; }

      [DataMember]
      [RequestTimeStampValidator]
      public DateTime ToTime { get; set; }

      [DataMember]
      [ObjectId]
      public List<GetProcessDataPVDescriptionForTemporaryCompression> PVDescriptions { get; set; }

      [DataMember]
      public Guid ResultID { get; set; }

      [DataMember]
      public bool CancelOperation { get; set; }
   }
}
