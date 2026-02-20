using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.EventData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.EventData
{
   [DataContract]
   public class EventSelectionParameters : IEventSelectionParameters
   {
      [DataMember]
      public DateTimeOffset FromTime { get; set; }
      [Required]
      [RequestTimeStampValidator]
      public DateTime FromTime_UTC
      {
         get
         {
            return FromTime.UtcDateTime;
         }
      }

      [DataMember]
      public DateTimeOffset ToTime { get; set; }
      [Required]
      [RequestTimeStampValidator]
      public DateTime ToTime_UTC
      {
         get
         {
            return ToTime.UtcDateTime;
         }
      }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public string BatchId { get; set; }

      [DataMember]
      public string Formula { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventFilters Filter { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ReadOptions ReadOptions { get; set; }
   }
}
