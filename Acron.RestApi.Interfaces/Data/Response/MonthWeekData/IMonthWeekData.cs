using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.MonthWeekData
{
   public interface IMonthWeekData
   {
      [SwaggerSchema("Id process value")]
      [SwaggerExampleValue("302000003")]
      public uint PVID { get; set; }

      [SwaggerSchema("Name process value")]
      [SwaggerExampleValue("Zulauf")]
      public string ShortName { get; set; }

      //1	   MDAT_FLAG 	         byte	         Bitfeld mit Eigenschaften des Wertes
      //                                           Bit 0 gesetzt:  MDAT_ERSATZ    Ersatzwert eingestellt
      //                                           Bit 1 gesetzt:  MDAT_NOREL     Wert ist nicht freigegeben
      //                                           Bit 2 gesetzt:  MDAT_MISSING Wert ist nicht vorhanden
      //                                           Bit 6 gesetzt:  MDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      //                                           Bit 7 gesetzt:  MDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("[{}]")]
      public List<IMonthWeekDataFlag> MDAT_FLAG { get; set; }

      //2   	MDAT_MVAL	            double         	Wert
      [SwaggerSchema("Monthly value")]
      [SwaggerExampleValue("[179647.0]")]
      public List<double> MDAT_MVAL { get; set; }
      //ToDo Swagger
      public List<string> MDAT_MVAL_FORMATTED { get; set; }

      //3   	MDAT_MVALTM	         time_t	         Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of monthly value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> MDAT_MVALTM { get; set; }

      //ToDo Swagger
      List<string> MDAT_MVALTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_MVALTM_TIMEZONE { get; set; }

      //4	   MDAT_MVAL1	         double	         Wert
      [SwaggerSchema("Monthly value 1")]
      [SwaggerExampleValue("[1.1E+35]")]
      public List<float> MDAT_MVAL1 { get; set; }

      public List<string> MDAT_MVAL1_FORMATTED { get; set; }

      //5	   MDAT_MVAL1TM	         time_t	         Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of monthly value 1")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> MDAT_MVAL1TM { get; set; }

      //ToDo Swagger
      List<string> MDAT_MVAL1TM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_MVAL1TM_TIMEZONE { get; set; }

      //6	   MDAT_MVAL2	         double	         Wert
      [SwaggerSchema("Monthly value 2")]
      [SwaggerExampleValue("[1.1E+35]")]
      public List<float> MDAT_MVAL2 { get; set; }

      public List<string> MDAT_MVAL2_FORMATTED { get; set; }

      //7	   MDAT_MVAL2TM	         time_t	         Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of monthly value 2")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> MDAT_MVAL2TM { get; set; }

      //ToDo Swagger
      List<string> MDAT_MVAL2TM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_MVAL2TM_TIMEZONE { get; set; }

      //8	   MDAT_MVAL3	         double	         Wert
      [SwaggerSchema("Monthly value 3")]
      [SwaggerExampleValue("[1.1E+35]")]
      public List<float> MDAT_MVAL3 { get; set; }

      //ToDo Swagger
      public List<string> MDAT_MVAL3_FORMATTED { get; set; }

      //9	   MDAT_MVAL3TM	         time_t	         Zeitpunkt spezieller Stundenwert gemäß Kompression
      [SwaggerSchema("Time of monthly value 3")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> MDAT_MVAL3TM { get; set; }

      //ToDo Swagger
      List<string> MDAT_MVAL3TM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_MVAL3TM_TIMEZONE { get; set; }

      //10	MDAT_PSUM	            double	         Summe der Prozesswerte
      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("[179647.0]")]
      public List<double> MDAT_PSUM { get; set; }

      //ToDo Swagger
      public List<string> MDAT_PSUM_FORMATTED { get; set; }

      //12	MDAT_PMINTM	         TDBN_Time	      Zeitstempel des Minimas der Prozesswerte
      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("[\"2022-10-14T12:14:59Z\"]")]
      public List<DateTime> MDAT_PMINTM { get; set; }

      //ToDo Swagger
      List<string> MDAT_PMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_PMINTM_TIMEZONE { get; set; }

      //11	MDAT_PMIN	            double	         Minima der Prozesswerte
      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("[69.0]")]
      public List<double> MDAT_PMIN { get; set; }

      //ToDo Swagger
      public List<string> MDAT_PMIN_FORMATTED { get; set; }

      //14	MDAT_PMAXTM	         TDBN_Time	      Zeitstempel des Maximas der Prozesswerte
      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("[\"2022-10-12T11:14:59Z\"]")]
      public List<DateTime> MDAT_PMAXTM { get; set; }

      //ToDo Swagger
      List<string> MDAT_PMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_PMAXTM_TIMEZONE { get; set; }

      //13	MDAT_PMAX 	         double	         Maxima der Prozesswerte
      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("[100.0]")]
      public List<double> MDAT_PMAX { get; set; }

      //ToDo Swagger
      public List<string> MDAT_PMAX_FORMATTED { get; set; }

      //15	MDAT_PMINLIM	         unsigned	      Anzahl der Grenzwertunterschreitungen der Prozesswerte
      [SwaggerSchema("number of range limit shortfalls - process values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> MDAT_PMINLIM { get; set; }

      //16	MDAT_PMAXLIM	         unsigned	      Anzahl der Grenzwertüberschreitungen der Prozesswerte
      [SwaggerSchema("number of range limit exceedings - process values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> MDAT_PMAXLIM { get; set; }

      //17	MDAT_PCOUNT	         unsigned	      Anzahl der Prozesswerte
      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("[2016]")]
      public List<uint> MDAT_PCOUNT { get; set; }

      //18	MDAT_ISUM	            double	         Summe der Intervallwerte
      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue("[179647.0]")]
      public List<double> MDAT_ISUM { get; set; }

      //ToDo Swagger
      public List<string> MDAT_ISUM_FORMATTED { get; set; }

      //20	MDAT_IMINTM	         time_t	         Zeitstempel der Minimas der Intervallwerte
      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("[\"2022-10-14T10:00:00Z\"]")]
      public List<DateTime> MDAT_IMINTM { get; set; }

      //ToDo Swagger
      List<string> MDAT_IMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_IMINTM_TIMEZONE { get; set; }

      //19	MDAT_IMIN	            double	         Minima der Intervallwerte
      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue("[1734.0]")]
      public List<double> MDAT_IMIN { get; set; }

      //ToDo Swagger
      public List<string> MDAT_IMIN_FORMATTED { get; set; }

      //22	MDAT_IMAXTM	         time_t	         Zeitstempel der Maxima der Intervallwerte
      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("[\"2022-10-13T10:00:00Z\"]")]
      public List<DateTime> MDAT_IMAXTM { get; set; }

      //ToDo Swagger
      List<string> MDAT_IMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_IMAXTM_TIMEZONE { get; set; }

      //21	MDAT_IMAX 	         double	         Maxima der Intervallwerte
      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue("[2381.0]")]
      public List<double> MDAT_IMAX { get; set; }

      //ToDo Swagger
      public List<string> MDAT_IMAX_FORMATTED { get; set; }

      //23	MDAT_IMINLIM	         unsigned	      Anzahl der Grenzwertunterschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> MDAT_IMINLIM { get; set; }

      //24	MDAT_IMAXLIM	         unsigned	      Anzahl der Grenzwertüberschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue("[84]")]
      public List<uint> MDAT_IMAXLIM { get; set; }

      //25	MDAT_ICOUNT	         unsigned	      Anzahl der Intervallwerte im Tag
      [SwaggerSchema("number of interval values")]
      [SwaggerExampleValue("[84]")]
      public List<uint> MDAT_ICOUNT { get; set; }

      //26	MDAT_DSUM	            double         	Summe der Tageswerte
      [SwaggerSchema("Sum of daily values")]
      [SwaggerExampleValue("[179647.0]")]
      public List<double> MDAT_DSUM { get; set; }

      //ToDo Swagger
      public List<string> MDAT_DSUM_FORMATTED { get; set; }

      //27	MDAT_DSIGMA	         float	         Standardabweichung der Tageswerte
      [SwaggerSchema("Standard deviation of daily values")]
      [SwaggerExampleValue("[1358.6782]")]
      public List<float> MDAT_DSIGMA { get; set; }

      //ToDo Swagger
      public List<string> MDAT_DSIGMA_FORMATTED { get; set; }

      //28	MDAT_DPERC15	         float	         Percentilwert 15 % der Tageswerte
      [SwaggerSchema("Percentile value 15% of daily values")]
      [SwaggerExampleValue("[23932.0]")]
      public List<float> MDAT_DPERC15 { get; set; }

      //ToDo Swagger
      public List<string> MDAT_DPERC15_FORMATTED { get; set; }

      //29	MDAT_DPERC85	         float	         Percentilwert 85 % der Tageswerte
      [SwaggerSchema("Percentile value 85% of daily values")]
      [SwaggerExampleValue("[26972.0]")]
      public List<float> MDAT_DPERC85 { get; set; }

      public List<string> MDAT_DPERC85_FORMATTED { get; set; }

      //31	MDAT_DMINTM	         time_t	         Zeitstempel der Minimas der Tageswerte
      [SwaggerSchema("Time of minimum daily value")]
      [SwaggerExampleValue("[\"2022-10-13T22:00:00Z\"]")]
      public List<DateTime> MDAT_DMINTM { get; set; }

      //ToDo Swagger
      List<string> MDAT_DMINTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_DMINTM_TIMEZONE { get; set; }

      //30	MDAT_DMIN	            double	         Minima der Tageswerte
      [SwaggerSchema("Minimum daily value")]
      [SwaggerExampleValue("[23324.0]")]
      public List<double> MDAT_DMIN { get; set; }

      //ToDo Swagger
      public List<string> MDAT_DMIN_FORMATTED { get; set; }

      //33	MDAT_DMAXTM	         time_t	         Zeitstempel der Maxima der Tageswerte
      [SwaggerSchema("Time of maximum daily value")]
      [SwaggerExampleValue("[\"2022-10-12T22:00:00Z\"]")]
      public List<DateTime> MDAT_DMAXTM { get; set; }

      //ToDo Swagger
      List<string> MDAT_DMAXTM_FORMATTED { get; set; }

      //ToDo Swagger
      List<DateTime> MDAT_DMAXTM_TIMEZONE { get; set; }

      //32	MDAT_DMAX 	         double	         Maxima der Tageswerte
      [SwaggerSchema("Maximum daily value")]
      [SwaggerExampleValue("[27093.0]")]
      public List<double> MDAT_DMAX { get; set; }

      //ToDo Swagger
      public List<string> MDAT_DMAX_FORMATTED { get; set; }

      //34	MDAT_DMINLIM	         unsigned	      Anzahl der Grenzwertunterschreitungen der Tageswerte
      [SwaggerSchema("Number of range limit shortfalls - daily values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> MDAT_DMINLIM { get; set; }

      //35	MDAT_DMAXLIM	         unsigned	      Anzahl der Grenzwertüberschreitungen der Tageswerte
      [SwaggerSchema("Number of range limit exceedings - daily values")]
      [SwaggerExampleValue("[7]")]
      public List<uint> MDAT_DMAXLIM { get; set; }

      //36	MDAT_DCOUNT	         unsigned	      Anzahl der Tageswerte
      [SwaggerSchema("Number of daily values")]
      [SwaggerExampleValue("[7]")]
      public List<uint> MDAT_DCOUNT { get; set; }

   }
}
