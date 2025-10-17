using Acron.RestApi.Interfaces.Data.Response.MonthWeekData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface ICompressionForIntervalOfIntervalData<U> where U : ICompressionForIntervalOfIntervalDataFlag
   {
      [SwaggerSchema($"Id of the process variable")]
      [SwaggerExampleValue("302000004")]
      uint PVID { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("gro_e_inspektion")]
      string ShortName { get; set; }

      [SwaggerSchema($"Flags that determine whether the corresponding values are calculated curing the compression")]
      [SwaggerExampleValue(typeof(ICompressionForIntervalOfIntervalDataFlag))]
      U ICOMPDAT_FLAG { get; set; }

      [SwaggerSchema($"Compression result")]
      [SwaggerExampleValue(12.76)]
      double ICOMPDAT_DVAL { get; set; }

      [SwaggerSchema($"{nameof(ICOMPDAT_DVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_DVAL_FORMATTED { get; set; }

      [SwaggerSchema($"Average value of the process variable. Always 0 for temporary compression")]
      [SwaggerExampleValue(12.76f)]
      float ICOMPDAT_DVALAVG { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_DVALAVG)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_DVALAVG_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(ICOMPDAT_DVAL)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime ICOMPDAT_DVALTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_DVALTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string ICOMPDAT_DVALTM_FORMATTED { get; set; }

      [SwaggerSchema("Sum of the process values")]
      [SwaggerExampleValue(74737.0)]
      double ICOMPDAT_PSUM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("74737")]
      string ICOMPDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Time of the minimal process value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime ICOMPDAT_PMINTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string ICOMPDAT_PMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimal process value")]
      [SwaggerExampleValue(12.76)]
      double ICOMPDAT_PMIN { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of the maximal process value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime ICOMPDAT_PMAXTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string ICOMPDAT_PMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximal process value")]
      [SwaggerExampleValue(12.76)]
      double ICOMPDAT_PMAX { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit shortfalls - process values")]
      [SwaggerExampleValue(7)]
      uint ICOMPDAT_PMINLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string ICOMPDAT_PMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit exceedings - process values")]
      [SwaggerExampleValue(7)]
      uint ICOMPDAT_PMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string ICOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue(7)]
      uint ICOMPDAT_PCOUNT { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string ICOMPDAT_PCOUNT_FORMATTED { get; set; }

      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue(12.76)]
      double ICOMPDAT_ISUM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_ISUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_ISUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of daily values")]
      [SwaggerExampleValue(12.76f)]
      float ICOMPDAT_ISIGMA { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_ISIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_ISIGMA_FORMATTED { get; set; }

      [SwaggerSchema("15th percentile of interval values")]
      [SwaggerExampleValue(12.76f)]
      float ICOMPDAT_IPERC15 { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_IPERC15_FORMATTED { get; set; }

      [SwaggerSchema("85th percentile of interval values")]
      [SwaggerExampleValue(12.76f)]
      float ICOMPDAT_IPERC85 { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_IPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime ICOMPDAT_IMINTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string ICOMPDAT_IMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimum intervalvalue")]
      [SwaggerExampleValue(12.76)]
      double ICOMPDAT_IMIN { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_IMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime ICOMPDAT_IMAXTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string ICOMPDAT_IMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue(12.76)]
      double ICOMPDAT_IMAX { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string ICOMPDAT_IMAX_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue(7)]
      uint ICOMPDAT_IMINLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string ICOMPDAT_IMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue(7)]
      uint ICOMPDAT_IMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string ICOMPDAT_IMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of interval values")]
      [SwaggerExampleValue(7)]
      uint ICOMPDAT_ICOUNT { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_ICOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string ICOMPDAT_ICOUNT_FORMATTED { get; set; }

   }
}
