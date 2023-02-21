using Acron.RestApi.Interfaces.Data.Request.YearData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.YearData
{
   [DataContract]
   public class YearWhat : IYearWhat
   {
      [DataMember]
      public bool YDAT_FLAG { get; set; }

      [DataMember]
      public bool YDAT_YVAL { get; set; }

      [DataMember]
      public bool YDAT_YVALTM { get; set; }

      [DataMember]
      public bool YDAT_YVAL1 { get; set; }

      [DataMember]
      public bool YDAT_YVAL1TM { get; set; }

      [DataMember]
      public bool YDAT_YVAL2 { get; set; }

      [DataMember]
      public bool YDAT_YVAL2TM { get; set; }

      [DataMember]
      public bool YDAT_YVAL3 { get; set; }

      [DataMember]
      public bool YDAT_YVAL3TM { get; set; }

      [DataMember]
      public bool YDAT_PSUM { get; set; }

      [DataMember]
      public bool YDAT_PMINTM { get; set; }

      [DataMember]
      public bool YDAT_PMIN { get; set; }

      [DataMember]
      public bool YDAT_PMAXTM { get; set; }

      [DataMember]
      public bool YDAT_PMAX { get; set; }

      [DataMember]
      public bool YDAT_PMINLIM { get; set; }

      [DataMember]
      public bool YDAT_PMAXLIM { get; set; }

      [DataMember]
      public bool YDAT_PCOUNT { get; set; }

      [DataMember]
      public bool YDAT_ISUM { get; set; }

      [DataMember]
      public bool YDAT_IMINTM { get; set; }

      [DataMember]
      public bool YDAT_IMIN { get; set; }

      [DataMember]
      public bool YDAT_IMAXTM { get; set; }

      [DataMember]
      public bool YDAT_IMAX { get; set; }

      [DataMember]
      public bool YDAT_IMINLIM { get; set; }

      [DataMember]
      public bool YDAT_IMAXLIM { get; set; }

      [DataMember]
      public bool YDAT_ICOUNT { get; set; }

      [DataMember]
      public bool YDAT_DSUM { get; set; }

      [DataMember]
      public bool YDAT_DMINTM { get; set; }

      [DataMember]
      public bool YDAT_DMIN { get; set; }

      [DataMember]
      public bool YDAT_DMAXTM { get; set; }

      [DataMember]
      public bool YDAT_DMAX { get; set; }

      [DataMember]
      public bool YDAT_DMINLIM { get; set; }

      [DataMember]
      public bool YDAT_DMAXLIM { get; set; }

      [DataMember]
      public bool YDAT_DCOUNT { get; set; }

      [DataMember]
      public bool YDAT_MSUM { get; set; }

      [DataMember]
      public bool YDAT_MSIGMA { get; set; }

      [DataMember]
      public bool YDAT_MPERC15 { get; set; }

      [DataMember]
      public bool YDAT_MPERC85 { get; set; }

      [DataMember]
      public bool YDAT_MMINTM { get; set; }

      [DataMember]
      public bool YDAT_MMIN { get; set; }

      [DataMember]
      public bool YDAT_MMAXTM { get; set; }

      [DataMember]
      public bool YDAT_MMAX { get; set; }

      [DataMember]
      public bool YDAT_MMINLIM { get; set; }

      [DataMember]
      public bool YDAT_MMAXLIM { get; set; }

      [DataMember]
      public bool YDAT_MCOUNT { get; set; }
   }
}
