using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.StringCompData;
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
   public class GetCustomIntervalStringDataRequestResource : IGetCustomIntervalStringDataRequestResource
   {
      [DataMember]
      [ObjectId]
      public List<uint> PVIDs { get; set; }

      [DataMember]
      [Required]
      public DateTimeOffset FromTime { get; set; }
      public DateTime FromTime_UTC { get { return FromTime.UtcDateTime; } }

      [DataMember]
      [Required]
      public DateTimeOffset ToTime { get; set; }
      public DateTime ToTime_UTC { get { return ToTime.UtcDateTime; } }

      [DataMember]
      [Range(0, 86400)]
      public uint Interval { get; set; }
   }
}
