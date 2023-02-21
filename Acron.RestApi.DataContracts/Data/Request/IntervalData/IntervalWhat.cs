using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.IntervalData
{
   [DataContract]
   public class IntervalWhat : IIntervalWhat
   {
      [DataMember]
      public bool IDAT_FLAG {get; set;}

      [DataMember]
      public bool IDAT_IVAL { get; set; }

      [DataMember]
      public bool IDAT_PSUM { get; set; }

      [DataMember]
      public bool IDAT_PSIGMA { get; set; }

      [DataMember]
      public bool IDAT_PPERC15 { get; set; }

      [DataMember]
      public bool IDAT_PPERC85 { get; set; }

      [DataMember]
      public bool IDAT_PMIN { get; set; }

      [DataMember]
      public bool IDAT_PMINTM { get; set; }

      [DataMember]
      public bool IDAT_PMAX { get; set; }

      [DataMember]
      public bool IDAT_PMAXTM { get; set; }

      [DataMember]
      public bool IDAT_PMINLIM { get; set; }

      [DataMember]
      public bool IDAT_PMAXLIM { get; set; }

      [DataMember]
      public bool IDAT_PCOUNT { get; set; }
   }
}
