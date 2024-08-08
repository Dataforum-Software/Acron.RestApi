using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Acron.RestApi.Interfaces.Data.Request.HandValStringData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValStringData
{
   [DataContract]
   public class HandValStringDataRequestResource : IHandValStringDataRequestResource
   {
      [DataMember]
      [Required]
      [JsonConverter(typeof(StringEnumConverter))]
      public ValKinds Kind { get; set; }

      [DataMember]
      [Required]
      [RequestTimeStampValidator]
      public DateOnly FromDate { get; set; }

      public DateTime FromTime
      {
         get => FromDate.ToDateTime(TimeOnly.MinValue);
         set => FromDate = DateOnly.FromDateTime(value);
      }

      [DataMember]
      [Required]
      [RequestTimeStampValidator]
      public DateOnly ToDate { get; set; }

      public DateTime ToTime
      {
         get => ToDate.ToDateTime(TimeOnly.MinValue);
         set => ToDate = DateOnly.FromDateTime(value);
      }

      [DataMember]
      public List<uint> PVIds { get; set; }
   }
}
