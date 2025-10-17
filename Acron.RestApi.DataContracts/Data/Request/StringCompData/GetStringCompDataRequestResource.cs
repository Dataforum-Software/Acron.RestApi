using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.StringCompData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.StringCompData
{
   [DataContract]
   public class GetStringCompDataRequestResource : IGetStringCompDataRequestResource
   {
      [DataMember]
      [Required]
      [JsonConverter(typeof(StringEnumConverter))]
      public GetStringCompDataCompTypes CompType { get; set; } = GetStringCompDataCompTypes.None;

      [DataMember]
      [Required]
      public DateTimeOffset FromTime { get; set; }
      public DateTime FromTime_UTC { get { return FromTime.UtcDateTime; } }

      [DataMember]
      [Required]
      public DateTimeOffset ToTime { get; set; }
      public DateTime ToTime_UTC { get { return ToTime.UtcDateTime; } }

      [DataMember]
      [Required]
      [ObjectId]
      public List<uint> PVIDs { get; set; }
   }
}
