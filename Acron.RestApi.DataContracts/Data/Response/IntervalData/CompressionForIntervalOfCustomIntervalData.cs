using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.IntervalData
{
   [DataContract]
   public class CompressionForIntervalOfCustomIntervalData : ICompressionForIntervalOfCustomIntervalData<CompressionForIntervalOfCustomIntervalDataFlag_Day, CompressionForIntervalOfCustomIntervalDataFlag_Interval>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }
      #region DayData
      [DataMember]
      public CompressionForIntervalOfCustomIntervalDataFlag_Day DCOMPDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleMarker(nameof(DCOMPDAT_DVAL_FORMATTED), ValueFormatType.Day)]
      public double DCOMPDAT_DVAL { get; set; }
      [DataMember]
      public string DCOMPDAT_DVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_DVALAVG_FORMATTED), ValueFormatType.Day)]
      public float DCOMPDAT_DVALAVG { get; set; }
      [DataMember]
      public string DCOMPDAT_DVALAVG_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_DVALTM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime DCOMPDAT_DVALTM { get; set; }
      [DataMember]
      public string DCOMPDAT_DVALTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public double DCOMPDAT_PSUM { get; set; }
      [DataMember]
      public string DCOMPDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime DCOMPDAT_PMINTM { get; set; }
      [DataMember]
      public string DCOMPDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public double DCOMPDAT_PMIN { get; set; }
      [DataMember]
      public string DCOMPDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(DCOMPDAT_PMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime DCOMPDAT_PMAXTM { get; set; }
      [DataMember]
      public string DCOMPDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(DCOMPDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public double DCOMPDAT_PMAX { get; set; }
      [DataMember]
      public string DCOMPDAT_PMAX_FORMATTED { get; set; }

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
      [FormatFloat(nameof(DCOMPDAT_ISIGMA_FORMATTED), ValueFormatType.Interval)]
      public float DCOMPDAT_ISIGMA { get; set; }
      [DataMember]
      public string DCOMPDAT_ISIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_IPERC15_FORMATTED), ValueFormatType.Interval)]
      public float DCOMPDAT_IPERC15 { get; set; }
      [DataMember]
      public string DCOMPDAT_IPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloat(nameof(DCOMPDAT_IPERC85_FORMATTED), ValueFormatType.Interval)]
      public float DCOMPDAT_IPERC85 { get; set; }
      [DataMember]
      public string DCOMPDAT_IPERC85_FORMATTED { get; set; }

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
      #endregion

      #region IntervalData

      [DataMember]
      public List<CompressionForIntervalOfCustomIntervalDataFlag_Interval> ICOMPDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_IVAL_FORMATTED), ValueFormatType.Interval)]
      public List<double> ICOMPDAT_IVAL { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_IVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_PSUM_FORMATTED), ValueFormatType.Interval)]
      public List<double> ICOMPDAT_PSUM { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(ICOMPDAT_PSIGMA_FORMATTED), ValueFormatType.Interval)]
      public List<float> ICOMPDAT_PSIGMA { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PSIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(ICOMPDAT_PPERC15_FORMATTED), ValueFormatType.Interval)]
      public List<float> ICOMPDAT_PPERC15 { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(ICOMPDAT_PPERC85_FORMATTED), ValueFormatType.Interval)]
      public List<float> ICOMPDAT_PPERC85 { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_PMIN_FORMATTED), ValueFormatType.Interval)]
      public List<double> ICOMPDAT_PMIN { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(ICOMPDAT_PMINTM_FORMATTED), DateTimeFormatType.IntervalX)]
      public List<DateTime> ICOMPDAT_PMINTM { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_PMAX_FORMATTED), ValueFormatType.Interval)]
      public List<double> ICOMPDAT_PMAX { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(ICOMPDAT_PMAXTM_FORMATTED), DateTimeFormatType.IntervalX)]
      public List<DateTime> ICOMPDAT_PMAXTM { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_PMINLIM_FORMATTED))]
      public List<uint> ICOMPDAT_PMINLIM { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_PMAXLIM_FORMATTED))]
      public List<uint> ICOMPDAT_PMAXLIM { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_PCOUNT_FORMATTED))]
      public List<uint> ICOMPDAT_PCOUNT { get; set; }
      [DataMember]
      public List<string> ICOMPDAT_PCOUNT_FORMATTED { get; set; }
      #endregion
   }
}

