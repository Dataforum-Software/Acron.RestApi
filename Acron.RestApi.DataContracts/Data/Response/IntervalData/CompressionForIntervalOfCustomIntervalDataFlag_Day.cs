using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.IntervalData
{
   [DataContract]
   public class CompressionForIntervalOfCustomIntervalDataFlag_Day : ICompressionForIntervalOfCustomIntervalDataFlag_Day
   {
      [DataMember]
      public bool DCOMPDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool DCOMPDAT_OVER { get; set; }

      [DataMember]
      public bool DCOMPDAT_LESS { get; set; }

      [DataMember]
      public bool DCOMPDAT_GREATER { get; set; }

      [DataMember]
      public bool DCOMPDAT_NOREL { get; set; }

      [DataMember]
      public bool DCOMPDAT_MISSING { get; set; }

      [DataMember]
      public bool DCOMPDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool DCOMPDAT_OVER_LIMIT { get; set; }

      [DataMember]
      public bool DCOMPDAT_MINIMUM { get; set; }

      [DataMember]
      public bool DCOMPDAT_MAXIMUM { get; set; }
   }
}
