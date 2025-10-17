using Acron.RestApi.Interfaces.Data.Response.DayData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.DayData
{
   [DataContract]
   public class CompressionForIntervalOfDayDataFlag : ICompressionForIntervalOfDayDataFlag
   {
      [DataMember]
      public bool DCOMPDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool DCOMPDAT_NOREL { get; set; }

      [DataMember]
      public bool DCOMPDAT_MISSING { get; set; }

      [DataMember]
      public bool DCOMPDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool DCOMPDAT_OVER_LIMIT { get; set; }

   }
}
