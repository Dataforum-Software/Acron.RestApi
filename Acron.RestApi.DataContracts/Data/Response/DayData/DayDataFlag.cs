using Acron.RestApi.Interfaces.Data.Response.DayData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.DayData
{
   [DataContract]
   public class DayDataFlag : IDayDataFlag
   {
      [DataMember]
      public bool DDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool DDAT_OVER { get; set; }

      [DataMember]
      public bool DDAT_LESS { get; set; }

      [DataMember]
      public bool DDAT_GREATER { get; set; }

      [DataMember]
      public bool DDAT_NOREL { get; set; }

      [DataMember]
      public bool DDAT_MISSING { get; set; }

      [DataMember]
      public bool DDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool DDAT_OVER_LIMIT { get; set; }

      [DataMember]
      public bool DDAT_MINIMUM { get; set; }

      [DataMember]
      public bool DDAT_MAXIMUM { get; set; }
   }
}
