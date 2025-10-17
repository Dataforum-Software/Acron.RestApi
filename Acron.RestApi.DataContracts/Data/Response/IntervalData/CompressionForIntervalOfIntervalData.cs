using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.IntervalData
{
   [DataContract]
   public class CompressionForIntervalOfIntervalData : ICompressionForIntervalOfIntervalData<CompressionForIntervalOfIntervalDataFlag>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      public CompressionForIntervalOfIntervalDataFlag ICOMPDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleListMarker(nameof(ICOMPDAT_DVAL_FORMATTED), ValueFormatType.Day)]
      public double ICOMPDAT_DVAL { get; set; }
      [DataMember]
      public string ICOMPDAT_DVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(ICOMPDAT_DVALAVG_FORMATTED), ValueFormatType.Day)]
      public float ICOMPDAT_DVALAVG { get; set; }
      [DataMember]
      public string ICOMPDAT_DVALAVG_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(ICOMPDAT_DVALTM_FORMATTED), DateTimeFormatType.DayX)]
      public DateTime ICOMPDAT_DVALTM { get; set; }
      [DataMember]
      public string ICOMPDAT_DVALTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public double ICOMPDAT_PSUM { get; set; }
      [DataMember]
      public string ICOMPDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(ICOMPDAT_PMINTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime ICOMPDAT_PMINTM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public double ICOMPDAT_PMIN { get; set; }
      [DataMember]
      public string ICOMPDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(ICOMPDAT_PMAXTM_FORMATTED), DateTimeFormatType.Process)]
      public DateTime ICOMPDAT_PMAXTM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public double ICOMPDAT_PMAX { get; set; }
      [DataMember]
      public string ICOMPDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_PMINLIM_FORMATTED))]
      public uint ICOMPDAT_PMINLIM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_PMAXLIM_FORMATTED))]
      public uint ICOMPDAT_PMAXLIM { get; set; }
      [DataMember]
      public string ICOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_PCOUNT_FORMATTED))]
      public uint ICOMPDAT_PCOUNT { get; set; }
      [DataMember]
      public string ICOMPDAT_PCOUNT_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_ISUM_FORMATTED), ValueFormatType.Interval)]
      public double ICOMPDAT_ISUM { get; set; }
      [DataMember]
      public string ICOMPDAT_ISUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(ICOMPDAT_ISIGMA_FORMATTED), ValueFormatType.Interval)]
      public float ICOMPDAT_ISIGMA { get; set; }
      [DataMember]
      public string ICOMPDAT_ISIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(ICOMPDAT_IPERC15_FORMATTED), ValueFormatType.Interval)]
      public float ICOMPDAT_IPERC15 { get; set; }
      [DataMember]
      public string ICOMPDAT_IPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(ICOMPDAT_IPERC85_FORMATTED), ValueFormatType.Interval)]
      public float ICOMPDAT_IPERC85 { get; set; }
      [DataMember]
      public string ICOMPDAT_IPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(ICOMPDAT_IMINTM_FORMATTED), DateTimeFormatType.IntervalX)]
      public DateTime ICOMPDAT_IMINTM { get; set; }
      [DataMember]
      public string ICOMPDAT_IMINTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_IMIN_FORMATTED), ValueFormatType.Interval)]
      public double ICOMPDAT_IMIN { get; set; }
      [DataMember]
      public string ICOMPDAT_IMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(ICOMPDAT_IMAXTM_FORMATTED), DateTimeFormatType.IntervalX)]
      public DateTime ICOMPDAT_IMAXTM { get; set; }
      [DataMember]
      public string ICOMPDAT_IMAXTM_FORMATTED { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(ICOMPDAT_IMAX_FORMATTED), ValueFormatType.Interval)]
      public double ICOMPDAT_IMAX { get; set; }
      [DataMember]
      public string ICOMPDAT_IMAX_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_IMINLIM_FORMATTED))]
      public uint ICOMPDAT_IMINLIM { get; set; }
      [DataMember]
      public string ICOMPDAT_IMINLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_IMAXLIM_FORMATTED))]
      public uint ICOMPDAT_IMAXLIM { get; set; }
      [DataMember]
      public string ICOMPDAT_IMAXLIM_FORMATTED { get; set; }

      [DataMember]
      [FormatUIntList(nameof(ICOMPDAT_ICOUNT_FORMATTED))]
      public uint ICOMPDAT_ICOUNT { get; set; }
      [DataMember]
      public string ICOMPDAT_ICOUNT_FORMATTED { get; set; }
   }
}
