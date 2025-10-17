using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface ICompressionForIntervalOfCustomIntervalData<U, V> where U : ICompressionForIntervalOfCustomIntervalDataFlag_Day where V : ICompressionForIntervalOfCustomIntervalDataFlag_Interval
   {
      [SwaggerSchema($"Id of the process variable")]
      [SwaggerExampleValue("302000004")]
      uint PVID { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("gro_e_inspektion")]
      string ShortName { get; set; }

      #region DayData
      [SwaggerSchema($"Flags that determine whether the corresponding values are calculated curing the compression")]
      [SwaggerExampleValue(typeof(ICompressionForIntervalOfIntervalDataFlag))]
      U DCOMPDAT_FLAG { get; set; }

      [SwaggerSchema($"Compression result")]
      [SwaggerExampleValue(12.76)]
      double DCOMPDAT_DVAL { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_DVAL_FORMATTED { get; set; }

      [SwaggerSchema($"Average value of the process variable. Always 0 for temporary compression")]
      [SwaggerExampleValue(12.76f)]
      float DCOMPDAT_DVALAVG { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DVALAVG)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_DVALAVG_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(DCOMPDAT_DVAL)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_DVALTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DVALTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_DVALTM_FORMATTED { get; set; }

      [SwaggerSchema("Sum of the process values")]
      [SwaggerExampleValue(74737.0)]
      double DCOMPDAT_PSUM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("74737")]
      string DCOMPDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Time of the minimal process value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_PMINTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_PMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimal process value")]
      [SwaggerExampleValue(12.76)]
      double DCOMPDAT_PMIN { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of the maximal process value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_PMAXTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_PMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximal process value")]
      [SwaggerExampleValue(12.76)]
      double DCOMPDAT_PMAX { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit shortfalls - process values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_PMINLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_PMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit exceedings - process values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_PMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_PCOUNT { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_PCOUNT_FORMATTED { get; set; }

      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue(12.76)]
      double DCOMPDAT_ISUM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_ISUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_ISUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of daily values")]
      [SwaggerExampleValue(12.76f)]
      float DCOMPDAT_ISIGMA { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_ISIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_ISIGMA_FORMATTED { get; set; }

      [SwaggerSchema("15th percentile of interval values")]
      [SwaggerExampleValue(12.76f)]
      float DCOMPDAT_IPERC15 { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_IPERC15_FORMATTED { get; set; }

      [SwaggerSchema("85th percentile of interval values")]
      [SwaggerExampleValue(12.76f)]
      float DCOMPDAT_IPERC85 { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_IPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_IMINTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_IMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimum intervalvalue")]
      [SwaggerExampleValue(12.76)]
      double DCOMPDAT_IMIN { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_IMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_IMAXTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_IMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue(12.76)]
      double DCOMPDAT_IMAX { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string DCOMPDAT_IMAX_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_IMINLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_IMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_IMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_IMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of interval values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_ICOUNT { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_ICOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_ICOUNT_FORMATTED { get; set; }
      #endregion

      #region IntervalData
      [SwaggerSchema($"Flags that determine whether the corresponding values are calculated curing the compression")]
      [SwaggerExampleValue(typeof(ICompressionForIntervalOfCustomIntervalDataFlag_Interval))]
      List<V> ICOMPDAT_FLAG { get; set; }

      [SwaggerSchema($"Compression result")]
      [SwaggerExampleValue(new double[] { 12.76, 13.87 })]
      List<double> ICOMPDAT_IVAL { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "12.8", "13.9" })]
      List<string> ICOMPDAT_IVAL_FORMATTED { get; set; }

      [SwaggerSchema("Sum of the process values")]
      [SwaggerExampleValue(new double[] { 74737.0, 34521.0 })]
      List<double> ICOMPDAT_PSUM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "74737", "34521" })]
      List<string> ICOMPDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of daily values")]
      [SwaggerExampleValue(new float[] { 12.76f, 13.87f })]
      List<float> ICOMPDAT_PSIGMA { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PSIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "12.8", "13.9" })]
      List<string> ICOMPDAT_PSIGMA_FORMATTED { get; set; }

      [SwaggerSchema("15th percentile of interval values")]
      [SwaggerExampleValue(new float[] { 12.76f, 13.87f })]
      List<float> ICOMPDAT_PPERC15 { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "12.8", "13.9" })]
      List<string> ICOMPDAT_PPERC15_FORMATTED { get; set; }

      [SwaggerSchema("85th percentile of interval values")]
      [SwaggerExampleValue(new float[] { 12.76f, 13.87f })]
      List<float> ICOMPDAT_PPERC85 { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "12.8", "13.9" })]
      List<string> ICOMPDAT_PPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Minimal process value")]
      [SwaggerExampleValue(new double[] { 12.76, 13.87 })]
      List<double> ICOMPDAT_PMIN { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "12.8", "13.9" })]
      List<string> ICOMPDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of the minimal process value")]
      [SwaggerExampleValue(new string[] { "1970-01-01T00:00:00Z", "1970-01-01T00:00:00Z" })]
      List<DateTime> ICOMPDAT_PMINTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "01.01.1970 00:00:00", "01.01.1970 00:00:00" })]
      List<string> ICOMPDAT_PMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximal process value")]
      [SwaggerExampleValue(new double[] { 12.76, 13.87 })]
      List<double> ICOMPDAT_PMAX { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "12.8", "13.9" })]
      List<string> ICOMPDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("Time of the maximal process value")]
      [SwaggerExampleValue(new string[] { "1970-01-01T00:00:00Z", "1970-01-01T00:00:00Z" })]
      List<DateTime> ICOMPDAT_PMAXTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "01.01.1970 00:00:00", "01.01.1970 00:00:00" })]
      List<string> ICOMPDAT_PMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit shortfalls - process values")]
      [SwaggerExampleValue(new uint[] { 7, 8 })]
      List<uint> ICOMPDAT_PMINLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "7", "8" })]
      List<string> ICOMPDAT_PMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("´Number of range limit exceedings - process values")]
      [SwaggerExampleValue(new uint[] { 7, 8 })]
      List<uint> ICOMPDAT_PMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "7", "8" })]
      List<string> ICOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue(new uint[] { 7, 8 })]
      List<uint> ICOMPDAT_PCOUNT { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "7", "8" })]
      List<string> ICOMPDAT_PCOUNT_FORMATTED { get; set; }
      #endregion
   }
}

