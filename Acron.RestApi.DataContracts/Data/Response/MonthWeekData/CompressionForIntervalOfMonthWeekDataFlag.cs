using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using System.Collections;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.MonthWeekData
{
   [DataContract]
   public class CompressionForIntervalOfMonthWeekDataFlag : ICompressionForIntervalOfMonthWeekDataFlag
   {
      [DataMember]
      public bool YCOMPDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool YCOMPDAT_NOREL { get; set; }

      [DataMember]
      public bool YCOMPDAT_MISSING { get; set; }

      [DataMember]
      public bool YCOMPDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool YCOMPDAT_OVER_LIMIT { get; set; }
   }
}