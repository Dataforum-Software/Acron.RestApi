using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.MonthWeekData
{
   [DataContract]
   public class MonthWeekDataFlag : IMonthWeekDataFlag
   {
      [DataMember]
      public bool MDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool MDAT_NOREL { get; set; }

      [DataMember]
      public bool MDAT_MISSING { get; set; }

      [DataMember]
      public bool MDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool MDAT_OVER_LIMIT { get; set; }

      [DataMember]
      public bool MDAT_MINIMUM { get; set; }

      [DataMember]
      public bool MDAT_MAXIMUM { get; set; }
   }
}
