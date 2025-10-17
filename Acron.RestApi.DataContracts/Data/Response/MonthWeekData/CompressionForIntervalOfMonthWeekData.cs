using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.MonthWeekData
{
   [DataContract]
   public class CompressionForIntervalOfMonthWeekData : ICompressionForIntervalOfMonthWeekData<CompressionForIntervalOfMonthWeekDataFlag>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public CompressionForIntervalOfMonthWeekDataFlag YCOMPDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleMarker(nameof(YCOMPDAT_YVAL_FORMATTED), ValueFormatType.WeekOrMonth)]
      public double YCOMPDAT_YVAL { get; set; }

      [DataMember]
      public string YCOMPDAT_YVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_YVALTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_YVALTM { get; set; }

      [DataMember]
      public string YCOMPDAT_YVALTM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(YCOMPDAT_YVAL1_FORMATTED), ValueFormatType.WeekOrMonth)]
      public float YCOMPDAT_YVAL1 { get; set; }

      [DataMember]
      public string YCOMPDAT_YVAL1_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_YVAL1TM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_YVAL1TM { get; set; }

      [DataMember]
      public string YCOMPDAT_YVAL1TM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(YCOMPDAT_YVAL2_FORMATTED), ValueFormatType.WeekOrMonth)]
      public float YCOMPDAT_YVAL2 { get; set; }

      [DataMember]
      public string YCOMPDAT_YVAL2_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_YVAL2TM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_YVAL2TM { get; set; }

      [DataMember]
      public string YCOMPDAT_YVAL2TM_FORMATTED { get; set; }

      [DataMember]

      [FormatFloat(nameof(YCOMPDAT_YVAL3_FORMATTED), ValueFormatType.WeekOrMonth)]
      public float YCOMPDAT_YVAL3 { get; set; }

      [DataMember]
      public string YCOMPDAT_YVAL3_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_YVAL3TM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_YVAL3TM { get; set; }

      [DataMember]
      public string YCOMPDAT_YVAL3TM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public double YCOMPDAT_PSUM { get; set; }

      [DataMember]
      public string YCOMPDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_PMINTM { get; set; }

      [DataMember]
      public string YCOMPDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public double YCOMPDAT_PMIN { get; set; }

      [DataMember]
      public string YCOMPDAT_PMIN_FORMATTED { get; set; }
      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_PMAXTM { get; set; }

      [DataMember]
      public string YCOMPDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public double YCOMPDAT_PMAX { get; set; }

      [DataMember]
      public string YCOMPDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_PMINLIM_FORMATTED))]
      public uint YCOMPDAT_PMINLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_PMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_PMAXLIM_FORMATTED))]
      public uint YCOMPDAT_PMAXLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_PCOUNT_FORMATTED))]
      public uint YCOMPDAT_PCOUNT { get; set; }

      [DataMember]
      public string YCOMPDAT_PCOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_ISUM_FORMATTED), ValueFormatType.Interval)]
      public double YCOMPDAT_ISUM { get; set; }
      [DataMember]
      public string YCOMPDAT_ISUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_IMINTM_FORMATTED), DateTimeFormatType.Interval1)]
      public DateTime YCOMPDAT_IMINTM { get; set; }
      [DataMember]
      public string YCOMPDAT_IMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_IMIN_FORMATTED), ValueFormatType.Interval)]
      public double YCOMPDAT_IMIN { get; set; }
      [DataMember]
      public string YCOMPDAT_IMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_IMAXTM_FORMATTED), DateTimeFormatType.Interval1)]
      public DateTime YCOMPDAT_IMAXTM { get; set; }
      [DataMember]
      public string YCOMPDAT_IMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_IMAX_FORMATTED), ValueFormatType.Interval)]
      public double YCOMPDAT_IMAX { get; set; }
      [DataMember]
      public string YCOMPDAT_IMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_IMINLIM_FORMATTED))]
      public uint YCOMPDAT_IMINLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_IMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_IMAXLIM_FORMATTED))]
      public uint YCOMPDAT_IMAXLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_IMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_ICOUNT_FORMATTED))]
      public uint YCOMPDAT_ICOUNT { get; set; }

      [DataMember]
      public string YCOMPDAT_ICOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_DSUM_FORMATTED), ValueFormatType.WeekOrMonth)]
      public double YCOMPDAT_DSUM { get; set; }
      [DataMember]
      public string YCOMPDAT_DSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_DMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_DMINTM { get; set; }
      [DataMember]
      public string YCOMPDAT_DMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_DMIN_FORMATTED), ValueFormatType.WeekOrMonth)]
      public double YCOMPDAT_DMIN { get; set; }
      [DataMember]
      public string YCOMPDAT_DMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_DMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_DMAXTM { get; set; }
      [DataMember]
      public string YCOMPDAT_DMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_DMAX_FORMATTED), ValueFormatType.WeekOrMonth)]
      public double YCOMPDAT_DMAX { get; set; }
      [DataMember]
      public string YCOMPDAT_DMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_DMINLIM_FORMATTED))]
      public uint YCOMPDAT_DMINLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_DMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_DMAXLIM_FORMATTED))]
      public uint YCOMPDAT_DMAXLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_DMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_DCOUNT_FORMATTED))]
      public uint YCOMPDAT_DCOUNT { get; set; }

      [DataMember]
      public string YCOMPDAT_DCOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_MSUM_FORMATTED), ValueFormatType.WeekOrMonth)]
      public double YCOMPDAT_MSUM { get; set; }
      [DataMember]
      public string YCOMPDAT_MSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(YCOMPDAT_MSIGMA_FORMATTED), ValueFormatType.WeekOrMonth)]
      public float YCOMPDAT_MSIGMA { get; set; }
      [DataMember]
      public string YCOMPDAT_MSIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(YCOMPDAT_MPERC15_FORMATTED), ValueFormatType.WeekOrMonth)]
      public float YCOMPDAT_MPERC15 { get; set; }
      [DataMember]
      public string YCOMPDAT_MPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(YCOMPDAT_MPERC85_FORMATTED), ValueFormatType.WeekOrMonth)]
      public float YCOMPDAT_MPERC85 { get; set; }
      [DataMember]
      public string YCOMPDAT_MPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_MMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_MMINTM { get; set; }
      [DataMember]
      public string YCOMPDAT_MMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_MMIN_FORMATTED), ValueFormatType.WeekOrMonth)]
      public double YCOMPDAT_MMIN { get; set; }
      [DataMember]
      public string YCOMPDAT_MMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(YCOMPDAT_MMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime YCOMPDAT_MMAXTM { get; set; }
      [DataMember]
      public string YCOMPDAT_MMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(YCOMPDAT_MMAX_FORMATTED), ValueFormatType.WeekOrMonth)]
      public double YCOMPDAT_MMAX { get; set; }
      [DataMember]
      public string YCOMPDAT_MMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_MMINLIM_FORMATTED))]
      public uint YCOMPDAT_MMINLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_MMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_MMAXLIM_FORMATTED))]
      public uint YCOMPDAT_MMAXLIM { get; set; }

      [DataMember]
      public string YCOMPDAT_MMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(YCOMPDAT_MCOUNT_FORMATTED))]
      public uint YCOMPDAT_MCOUNT { get; set; }

      [DataMember]
      public string YCOMPDAT_MCOUNT_FORMATTED { get; set; }
   }
}