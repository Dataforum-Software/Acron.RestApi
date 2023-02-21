using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface IDayData
   {
      [SwaggerSchema("Id of process value")]
      [SwaggerExampleValue("302000003")]
      uint PVID { get; set; }

      [SwaggerSchema("Name of process value")]
      [SwaggerExampleValue("Zulauf")]
      string ShortName { get; set; }

      //Bit 0 : DDAT_TIME Wird nicht gesetzt, hat nur in der alten Welt bedeutung - Array ist nicht vorhanden

      //Bit 1 : DDAT_FLAG
      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("[{}, {}, {}]")]
      List<IDayDataFlag> DDAT_FLAG { get; set; }

      //Bit 2 : DDAT_DVAL
      [SwaggerSchema("Daily value")]
      [SwaggerExampleValue("[23932.0, 26364.0, 26972.0]")]
      List<double> DDAT_DVAL { get; set; }

      //ToDo Swagger
      public List<string> DDAT_DVAL_FORMATTED { get; set; }

      //Bit 3 : DDAT_DVALAVG
      [SwaggerSchema("Daily value of process value")]
      [SwaggerExampleValue("[21466.0, 21311.5, 21788.75, 22204.25]")]
      List<float> DDAT_DVALAVG { get; set; }

      //ToDo Swagger
      List<string> DDAT_DVALAVG_FORMATTED { get; set; }

      //Bit 4 : DDAT_DVALTM
      [SwaggerSchema("Time of daily value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\"]")]
      List<DateTime> DDAT_DVALTM { get; set; }

      //ToDo Swagger
      List<string> DDAT_DVALTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> DDAT_DVALTM_TIMEZONE { get; set; }

      //Bit 5 : DDAT_PSUM
      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("[23932.0, 26364.0, 26972.0]")]
      List<double> DDAT_PSUM { get; set; }

      //ToDo Swagger
      public List<string> DDAT_PSUM_FORMATTED { get; set; }

      //Bit 7 : DDAT_PMINTM
      [SwaggerSchema("Time of minimum provess value")]
      [SwaggerExampleValue("[\"2022-10-10T01:29:59Z\", \"2022-10-11T19:44:59Z\", \"2022-10-11T22:29:59Z\"]")]
      List<DateTime> DDAT_PMINTM { get; set; }

      //ToDo Swagger
      List<string> DDAT_PMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> DDAT_PMINTM_TIMEZONE { get; set; }

      //Bit 6 : DDAT_PMIN
      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("[73.0, 78.0, 79.0]")]
      List<double> DDAT_PMIN { get; set; }

      //ToDo Swagger
      List<string> DDAT_PMIN_FORMATTED { get; set; }

      //Bit 9 : DDAT_PMAXTM
      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("[\"2022-10-10T21:44:59Z\", \"2022-10-11T04:14:59Z\", \"2022-10-12T11:14:59Z\"]")]
      List<DateTime> DDAT_PMAXTM { get; set; }

      //ToDo Swagger
      List<string> DDAT_PMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> DDAT_PMAXTM_TIMEZONE { get; set; }

      //Bit 8 : DDAT_PMAX
      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("[94.0, 98.0, 100.0]")]
      List<double> DDAT_PMAX { get; set; }

      //ToDo Swagger
      List<string> DDAT_PMAX_FORMATTED { get; set; }

      //Bit 10 : DDAT_PMINLIM
      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("[0, 0, 0]")]
      List<uint> DDAT_PMINLIM { get; set; }

      //Bit 11 : DDAT_PMAXLIM
      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("[0, 0, 0]")]
      List<uint> DDAT_PMAXLIM { get; set; }

      //Bit 12 : DDAT_PCOUNT
      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("[288, 288, 288]")]
      List<uint> DDAT_PCOUNT { get; set; }

      //Bit 13 : DDAT_ISUM
      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue("[23932.0, 26364.0, 26972.0]")]
      List<double> DDAT_ISUM { get; set; }

      //ToDo Swagger
      List<string> DDAT_ISUM_FORMATTED { get; set; }

      //Bit 14 : DDAT_ISIGMA
      [SwaggerSchema("Standard deviation of process values")]
      [SwaggerExampleValue("[107.99949, 97.817856, 116.49487]")]
      List<float> DDAT_ISIGMA { get; set; }

      //ToDo Swagger
      List<string> DDAT_ISIGMA_FORMATTED { get; set; }

      //Bit 15 : DDAT_IPERC15
      [SwaggerSchema("Percentile value 15% of process values")]
      [SwaggerExampleValue("[1848.0, 2052.0, 2104.0]")]
      List<float> DDAT_IPERC15 { get; set; }

      //ToDo Swagger
      List<string> DDAT_IPERC15_FORMATTED { get; set; }

      //Bit 16 : DDAT_IPERC85
      [SwaggerSchema("Percentile value 85% of process values")]
      [SwaggerExampleValue("[2130.0, 2292.0, 2359.0]")]
      List<float> DDAT_IPERC85 { get; set; }

      //ToDo Swagger
      List<string> DDAT_IPERC85_FORMATTED { get; set; }

      //Bit 18 : DDAT_IMINTM
      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("[\"2022-10-10T00:00:00Z\", \"2022-10-11T20:00:00Z\", \"2022-10-11T22:00:00Z\"]")]
      List<DateTime> DDAT_IMINTM { get; set; }

      //ToDo Swagger
      List<string> DDAT_IMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> DDAT_IMINTM_TIMEZONE { get; set; }

      //Bit 17 : DDAT_IMIN
      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue("[1812.0, 1960.0, 1996.0]")]
      List<double> DDAT_IMIN { get; set; }

      //ToDo Swagger
      List<string> DDAT_IMIN_FORMATTED { get; set; }

      //Bit 20 : DDAT_IMAXTM
      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("[\"2022-10-10T20:00:00Z\", \"2022-10-11T04:00:00Z\", \"2022-10-12T20:00:00Z\"]")]
      List<DateTime> DDAT_IMAXTM { get; set; }
      
      //ToDo Swagger
      List<string> DDAT_IMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> DDAT_IMAXTM_TIMEZONE { get; set; }

      //Bit 19 : DDAT_IMAX
      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue("[2184.0, 2294.0, 2376.0]")]
      List<double> DDAT_IMAX { get; set; }

      //ToDo Swagger
      List<string> DDAT_IMAX_FORMATTED { get; set; }

      //Bit 21 : DDAT_IMINLIM
      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue("[0, 0, 0]")]
      List<uint> DDAT_IMINLIM { get; set; }

      //Bit 22 : DDAT_IMAXLIM
      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue("[12, 12, 12]")]
      List<uint> DDAT_IMAXLIM { get; set; }

      //Bit 23 : DDAT_ICOUNT
      [SwaggerSchema("Number of interval values")]
      [SwaggerExampleValue("[12, 12, 12]")]
      List<uint> DDAT_ICOUNT { get; set; }

   }
}
