using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface ICompressionForIntervalOfProcessData<U> where U : ICompressionForIntervalOfProcessDataFlag
   {
      [SwaggerSchema($"Id of the process variable")]
      [SwaggerExampleValue("302000004")]
      uint PVID { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("a1")]
      string ShortName { get; set; }

      [SwaggerSchema($"Flags that determine whether the corresponding values are calculated curing the compression")]
      [SwaggerExampleValue(typeof(ICompressionForIntervalOfProcessDataFlag))]
      U ICOMPDAT_FLAG { get; set; }

      [SwaggerSchema($"Compression result")]
      [SwaggerExampleValue(12.76)]
      double ICOMPDAT_IVAL { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_IVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_IVAL_FORMATTED { get; set; }

      [SwaggerSchema("Sum of the process values")]
      [SwaggerExampleValue(74737.0)]
      double ICOMPDAT_PSUM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of process values")]
      [SwaggerExampleValue(1358.6782f)]
      float ICOMPDAT_PSIGMA { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PSIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PSIGMA_FORMATTED { get; set; }

      [SwaggerSchema("15th percentile of process values")]
      [SwaggerExampleValue(23932.0f)]
      float ICOMPDAT_PPERC15 { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PPERC15_FORMATTED { get; set; }

      [SwaggerSchema("85th percentile of process values")]
      [SwaggerExampleValue(23932.0f)]
      float ICOMPDAT_PPERC85 { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Minimal process value")]
      [SwaggerExampleValue(69.0)]
      double ICOMPDAT_PMIN { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of the minimal process value")]
      [SwaggerExampleValue("2022-10-14T12:14:59Z")]
      DateTime ICOMPDAT_PMINTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximal process value")]
      [SwaggerExampleValue(69.0)]
      double ICOMPDAT_PMAX { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("Time of the maximal process value")]
      [SwaggerExampleValue("2022-10-14T12:14:59Z")]
      DateTime ICOMPDAT_PMAXTM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit shortfalls - process values")]
      [SwaggerExampleValue(0)]
      uint ICOMPDAT_PMINLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMINLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PMINLIM_FORMATTED { get; set; }

      [SwaggerSchema("number of range limit exceedings - process values")]
      [SwaggerExampleValue(0)]
      uint ICOMPDAT_PMAXLIM { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PMAXLIM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PMAXLIM_FORMATTED { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue(2016)]
      uint ICOMPDAT_PCOUNT { get; set; }
      [SwaggerSchema($"{nameof(ICOMPDAT_PCOUNT)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("12.7")]
      string ICOMPDAT_PCOUNT_FORMATTED { get; set; }





   }
}
