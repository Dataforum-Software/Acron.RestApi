using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface ICompressionForIntervalOfDayData<U> where U : ICompressionForIntervalOfDayDataFlag
   {
      [SwaggerSchema($"Id of the process variable")]
      [SwaggerExampleValue("302000004")]
      uint PVID { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("gro_e_inspektion")]
      string ShortName { get; set; }

      [SwaggerSchema($"Flags that determine whether the corresponding values are calculated curing the compression")]
      [SwaggerExampleValue("d9262d90-5feb-4d55-b9b8-2b12093abd25")]
      U DCOMPDAT_FLAG { get; set; }

      [SwaggerSchema($"Compression result")]
      [SwaggerExampleValue(12.76)]
      double DCOMPDAT_MVAL { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("15")]
      string DCOMPDAT_MVAL_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(DCOMPDAT_MVAL)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_MVALTM { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVALTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_MVALTM_FORMATTED { get; set; }

      [SwaggerSchema("Second special monthly value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue(1.1E+35f)]
      float DCOMPDAT_MVAL1 { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVAL1)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1,1E+35")]
      string DCOMPDAT_MVAL1_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(DCOMPDAT_MVAL1)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_MVAL1TM { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVAL1TM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_MVAL1TM_FORMATTED { get; set; }

      [SwaggerSchema("Third special monthly value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue(1.1E+35f)]
      float DCOMPDAT_MVAL2 { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVAL2)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1,1E+35")]
      string DCOMPDAT_MVAL2_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(DCOMPDAT_MVAL2)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_MVAL2TM { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVAL2TM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_MVAL2TM_FORMATTED { get; set; }

      [SwaggerSchema("Fourth special monthly value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue(1.1E+35f)]
      float DCOMPDAT_MVAL3 { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVAL3)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1,1E+35")]
      string DCOMPDAT_MVAL3_FORMATTED { get; set; }

      [SwaggerSchema($"Time of {nameof(DCOMPDAT_MVAL3)}")]
      [SwaggerExampleValue("1970-01-01T00:00:00Z")]
      DateTime DCOMPDAT_MVAL3TM { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_MVAL2TM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.01.1970 00:00:00")]
      string DCOMPDAT_MVAL3TM_FORMATTED { get; set; }

      [SwaggerSchema("Sum of the process values")]
      [SwaggerExampleValue(74737.0)]
      double DCOMPDAT_PSUM { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("74737")]
      string DCOMPDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Time of the minimal process value")]
      [SwaggerExampleValue("2022-10-14T12:14:59Z")]
      DateTime DCOMPDAT_PMINTM { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string DCOMPDAT_PMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimal process value")]
      [SwaggerExampleValue(69.0)]
      double DCOMPDAT_PMIN { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("69")]
      string DCOMPDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of the maximal process value")]
      [SwaggerExampleValue("2022-10-14T12:14:59Z")]
      DateTime DCOMPDAT_PMAXTM { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string DCOMPDAT_PMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximal process value")]
      [SwaggerExampleValue(69.0)]
      double DCOMPDAT_PMAX { get; set; }

      [SwaggerSchema($"{nameof(DCOMPDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("69")]
      string DCOMPDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit shortfalls - process values")]
      [SwaggerExampleValue(0)]
      uint DCOMPDAT_PMINLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string DCOMPDAT_PMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit exceedings - process values")]
      [SwaggerExampleValue(0)]
      uint DCOMPDAT_PMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string DCOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue(2016)]
      uint DCOMPDAT_PCOUNT { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_PCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2016")]
      string DCOMPDAT_PCOUNT_FORMATTED { get; set; }

      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue(179647.0)]
      double DCOMPDAT_ISUM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_ISUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("179.647")]
      string DCOMPDAT_ISUM_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("2022-10-14T10:00:00Z")]
      DateTime DCOMPDAT_IMINTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string DCOMPDAT_IMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue(1734.0)]
      double DCOMPDAT_IMIN { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1.734")]
      string DCOMPDAT_IMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("2022-10-13T10:00:00Z")]
      DateTime DCOMPDAT_IMAXTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string DCOMPDAT_IMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue(2381.0)]
      double DCOMPDAT_IMAX { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2.381")]
      string DCOMPDAT_IMAX_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue(0)]
      uint DCOMPDAT_IMINLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string DCOMPDAT_IMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue(84)]
      uint DCOMPDAT_IMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_IMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("84")]
      string DCOMPDAT_IMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("number of interval values")]
      [SwaggerExampleValue(84)]
      uint DCOMPDAT_ICOUNT { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_ICOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("69")]
      string DCOMPDAT_ICOUNT_FORMATTED { get; set; }

      [SwaggerSchema("Sum of daily values")]
      [SwaggerExampleValue(179647.0)]
      double DCOMPDAT_DSUM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("179.647")]
      string DCOMPDAT_DSUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of daily values")]
      [SwaggerExampleValue(1358.6782f)]
      float DCOMPDAT_DSIGMA { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DSIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("1.358")]
      string DCOMPDAT_DSIGMA_FORMATTED { get; set; }

      [SwaggerSchema("15th percentile of daily values")]
      [SwaggerExampleValue(23932.0f)]
      float DCOMPDAT_DPERC15 { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("23.932")]
      string DCOMPDAT_DPERC15_FORMATTED { get; set; }

      [SwaggerSchema("85th percentile of daily values")]
      [SwaggerExampleValue(26972.0f)]
      float DCOMPDAT_DPERC85 { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("26.972")]
      string DCOMPDAT_DPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum daily value")]
      [SwaggerExampleValue("2022-10-13T22:00:00Z")]
      DateTime DCOMPDAT_DMINTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string DCOMPDAT_DMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Minimum daily value")]
      [SwaggerExampleValue(23324.0)]
      double DCOMPDAT_DMIN { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("23.324")]
      string DCOMPDAT_DMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum daily value")]
      [SwaggerExampleValue("2022-10-12T22:00:00Z")]
      DateTime DCOMPDAT_DMAXTM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("14.10.2022 12:14:59")]
      string DCOMPDAT_DMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum daily value")]
      [SwaggerExampleValue(27093.0)]
      double DCOMPDAT_DMAX { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("27.093")]
      string DCOMPDAT_DMAX_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - daily values")]
      [SwaggerExampleValue(0)]
      uint DCOMPDAT_DMINLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("0")]
      string DCOMPDAT_DMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit exceedings - daily values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_DMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_DMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of daily values")]
      [SwaggerExampleValue(7)]
      uint DCOMPDAT_DCOUNT { get; set; }
      [SwaggerSchema($"{nameof(DCOMPDAT_DCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7")]
      string DCOMPDAT_DCOUNT_FORMATTED { get; set; }
   }
}
