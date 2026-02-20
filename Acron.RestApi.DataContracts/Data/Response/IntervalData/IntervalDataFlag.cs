using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.IntervalData
{
   [DataContract]
   public class IntervalDataFlag : IIntervalDataFlag
   {
      [DataMember]
      public bool IDAT_REPLACEMENT { get; set; }

      [DataMember]
      public bool IDAT_OVER { get; set; }

      [DataMember]
      public bool IDAT_LESS { get; set; }

      [DataMember]
      public bool IDAT_GREATER { get; set; }

      [DataMember]
      public bool IDAT_MISSING { get; set; }

      [DataMember]
      public bool IDAT_UNDER_LIMIT { get; set; }

      [DataMember]
      public bool IDAT_OVER_LIMIT { get; set; }

      [DataMember]
      public bool IDAT_MINIMUM { get; set; }

      [DataMember]
      public bool IDAT_MAXIMUM { get; set; }
   }
}
