using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface IIntervalData
   {
      [SwaggerSchema("Id of process value")]
      [SwaggerExampleValue("302000003")]
      uint PVID { get; set; }

      [SwaggerSchema("Name of process value")]
      [SwaggerExampleValue("Zulauf")]
      string ShortName { get; set; }

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("[{}, {}, {}, {}, {}, {}, {},…]")]
      List<IIntervalDataFlag> IDAT_FLAG { get; set; }

      [SwaggerSchema("Interval value")]
      [SwaggerExampleValue("[2192.0, 2250.0, 2288.0, 2294.0, 2222.0, 2166.0, 2244.0, 2156.0, 2248.0, 2292.0, 2052.0, 1960.0]")]
      List<double> IDAT_IVAL { get; set; }

      //ToDo Swagger
      List<string> IDAT_IVAL_FORMATTED { get; set; }

      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("[2192.0, 2250.0, 2288.0, 2294.0, 2222.0, 2166.0, 2244.0, 2156.0, 2248.0, 2292.0, 2052.0, 1960.0]")]
      List<double> IDAT_PSUM { get; set; }

      //ToDo Swagger
      List<string> IDAT_PSUM_FORMATTED { get; set; }

      [SwaggerSchema("Standard deviation of process values")]
      [SwaggerExampleValue("[1.6499158, 1.3307266, 1.2472191, 1.4117562, 1.5789412, 0.8779712, 1.3228756, 1.4043583, 1.8408935, 1.1902381, 5.2201533, 1.7480147]")]
      List<float> IDAT_PSIGMA { get; set; }

      //ToDo Swagger
      List<string> IDAT_PSIGMA_FORMATTED { get; set; }

      [SwaggerSchema("Percentile value 15% of process values")]
      [SwaggerExampleValue("[89.0, 92.0, 94.0, 94.0, 91.0, 89.0, 92.0, 88.0, 91.0, 94.0, 79.0, 80.0]")]
      List<float> IDAT_PPERC15 { get; set; }

      //ToDo Swagger
      List<string> IDAT_PPERC15_FORMATTED { get; set; }

      [SwaggerSchema("Percentile value 85% of process values")]
      [SwaggerExampleValue("[93.0, 95.0, 97.0, 97.0, 94.0, 91.0, 95.0, 91.0, 95.0, 97.0, 92.0, 84.0]")]
      List<float> IDAT_PPERC85 { get; set; }

      //ToDo Swagger
      List<string> IDAT_PPERC85_FORMATTED { get; set; }

      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("[8.22837331E-315, 8.22839999E-315, 8.228442973E-315, 8.22849633E-315, 8.228533387E-315, 8.22854969E-315, 8.228579335E-315, 8.22863566E-315, 8.228649E-315, 8.228712733E-315, 8.22874979E-315, 8.2287572E-315]")]
      List<double> IDAT_PMIN { get; set; }

      //ToDo Swagger
      List<string> IDAT_PMIN_FORMATTED { get; set; }

      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\",…]")]
      List<DateTime> IDAT_PMINTM { get; set; }

      //ToDo Swagger
      List<string> IDAT_PMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> IDAT_PMINTM_TIMEZONE { get; set; }

      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("[8.228391096E-315, 8.22843408E-315, 8.22845483E-315, 8.2284741E-315, 8.22850967E-315, 8.22856303E-315, 8.228598604E-315, 8.228613426E-315, 8.22868309E-315, 8.228686054E-315, 8.228720144E-315, 8.22878388E-315]")]
      List<double> IDAT_PMAX { get; set; }

      //ToDo Swagger
      List<string> IDAT_PMAX_FORMATTED { get; set; }

      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\",…]")]
      List<DateTime> IDAT_PMAXTM { get; set; }

      //ToDo Swagger
      List<string> IDAT_PMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> IDAT_PMAXTM_TIMEZONE { get; set; }

      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("[0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]")]
      List<uint> IDAT_PMINLIM { get; set; }

      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("[0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]")]
      List<uint> IDAT_PMAXLIM { get; set; }

      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("[24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24]")]
      List<uint> IDAT_PCOUNT { get; set; }
     
   }
}
