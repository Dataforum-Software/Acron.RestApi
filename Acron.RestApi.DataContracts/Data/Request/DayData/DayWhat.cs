using Acron.RestApi.Interfaces.Data.Request.DayData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.DayData
{
   [DataContract]
   public class DayWhat : IDayWhat
   {
      [DataMember]      
      public bool DDAT_FLAG { get; set; }

      [DataMember]
      public bool DDAT_DVAL { get; set; }

      [DataMember]
      public bool DDAT_DVALAVG { get; set; }

      [DataMember]
      public bool DDAT_DVALTM { get; set; }

      [DataMember]
      public bool DDAT_PSUM { get; set; }

      [DataMember]
      public bool DDAT_PMIN { get; set; }

      [DataMember]
      public bool DDAT_PMINTM { get; set; }

      [DataMember]
      public bool DDAT_PMAX { get; set; }

      [DataMember]
      public bool DDAT_PMAXTM { get; set; }

      [DataMember]
      public bool DDAT_PMINLIM { get; set; }

      [DataMember]
      public bool DDAT_PMAXLIM { get; set; }

      [DataMember]
      public bool DDAT_PCOUNT { get; set; }

      [DataMember]
      public bool DDAT_ISUM { get; set; }

      [DataMember]
      public bool DDAT_ISIGMA { get; set; }

      [DataMember]
      public bool DDAT_IPERC15 { get; set; }

      [DataMember]
      public bool DDAT_IPERC85 { get; set; }

      [DataMember]
      public bool DDAT_IMIN { get; set; }

      [DataMember]
      public bool DDAT_IMINTM { get; set; }

      [DataMember]
      public bool DDAT_IMAX { get; set; }

      [DataMember]
      public bool DDAT_IMAXTM { get; set; }

      [DataMember]
      public bool DDAT_IMINLIM { get; set; }

      [DataMember]
      public bool DDAT_IMAXLIM { get; set; }

      [DataMember]
      public bool DDAT_ICOUNT { get; set; }
   }
}
