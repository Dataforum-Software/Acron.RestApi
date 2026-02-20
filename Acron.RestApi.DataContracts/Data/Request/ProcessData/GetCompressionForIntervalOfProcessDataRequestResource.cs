using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.DataContracts.Data.Request.DayData;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{
   [DataContract]
   public class GetCompressionForIntervalOfProcessDataRequestResource : IGetCompressionForIntervalOfProcessDataRequestResource<GetProcessDataPVDescriptionForTemporaryCompression, DayWhat>
   {
      [DataMember]
      public DateTimeOffset FromTime { get; set; }
      public DateTime FromTime_UTC
      {
         get { return FromTime.UtcDateTime; }
      }

      [DataMember]
      public DateTimeOffset ToTime { get; set; }
      public DateTime ToTime_UTC
      {
         get { return ToTime.UtcDateTime; }
      }

      [DataMember]
      [ObjectId]
      public List<GetProcessDataPVDescriptionForTemporaryCompression> PVDescriptions { get; set; }

      [DataMember]
      public Guid ResultID { get; set; }

      [DataMember]
      public bool CancelOperation { get; set; }
   }
}
