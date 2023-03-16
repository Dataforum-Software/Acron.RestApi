using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface IIntervalData<IntervalDataFlagType> where IntervalDataFlagType : IIntervalDataFlag
   {
      [SwaggerSchema("Numeric ID of process variable")]
      [SwaggerExampleValue("302000003")]
      uint PVID { get; set; }

      [SwaggerSchema("Identification of process variable")]
      [SwaggerExampleValue("Temperature")]
      string ShortName { get; set; }

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue(typeof(IIntervalDataFlag))]
      List<IntervalDataFlagType> IDAT_FLAG { get; set; }

      [SwaggerSchema("Interval value")]
      [SwaggerExampleValue("[2192.0, 2250.0, 2288.0]")]
      List<double> IDAT_IVAL { get; set; }

      [SwaggerSchema($"{nameof(IDAT_IVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"2,192.0\", \"2,250.0\", \"2,288.0\"]")]
      List<string> IDAT_IVAL_FORMATTED { get; set; }

      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("[2192.0, 2250.0, 2288.0]")]
      List<double> IDAT_PSUM { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"2,192.0\", \"2,250.0\", \"2,288.0\"]")]
      List<string> IDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of process values")]
      [SwaggerExampleValue("[1.6499158, 1.3307266, 1.2472191]")]
      List<float> IDAT_PSIGMA { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PSIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"1,6499158\", \"1,3307266\", \"1,2472191\"]")]
      List<string> IDAT_PSIGMA_FORMATTED { get; set; }

      [SwaggerSchema("15th percentile of interval values")]
      [SwaggerExampleValue("[89.0, 92.0, 94.0]")]
      List<float> IDAT_PPERC15 { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"89,0\", \"92,0\", \"94,0\"]")]
      List<string> IDAT_PPERC15_FORMATTED { get; set; }

      [SwaggerSchema("85th percentile of interval values")]
      [SwaggerExampleValue("[93.0, 95.0, 97.0]")]
      List<float> IDAT_PPERC85 { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"93,0\", \"95,0\", \"97,0\"]")]
      List<string> IDAT_PPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("[8.22837331E-315, 8.22839999E-315, 8.228442973E-315]")]
      List<double> IDAT_PMIN { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"8,22837331E-315\", \"8,22839999E-315\", \"8,228442973E-315\"]")]
      List<string> IDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\"]")]
      List<DateTime> IDAT_PMINTM { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\"]")]
      List<string> IDAT_PMINTM_FORMATTED { get; set; }

      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("[8.228391096E-315, 8.22843408E-315, 8.22845483E-315]")]
      List<double> IDAT_PMAX { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"8,228391096E-315\", \"8,22843408E-315\", \"8,22845483E-315\"]")]
      List<string> IDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\"]")]
      List<DateTime> IDAT_PMAXTM { get; set; }

      [SwaggerSchema($"{nameof(IDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\"]")]
      List<string> IDAT_PMAXTM_FORMATTED { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("[0, 0, 0]")]
      List<uint> IDAT_PMINLIM { get; set; }

      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("[0, 0, 0]")]
      List<uint> IDAT_PMAXLIM { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("[24, 24, 24]")]
      List<uint> IDAT_PCOUNT { get; set; }

   }
}
