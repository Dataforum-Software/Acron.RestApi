using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.MonthWeekData
{
   [DataContract]
   public class MonthWeekData : IMonthWeekData<MonthWeekDataFlag>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }



      [DataMember]
      public List<MonthWeekDataFlag> MDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleListMarker(nameof(MDAT_MVAL_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<double> MDAT_MVAL { get; set; }

      [DataMember]
      public List<string> MDAT_MVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_MVALTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> MDAT_MVALTM { get; set; }

      [DataMember]
      public List<string> MDAT_MVALTM_FORMATTED { get; set; }


      [DataMember]
      [FormatFloatList(nameof(MDAT_MVAL1_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<float> MDAT_MVAL1 { get; set; }

      [DataMember]
      public List<string> MDAT_MVAL1_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_MVAL1TM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> MDAT_MVAL1TM { get; set; }

      [DataMember]
      public List<string> MDAT_MVAL1TM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(MDAT_MVAL2_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<float> MDAT_MVAL2 { get; set; }

      [DataMember]
      public List<string> MDAT_MVAL2_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_MVAL2TM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> MDAT_MVAL2TM { get; set; }

      [DataMember]
      public List<string> MDAT_MVAL2TM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(MDAT_MVAL3_FORMATTED), ValueFormatType.WeekOrMonth)]
      public List<float> MDAT_MVAL3 { get; set; }

      [DataMember]
      public List<string> MDAT_MVAL3_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_MVAL3TM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> MDAT_MVAL3TM { get; set; }

      [DataMember]
      public List<string> MDAT_MVAL3TM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public List<double> MDAT_PSUM { get; set; }

      [DataMember]
      public List<string> MDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> MDAT_PMINTM { get; set; }

      [DataMember]
      public List<string> MDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public List<double> MDAT_PMIN { get; set; }

      [DataMember]
      public List<string> MDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_PMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> MDAT_PMAXTM { get; set; }

      [DataMember]
      public List<string> MDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public List<double> MDAT_PMAX { get; set; }

      [DataMember]
      public List<string> MDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_PMINLIM_FORMATTED))]
      public List<uint> MDAT_PMINLIM { get; set; }

      [DataMember]
      public List<string> MDAT_PMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_PMAXLIM_FORMATTED))]
      public List<uint> MDAT_PMAXLIM { get; set; }

      [DataMember]
      public List<string> MDAT_PMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_PCOUNT_FORMATTED))]
      public List<uint> MDAT_PCOUNT { get; set; }

      [DataMember]
      public List<string> MDAT_PCOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_ISUM_FORMATTED), ValueFormatType.Interval)]
      public List<double> MDAT_ISUM { get; set; }

      [DataMember]
      public List<string> MDAT_ISUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_IMINTM_FORMATTED), DateTimeFormatType.Interval1)]
      public List<DateTime> MDAT_IMINTM { get; set; }

      [DataMember]
      public List<string> MDAT_IMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_IMIN_FORMATTED), ValueFormatType.Interval)]
      public List<double> MDAT_IMIN { get; set; }

      [DataMember]
      public List<string> MDAT_IMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_IMAXTM_FORMATTED), DateTimeFormatType.Interval1)]
      public List<DateTime> MDAT_IMAXTM { get; set; }

      [DataMember]
      public List<string> MDAT_IMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_IMAX_FORMATTED), ValueFormatType.Interval)]
      public List<double> MDAT_IMAX { get; set; }

      [DataMember]
      public List<string> MDAT_IMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_IMINLIM_FORMATTED))]
      public List<uint> MDAT_IMINLIM { get; set; }

      [DataMember]
      public List<string> MDAT_IMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_IMAXLIM_FORMATTED))]
      public List<uint> MDAT_IMAXLIM { get; set; }

      [DataMember]
      public List<string> MDAT_IMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_ICOUNT_FORMATTED))]
      public List<uint> MDAT_ICOUNT { get; set; }

      [DataMember]
      public List<string> MDAT_ICOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_DSUM_FORMATTED), ValueFormatType.Day)]
      public List<double> MDAT_DSUM { get; set; }

      [DataMember]
      public List<string> MDAT_DSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(MDAT_DSIGMA_FORMATTED), ValueFormatType.Day)]
      public List<float> MDAT_DSIGMA { get; set; }

      [DataMember]
      public List<string> MDAT_DSIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(MDAT_DPERC15_FORMATTED), ValueFormatType.Day)]
      public List<float> MDAT_DPERC15 { get; set; }

      [DataMember]
      public List<string> MDAT_DPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(MDAT_DPERC85_FORMATTED), ValueFormatType.Day)]
      public List<float> MDAT_DPERC85 { get; set; }

      [DataMember]
      public List<string> MDAT_DPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_DMINTM_FORMATTED), DateTimeFormatType.Day1)]
      public List<DateTime> MDAT_DMINTM { get; set; }

      [DataMember]
      public List<string> MDAT_DMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_DMIN_FORMATTED), ValueFormatType.Day)]
      public List<double> MDAT_DMIN { get; set; }

      [DataMember]
      public List<string> MDAT_DMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(MDAT_DMAXTM_FORMATTED), DateTimeFormatType.Day1)]
      public List<DateTime> MDAT_DMAXTM { get; set; }

      [DataMember]
      public List<string> MDAT_DMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(MDAT_DMAX_FORMATTED), ValueFormatType.Day)]
      public List<double> MDAT_DMAX { get; set; }

      [DataMember]
      public List<string> MDAT_DMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_DMINLIM_FORMATTED))]
      public List<uint> MDAT_DMINLIM { get; set; }

      [DataMember]
      public List<string> MDAT_DMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_DMAXLIM_FORMATTED))]
      public List<uint> MDAT_DMAXLIM { get; set; }

      [DataMember]
      public List<string> MDAT_DMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(MDAT_DCOUNT_FORMATTED))]
      public List<uint> MDAT_DCOUNT { get; set; }

      [DataMember]
      public List<string> MDAT_DCOUNT_FORMATTED { get; set; }

   }
}
