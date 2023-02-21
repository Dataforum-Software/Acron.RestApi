using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.DayData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.DayData
{
   [DataContract]
   public class DayData : IDayData
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }



      [DataMember]
      public List<IDayDataFlag> DDAT_FLAG { get; set; }

      [DataMember]
      [FormatDoubleListMarker(nameof(DDAT_DVAL_FORMATTED), ValueFormatType.Day)]
      public List<double> DDAT_DVAL { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<string> DDAT_DVAL_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(DDAT_DVALAVG_FORMATTED), ValueFormatType.Day)]
      public List<float> DDAT_DVALAVG { get; set; }

      [DataMember]
      public List<string> DDAT_DVALAVG_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(DDAT_DVALTM_FORMATTED), nameof(DDAT_DVALTM_TIMEZONE), DateTimeFormatType.DayX)]
      public List<DateTime> DDAT_DVALTM { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<string> DDAT_DVALTM_FORMATTED { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<DateTime> DDAT_DVALTM_TIMEZONE { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(DDAT_PSUM_FORMATTED), ValueFormatType.Process)]
      public List<double> DDAT_PSUM { get; set; }

      [DataMember]
      public List<string> DDAT_PSUM_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(DDAT_PMINTM_FORMATTED),nameof(DDAT_PMINTM_TIMEZONE), DateTimeFormatType.Process)]
      public List<DateTime> DDAT_PMINTM { get; set; }

      //ToDo Swagger
      [DataMember]      
      public List<string> DDAT_PMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<DateTime> DDAT_PMINTM_TIMEZONE { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(DDAT_PMIN_FORMATTED), ValueFormatType.Process)]
      public List<double> DDAT_PMIN { get; set; }

      [DataMember]
      public List<string> DDAT_PMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(DDAT_PMAXTM_FORMATTED), nameof(DDAT_PMAXTM_TIMEZONE), DateTimeFormatType.Process)]
      public List<DateTime> DDAT_PMAXTM { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<string> DDAT_PMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<DateTime> DDAT_PMAXTM_TIMEZONE { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(DDAT_PMAX_FORMATTED), ValueFormatType.Process)]
      public List<double> DDAT_PMAX { get; set; }

      [DataMember]
      public List<string> DDAT_PMAX_FORMATTED { get; set; }

      [DataMember]
      public List<uint> DDAT_PMINLIM { get; set; }

      [DataMember]
      public List<uint> DDAT_PMAXLIM { get; set; }

      [DataMember]
      public List<uint> DDAT_PCOUNT { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(DDAT_ISUM_FORMATTED), ValueFormatType.Interval)]
      public List<double> DDAT_ISUM { get; set; }

      [DataMember]
      public List<string> DDAT_ISUM_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(DDAT_ISIGMA_FORMATTED), ValueFormatType.Interval)]
      public List<float> DDAT_ISIGMA { get; set; }

      [DataMember]
      public List<string> DDAT_ISIGMA_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(DDAT_IPERC15_FORMATTED), ValueFormatType.Interval)]
      public List<float> DDAT_IPERC15 { get; set; }

      [DataMember]
      public List<string> DDAT_IPERC15_FORMATTED { get; set; }

      [DataMember]
      [FormatFloatList(nameof(DDAT_IPERC85_FORMATTED), ValueFormatType.Interval)]
      public List<float> DDAT_IPERC85 { get; set; }

      [DataMember]
      public List<string> DDAT_IPERC85_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(DDAT_IMINTM_FORMATTED), nameof(DDAT_IMINTM_TIMEZONE), DateTimeFormatType.IntervalX)]
      public List<DateTime> DDAT_IMINTM { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<string> DDAT_IMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<DateTime> DDAT_IMINTM_TIMEZONE { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(DDAT_IMIN_FORMATTED), ValueFormatType.Interval)]
      public List<double> DDAT_IMIN { get; set; }

      [DataMember]
      public List<string> DDAT_IMIN_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(DDAT_IMAXTM_FORMATTED), nameof(DDAT_IMAXTM_TIMEZONE), DateTimeFormatType.IntervalX)]
      public List<DateTime> DDAT_IMAXTM { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<string> DDAT_IMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      [DataMember]
      public List<DateTime> DDAT_IMAXTM_TIMEZONE { get; set; }

      [DataMember]
      [FormatDoubleList(nameof(DDAT_IMAX_FORMATTED), ValueFormatType.Interval)]
      public List<double> DDAT_IMAX { get; set; }

      [DataMember]
      public List<string> DDAT_IMAX_FORMATTED { get; set; }

      [DataMember]
      public List<uint> DDAT_IMINLIM { get; set; }

      [DataMember]
      public List<uint> DDAT_IMAXLIM { get; set; }

      [DataMember]
      public List<uint> DDAT_ICOUNT { get; set; }
   }
}
