using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.MonthWeekData
{
   public interface ICompressionForIntervalOfMonthWeekData<U> where U : ICompressionForIntervalOfMonthWeekDataFlag
   {
      [SwaggerSchema($"Id of the process variable")]
      [SwaggerExampleValue("302000004")]
      uint PVID { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("gro_e_inspektion")]
      string ShortName { get; set; }

      [SwaggerSchema($"Flags that determine whether the corresponding values are calculated curing the compression")]
      [SwaggerExampleValue(typeof(ICompressionForIntervalOfMonthWeekDataFlag))]
      U YCOMPDAT_FLAG { get; set; }

      [SwaggerSchema($"Compression result")]
      [SwaggerExampleValue(12.76)]
      double YCOMPDAT_YVAL { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_YVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.8")]
      string YCOMPDAT_YVAL_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(YCOMPDAT_YVAL)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime YCOMPDAT_YVALTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_YVALTM_FORMATTED)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string YCOMPDAT_YVALTM_FORMATTED { get; set; }

      [SwaggerSchema("Second special yearly value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue(1.1E+35f)]
      float YCOMPDAT_YVAL1 { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_YVAL1)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1,1E+35")]
      string YCOMPDAT_YVAL1_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(YCOMPDAT_YVAL1)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime YCOMPDAT_YVAL1TM { get; set; }
      [SwaggerSchema($"Time of {nameof(YCOMPDAT_YVAL1TM)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      string YCOMPDAT_YVAL1TM_FORMATTED { get; set; }

      [SwaggerSchema("Third special yearly value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue(1.1E+35f)]
      float YCOMPDAT_YVAL2 { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_YVAL2)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1,1E+35")]
      string YCOMPDAT_YVAL2_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(YCOMPDAT_YVAL2)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime YCOMPDAT_YVAL2TM { get; set; }
      [SwaggerSchema($"Time of {nameof(YCOMPDAT_YVAL2TM)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      string YCOMPDAT_YVAL2TM_FORMATTED { get; set; }

      [SwaggerSchema("Fourth special yearly value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue(1.1E+35f)]
      float YCOMPDAT_YVAL3 { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_YVAL3)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1,1E+35")]
      string YCOMPDAT_YVAL3_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(YCOMPDAT_YVAL3)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime YCOMPDAT_YVAL3TM { get; set; }
      [SwaggerSchema($"Time of {nameof(YCOMPDAT_YVAL3TM)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      string YCOMPDAT_YVAL3TM_FORMATTED { get; set; }

      [SwaggerSchema("Sum of the process values")]
      [SwaggerExampleValue(74737.0)]
      double YCOMPDAT_PSUM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("74737")]
      string YCOMPDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Time of the minimal process value")]
      [SwaggerExampleValue("2022-10-14T12:14:59Z")]
      DateTime YCOMPDAT_PMINTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string YCOMPDAT_PMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimal process value")]
      [SwaggerExampleValue(69.0)]
      double YCOMPDAT_PMIN { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("69")]
      string YCOMPDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of the maximal process value")]
      [SwaggerExampleValue("2022-10-14T12:14:59Z")]
      DateTime YCOMPDAT_PMAXTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string YCOMPDAT_PMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximal process value")]
      [SwaggerExampleValue(69.0)]
      double YCOMPDAT_PMAX { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("69")]
      string YCOMPDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit shortfalls - process values")]
      [SwaggerExampleValue(0)]
      uint YCOMPDAT_PMINLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string YCOMPDAT_PMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit exceedings - process values")]
      [SwaggerExampleValue(0)]
      uint YCOMPDAT_PMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string YCOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue(2016)]
      uint YCOMPDAT_PCOUNT { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_PCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2016")]
      string YCOMPDAT_PCOUNT_FORMATTED { get; set; }

      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue(179647.0)]
      double YCOMPDAT_ISUM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_ISUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("179.647")]
      string YCOMPDAT_ISUM_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime YCOMPDAT_IMINTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_IMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1,1E+35")]
      string YCOMPDAT_IMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue(1734.0)]
      double YCOMPDAT_IMIN { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_IMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1.734")]
      string YCOMPDAT_IMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime YCOMPDAT_IMAXTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_IMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string YCOMPDAT_IMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue(2381)]
      double YCOMPDAT_IMAX { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_IMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2.381")]
      string YCOMPDAT_IMAX_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue(0)]
      uint YCOMPDAT_IMINLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_IMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string YCOMPDAT_IMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue(84)]
      uint YCOMPDAT_IMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_IMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("84")]
      string YCOMPDAT_IMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("number of interval values")]
      [SwaggerExampleValue(84)]
      uint YCOMPDAT_ICOUNT { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_ICOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("84")]
      string YCOMPDAT_ICOUNT_FORMATTED { get; set; }

      [SwaggerSchema("Sum of daily values")]
      [SwaggerExampleValue(179647.0)]
      double YCOMPDAT_DSUM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("179.647")]
      string YCOMPDAT_DSUM_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum daily value")]
      [SwaggerExampleValue("2022-10-13T22:00:00Z")]
      DateTime YCOMPDAT_DMINTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string YCOMPDAT_DMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimum daily value")]
      [SwaggerExampleValue(23324.0)]
      double YCOMPDAT_DMIN { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("23.324")]
      string YCOMPDAT_DMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum daily value")]
      [SwaggerExampleValue("2022-10-12T22:00:00Z")]
      DateTime YCOMPDAT_DMAXTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string YCOMPDAT_DMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum daily value")]
      [SwaggerExampleValue(27093.0)]
      double YCOMPDAT_DMAX { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("27.093")]
      string YCOMPDAT_DMAX_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - daily values")]
      [SwaggerExampleValue(0)]
      uint YCOMPDAT_DMINLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string YCOMPDAT_DMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit exceedings - daily values")]
      [SwaggerExampleValue(7)]
      uint YCOMPDAT_DMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string YCOMPDAT_DMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of daily values")]
      [SwaggerExampleValue(7)]
      uint YCOMPDAT_DCOUNT { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_DCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string YCOMPDAT_DCOUNT_FORMATTED { get; set; }

      [SwaggerSchema("Sum of monthly values")]
      [SwaggerExampleValue(179647.0)]
      double YCOMPDAT_MSUM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("179.647")]
      string YCOMPDAT_MSUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of monthly values")]
      [SwaggerExampleValue(1358.6782f)]
      float YCOMPDAT_MSIGMA { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MSIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1.358")]
      string YCOMPDAT_MSIGMA_FORMATTED { get; set; }

      [SwaggerSchema("15th percentile of monthly values")]
      [SwaggerExampleValue(23932.0f)]
      float YCOMPDAT_MPERC15 { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("23.932")]
      string YCOMPDAT_MPERC15_FORMATTED { get; set; }

      [SwaggerSchema("85th percentile of monthly values")]
      [SwaggerExampleValue(26972.0f)]
      float YCOMPDAT_MPERC85 { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("26.972")]
      string YCOMPDAT_MPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum monthly value")]
      [SwaggerExampleValue("2022-10-13T22:00:00Z")]
      DateTime YCOMPDAT_MMINTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string YCOMPDAT_MMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimum monthly value")]
      [SwaggerExampleValue(23324.0)]
      double YCOMPDAT_MMIN { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("23.324")]
      string YCOMPDAT_MMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum monthly value")]
      [SwaggerExampleValue("2022-10-12T22:00:00Z")]
      DateTime YCOMPDAT_MMAXTM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string YCOMPDAT_MMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum monthly value")]
      [SwaggerExampleValue(27093.0)]
      double YCOMPDAT_MMAX { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("27.093")]
      string YCOMPDAT_MMAX_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - monthly values")]
      [SwaggerExampleValue(0)]
      uint YCOMPDAT_MMINLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string YCOMPDAT_MMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit exceedings - monthly values")]
      [SwaggerExampleValue(7)]
      uint YCOMPDAT_MMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string YCOMPDAT_MMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of monthly values")]
      [SwaggerExampleValue(7)]
      uint YCOMPDAT_MCOUNT { get; set; }
      [SwaggerSchema($"{nameof(YCOMPDAT_MCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string YCOMPDAT_MCOUNT_FORMATTED { get; set; }
   }
}
