using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.MonthWeekData
{
   [DataContract]
   public class MonthWeekWhat : IMonthWeekWhat
   {
      [DataMember]
      public bool MDAT_FLAG {get; set;}

      [DataMember]
      public bool MDAT_MVAL { get; set; }

      [DataMember]
      public bool MDAT_MVALTM { get; set; }

      [DataMember]
      public bool MDAT_MVAL1 { get; set; }

      [DataMember]
      public bool MDAT_MVAL1TM { get; set; }

      [DataMember]
      public bool MDAT_MVAL2 { get; set; }

      [DataMember]
      public bool MDAT_MVAL2TM { get; set; }

      [DataMember]
      public bool MDAT_MVAL3 { get; set; }

      [DataMember]
      public bool MDAT_MVAL3TM { get; set; }

      [DataMember]
      public bool MDAT_PSUM { get; set; }

      [DataMember]
      public bool MDAT_PMINTM { get; set; }

      [DataMember]
      public bool MDAT_PMIN { get; set; }

      [DataMember]
      public bool MDAT_PMAXTM { get; set; }

      [DataMember]
      public bool MDAT_PMAX { get; set; }

      [DataMember]
      public bool MDAT_PMINLIM { get; set; }

      [DataMember]
      public bool MDAT_PMAXLIM { get; set; }

      [DataMember]
      public bool MDAT_PCOUNT { get; set; }

      [DataMember]
      public bool MDAT_ISUM { get; set; }

      [DataMember]
      public bool MDAT_IMINTM { get; set; }

      [DataMember]
      public bool MDAT_IMIN { get; set; }

      [DataMember]
      public bool MDAT_IMAXTM { get; set; }

      [DataMember]
      public bool MDAT_IMAX { get; set; }

      [DataMember]
      public bool MDAT_IMINLIM { get; set; }

      [DataMember]
      public bool MDAT_IMAXLIM { get; set; }

      [DataMember]
      public bool MDAT_ICOUNT { get; set; }

      [DataMember]
      public bool MDAT_DSUM { get; set; }

      [DataMember]
      public bool MDAT_DSIGMA { get; set; }

      [DataMember]
      public bool MDAT_DPERC15 { get; set; }

      [DataMember]
      public bool MDAT_DPERC85 { get; set; }

      [DataMember]
      public bool MDAT_DMINTM { get; set; }

      [DataMember]
      public bool MDAT_DMIN { get; set; }

      [DataMember]
      public bool MDAT_DMAXTM { get; set; }

      [DataMember]
      public bool MDAT_DMAX { get; set; }

      [DataMember]
      public bool MDAT_DMINLIM { get; set; }

      [DataMember]
      public bool MDAT_DMAXLIM { get; set; }

      [DataMember]
      public bool MDAT_DCOUNT { get; set; }
   }
}
