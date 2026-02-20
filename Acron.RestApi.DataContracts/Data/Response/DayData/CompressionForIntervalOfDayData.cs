using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.DayData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.DayData
{
   [DataContract]
   public class CompressionForIntervalOfDayData : ICompressionForIntervalOfDayData<CompressionForIntervalOfDayDataFlag>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public CompressionForIntervalOfDayDataFlag DCOMPDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleMarker(nameof(DCOMPDAT_MVAL_FORMATTED), ValueFormatType.Day)]
      public double DCOMPDAT_MVAL { get; set; }

      [DataMember]
      public string DCOMPDAT_MVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_MVALTM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime DCOMPDAT_MVALTM { get; set; }

      [DataMember]
      public string DCOMPDAT_MVALTM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_MVAL1_FORMATTED), ValueFormatType.Default)]
      public float DCOMPDAT_MVAL1 { get; set; }

      [DataMember]
      public string DCOMPDAT_MVAL1_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_MVAL1TM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime DCOMPDAT_MVAL1TM { get; set; }

      [DataMember]
      public string DCOMPDAT_MVAL1TM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_MVAL2_FORMATTED), ValueFormatType.Day)]
      public float DCOMPDAT_MVAL2 { get; set; }

      [DataMember]
      public string DCOMPDAT_MVAL2_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_MVAL2TM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime DCOMPDAT_MVAL2TM { get; set; }

      [DataMember]
      public string DCOMPDAT_MVAL2TM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_MVAL3_FORMATTED), ValueFormatType.Day)]
      public float DCOMPDAT_MVAL3 { get; set; }

      [DataMember]
      public string DCOMPDAT_MVAL3_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_MVAL3TM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime DCOMPDAT_MVAL3TM { get; set; }

      [DataMember]
      public string DCOMPDAT_MVAL3TM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public double DCOMPDAT_PSUM { get; set; }

      [DataMember]
      public string DCOMPDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public double DCOMPDAT_PMIN { get; set; }

      [DataMember]
      public string DCOMPDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime DCOMPDAT_PMINTM { get; set; }

      [DataMember]
      public string DCOMPDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public double DCOMPDAT_PMAX { get; set; }

      [DataMember]
      public string DCOMPDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_PMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime DCOMPDAT_PMAXTM { get; set; }

      [DataMember]
      public string DCOMPDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_PMINLIM_FORMATTED))]
      public uint DCOMPDAT_PMINLIM { get; set; }

      [DataMember]
      public string DCOMPDAT_PMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_PMAXLIM_FORMATTED))]
      public uint DCOMPDAT_PMAXLIM { get; set; }

      [DataMember]
      public string DCOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_PCOUNT_FORMATTED))]
      public uint DCOMPDAT_PCOUNT { get; set; }

      [DataMember]
      public string DCOMPDAT_PCOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_ISUM_FORMATTED), ValueFormatType.Interval)]
      public double DCOMPDAT_ISUM { get; set; }

      [DataMember]
      public string DCOMPDAT_ISUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_IMINTM_FORMATTED), DateTimeFormatType.IntervalX)]
      public DateTime DCOMPDAT_IMINTM { get; set; }

      [DataMember]
      public string DCOMPDAT_IMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_IMIN_FORMATTED), ValueFormatType.Interval)]
      public double DCOMPDAT_IMIN { get; set; }

      [DataMember]
      public string DCOMPDAT_IMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_IMAXTM_FORMATTED), DateTimeFormatType.IntervalX)]
      public DateTime DCOMPDAT_IMAXTM { get; set; }

      [DataMember]
      public string DCOMPDAT_IMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_IMAX_FORMATTED), ValueFormatType.Interval)]
      public double DCOMPDAT_IMAX { get; set; }

      [DataMember]
      public string DCOMPDAT_IMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_IMINLIM_FORMATTED))]
      public uint DCOMPDAT_IMINLIM { get; set; }

      [DataMember]
      public string DCOMPDAT_IMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_IMAXLIM_FORMATTED))]
      public uint DCOMPDAT_IMAXLIM { get; set; }

      [DataMember]
      public string DCOMPDAT_IMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_ICOUNT_FORMATTED))]
      public uint DCOMPDAT_ICOUNT { get; set; }

      [DataMember]
      public string DCOMPDAT_ICOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_DSUM_FORMATTED), ValueFormatType.Day)]
      public double DCOMPDAT_DSUM { get; set; }

      [DataMember]
      public string DCOMPDAT_DSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_DSIGMA_FORMATTED), ValueFormatType.Day)]
      public float DCOMPDAT_DSIGMA { get; set; }

      [DataMember]
      public string DCOMPDAT_DSIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_DPERC15_FORMATTED), ValueFormatType.Day)]
      public float DCOMPDAT_DPERC15 { get; set; }

      [DataMember]
      public string DCOMPDAT_DPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_DPERC85_FORMATTED), ValueFormatType.Day)]
      public float DCOMPDAT_DPERC85 { get; set; }

      [DataMember]
      public string DCOMPDAT_DPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_DMINTM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime DCOMPDAT_DMINTM { get; set; }

      [DataMember]
      public string DCOMPDAT_DMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_DMIN_FORMATTED), ValueFormatType.Day)]
      public double DCOMPDAT_DMIN { get; set; }

      [DataMember]
      public string DCOMPDAT_DMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_DMAXTM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime DCOMPDAT_DMAXTM { get; set; }

      [DataMember]
      public string DCOMPDAT_DMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_DMAX_FORMATTED), ValueFormatType.Day)]
      public double DCOMPDAT_DMAX { get; set; }

      [DataMember]
      public string DCOMPDAT_DMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_DMINLIM_FORMATTED))]
      public uint DCOMPDAT_DMINLIM { get; set; }

      [DataMember]
      public string DCOMPDAT_DMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_DMAXLIM_FORMATTED))]
      public uint DCOMPDAT_DMAXLIM { get; set; }

      [DataMember]
      public string DCOMPDAT_DMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUInt(nameof(DCOMPDAT_DCOUNT_FORMATTED))]
      public uint DCOMPDAT_DCOUNT { get; set; }

      [DataMember]
      public string DCOMPDAT_DCOUNT_FORMATTED { get; set; }
   }
}
