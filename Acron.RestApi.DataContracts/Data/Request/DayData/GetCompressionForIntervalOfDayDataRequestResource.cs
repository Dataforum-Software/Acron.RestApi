using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.DayData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.DayData
{
   [DataContract]
   public class GetCompressionForIntervalOfDayDataRequestResource : IGetCompressionForIntervalOfDayDataRequestResource<GetDayDataPVDescription, DayWhat>
   {
      [DataMember]
      [RequestTimeStampValidator]
      public DateTime FromTime { get; set; }

      [DataMember]
      [RequestTimeStampValidator]
      public DateTime ToTime { get; set; }

      [DataMember]
      [ObjectId]
      public List<GetDayDataPVDescription> PVDescriptions { get; set; }

      [DataMember]
      public Guid ResultID { get; set; }

      [DataMember]
      public bool CancelOperation { get; set; }


   }
}
