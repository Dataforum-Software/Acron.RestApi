using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.YearData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.YearData
{
   [DataContract]
   public class YearData : IYearData<YearDataFlag>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public List<YearDataFlag> YDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleListMarker(nameof(YDAT_YVAL_FORMATTED), ValueFormatType.Year)]
      public List<double> YDAT_YVAL { get; set; }

      [DataMember]
      public List<string> YDAT_YVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_YVALTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> YDAT_YVALTM { get; set; }

      [DataMember]
      public List<string> YDAT_YVALTM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(YDAT_YVAL1_FORMATTED), ValueFormatType.Year)]
      public List<float> YDAT_YVAL1 { get; set; }

      [DataMember]
      public List<string> YDAT_YVAL1_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_YVAL1TM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> YDAT_YVAL1TM { get; set; }

      [DataMember]
      public List<string> YDAT_YVAL1TM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(YDAT_YVAL2_FORMATTED), ValueFormatType.Year)]
      public List<float> YDAT_YVAL2 { get; set; }

      [DataMember]
      public List<string> YDAT_YVAL2_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_YVAL2TM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> YDAT_YVAL2TM { get; set; }

      [DataMember]
      public List<string> YDAT_YVAL2TM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(YDAT_YVAL3_FORMATTED), ValueFormatType.Year)]
      public List<float> YDAT_YVAL3 { get; set; }

      [DataMember]
      public List<string> YDAT_YVAL3_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_YVAL3TM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> YDAT_YVAL3TM { get; set; }

      [DataMember]
      public List<string> YDAT_YVAL3TM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public List<double> YDAT_PSUM { get; set; }

      [DataMember]
      public List<string> YDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> YDAT_PMINTM { get; set; }

      [DataMember]
      public List<string> YDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public List<double> YDAT_PMIN { get; set; }

      [DataMember]
      public List<string> YDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_PMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> YDAT_PMAXTM { get; set; }

      [DataMember]
      public List<string> YDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public List<double> YDAT_PMAX { get; set; }

      [DataMember]
      public List<string> YDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      public List<uint> YDAT_PMINLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_PMAXLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_PCOUNT { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_ISUM_FORMATTED), ValueFormatType.Interval)]
      public List<double> YDAT_ISUM { get; set; }

      [DataMember]
      public List<string> YDAT_ISUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_IMINTM_FORMATTED), DateTimeFormatType.Interval1)]
      public List<DateTime> YDAT_IMINTM { get; set; }

      [DataMember]
      public List<string> YDAT_IMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_IMIN_FORMATTED), ValueFormatType.Interval)]
      public List<double> YDAT_IMIN { get; set; }

      [DataMember]
      public List<string> YDAT_IMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_IMAXTM_FORMATTED), DateTimeFormatType.Interval1)]
      public List<DateTime> YDAT_IMAXTM { get; set; }

      [DataMember]
      public List<string> YDAT_IMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_IMAX_FORMATTED), ValueFormatType.Interval)]
      public List<double> YDAT_IMAX { get; set; }

      [DataMember]
      public List<string> YDAT_IMAX_FORMATTED { get; set; }

      [DataMember]
      public List<uint> YDAT_IMINLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_IMAXLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_ICOUNT { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_DSUM_FORMATTED), ValueFormatType.Day)]
      public List<double> YDAT_DSUM { get; set; }

      [DataMember]
      public List<string> YDAT_DSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_DMINTM_FORMATTED), DateTimeFormatType.Day1)]
      public List<DateTime> YDAT_DMINTM { get; set; }

      [DataMember]
      public List<string> YDAT_DMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_DMIN_FORMATTED), ValueFormatType.Day)]
      public List<double> YDAT_DMIN { get; set; }

      [DataMember]
      public List<string> YDAT_DMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_DMAXTM_FORMATTED), DateTimeFormatType.Day1)]
      public List<DateTime> YDAT_DMAXTM { get; set; }

      [DataMember]
      public List<string> YDAT_DMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_DMAX_FORMATTED), ValueFormatType.Day)]
      public List<double> YDAT_DMAX { get; set; }

      [DataMember]
      public List<string> YDAT_DMAX_FORMATTED { get; set; }

      [DataMember]
      public List<uint> YDAT_DMINLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_DMAXLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_DCOUNT { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_MSUM_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<double> YDAT_MSUM { get; set; }

      [DataMember]
      public List<string> YDAT_MSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(YDAT_MSIGMA_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<float> YDAT_MSIGMA { get; set; }

      [DataMember]
      public List<string> YDAT_MSIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(YDAT_MPERC15_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<float> YDAT_MPERC15 { get; set; }

      [DataMember]
      public List<string> YDAT_MPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(YDAT_MPERC85_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<float> YDAT_MPERC85 { get; set; }

      [DataMember]
      public List<string> YDAT_MPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_MMINTM_FORMATTED), DateTimeFormatType.Month)]
      public List<DateTime> YDAT_MMINTM { get; set; }

      [DataMember]
      public List<string> YDAT_MMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_MMIN_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<double> YDAT_MMIN { get; set; }

      [DataMember]
      public List<string> YDAT_MMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(YDAT_MMAXTM_FORMATTED),DateTimeFormatType.Month)]
      public List<DateTime> YDAT_MMAXTM { get; set; }

      [DataMember]
      public List<string> YDAT_MMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(YDAT_MMAX_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<double> YDAT_MMAX { get; set; }

      [DataMember]
      public List<string> YDAT_MMAX_FORMATTED { get; set; }

      [DataMember]
      public List<uint> YDAT_MMINLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_MMAXLIM { get; set; }

      [DataMember]
      public List<uint> YDAT_MCOUNT { get; set; }
   }
}
