using Acron.RestApi.Interfaces;
using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.IntervalData
{
   [DataContract]
   public class CompressionForIntervalOfCustomIntervalDataFlag_Interval : ICompressionForIntervalOfCustomIntervalDataFlag_Interval
   {
      [DataMember]
      public bool ICOMPDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool ICOMPDAT_OVER { get; set; }

      [DataMember]
      public bool ICOMPDAT_LESS { get; set; }

      [DataMember] public bool ICOMPDAT_GREATER { get; set; }

      [DataMember] public bool ICOMPDAT_NOREL { get; set; }

      [DataMember] public bool ICOMPDAT_MISSING { get; set; }

      [DataMember] public bool ICOMPDAT_UNDER_LIMIT { get; set; }

      [DataMember] public bool ICOMPDAT_OVER_LIMIT { get; set; }

      [DataMember]
      public bool ICOMPDAT_MINIMUM { get; set; }

      [DataMember]
      public bool ICOMPDAT_MAXIMUM { get; set; }
   }
}
