using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.YearData
{
   public interface IYearData
   {
      [SwaggerSchema("Numeric ID of process variable")]
      [SwaggerExampleValue("302000003")]
      public uint PVID { get; set; }

      [SwaggerSchema("Identification of process variable")]
      [SwaggerExampleValue("Zulauf")]
      public string ShortName { get; set; }

      //1	   YDAT_FLAG         byte	      Bitfeld mit Eigenschaften des Wertes
      //                                    Bit 0 gesetzt:  YDAT_ERSATZ    Ersatzwert eingestellt
      //                                    Bit 1 gesetzt:  YDAT_NOREL     Wert ist nicht freigegeben
      //                                    Bit 2 gesetzt:  YDAT_MISSING  Wert ist nicht vorhanden
      //                                    Bit 6 gesetzt:  YDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      //                                    Bit 7 gesetzt:  YDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("[{}]")]
      public List<IYearDataFlag> YDAT_FLAG { get; set; }

      //2   	YDAT_YVAL	         double      Wert
      [SwaggerSchema("Annual value")]
      [SwaggerExampleValue("[5114232.0]")]
      public List<double> YDAT_YVAL { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVAL)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"5.114.232,0\"]")]
      public List<string> YDAT_YVAL_FORMATTED { get; set; }

      //3	   YDAT_YVALTM	      time_t	      Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of annual value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> YDAT_YVALTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVALTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\"]")]
      public List<string> YDAT_YVALTM_FORMATTED { get; set; }

      //4	   YDAT_YVAL1	      float	      Wert
      [SwaggerSchema("Second special annual value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue("[1.1E+35]")]
      public List<float> YDAT_YVAL1 { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVAL1)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"1,1E+35\"]")]
      public List<string> YDAT_YVAL1_FORMATTED { get; set; }

      //5	   YDAT_YVAL1TM      	time_t	      Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of second special annual value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> YDAT_YVAL1TM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVAL1TM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\"]")]
      public List<string> YDAT_YVAL1TM_FORMATTED { get; set; }

      //6	   YDAT_YVAL2	      float	      Wert
      [SwaggerSchema("Third special annual value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue("[1.1E+35]")]
      public List<float> YDAT_YVAL2 { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVAL2)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"1,1E+35\"]")]
      public List<string> YDAT_YVAL2_FORMATTED { get; set; }

      //7	   YDAT_YVAL2TM	      time_t	      Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of third special annual value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> YDAT_YVAL2TM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVAL2TM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\"]")]
      public List<string> YDAT_YVAL2TM_FORMATTED { get; set; }

      //8	   YDAT_YVAL3	      float	      Wert
      [SwaggerSchema("Fourth special annual value according to compression type (e.g. '4 highest values')")]
      [SwaggerExampleValue("[1.1E+35]")]
      public List<float> YDAT_YVAL3 { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVAL3)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"1,1E+35\"]")]
      public List<string> YDAT_YVAL3_FORMATTED { get; set; }

      //9	   YDAT_YVAL3TM	      time_t	      Zeitpunkt spezieller Stundenwert gemäß Kompression
      [SwaggerSchema("Time of fourth special annual value")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\"]")]
      public List<DateTime> YDAT_YVAL3TM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_YVAL3TM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\"]")]
      public List<string> YDAT_YVAL3TM_FORMATTED { get; set; }

      //10	YDAT_PSUM	         double	      Summe der Prozesswerte
      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("[5114232.0]")]
      public List<double> YDAT_PSUM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_PSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"5.114.232,0\"]")]
      public List<string> YDAT_PSUM_FORMATTED { get; set; }

      //12	YDAT_PMINTM	      TDBN_Time	   Zeitstempel des Minimas der Prozesswerte
      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("[\"2022-01-04T17:39:59Z\"]")]
      public List<DateTime> YDAT_PMINTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_PMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.04.2022 17:39:59\"]")]
      public List<string> YDAT_PMINTM_FORMATTED { get; set; }

      //11	YDAT_PMIN	         double	      Minima der Prozesswerte
      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("[0.0]")]
      public List<double> YDAT_PMIN { get; set; }

      [SwaggerSchema($"{nameof(YDAT_PMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"0,0\"]")]
      public List<string> YDAT_PMIN_FORMATTED { get; set; }

      //14	YDAT_PMAXTM	      TDBN_Time	   Zeitstempel des Maximas der Prozesswerte
      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("[\"2022-01-13T22:14:59Z\"]")]
      public List<DateTime> YDAT_PMAXTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_PMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"13.01.2022 22:14:59\"]")]
      public List<string> YDAT_PMAXTM_FORMATTED { get; set; }

      //13	YDAT_PMAX 	      double	      Maxima der Prozesswerte
      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("[100.0]")]
      public List<double> YDAT_PMAX { get; set; }

      [SwaggerSchema($"{nameof(YDAT_PMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"100,0\"]")]
      public List<string> YDAT_PMAX_FORMATTED { get; set; }

      //15	YDAT_PMINLIM      	unsigned	   Anzahl der Grenzwertunterschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> YDAT_PMINLIM { get; set; }

      //16	YDAT_PMAXLIM      	unsigned	   Anzahl der Grenzwertüberschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> YDAT_PMAXLIM { get; set; }

      //17	YDAT_PCOUNT	      unsigned	   Anzahl der Prozesswerte
      [SwaggerSchema("Number of process value")]
      [SwaggerExampleValue("[98083]")]
      public List<uint> YDAT_PCOUNT { get; set; }

      //18	YDAT_ISUM	         double	      Summe der Intervallwerte
      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue("[5114232.0]")]
      public List<double> YDAT_ISUM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_ISUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"5.114.232,0\"]")]
      public List<string> YDAT_ISUM_FORMATTED { get; set; }

      //20	YDAT_IMINTM	      time_t	      Zeitstempel der Minimas der Intervallwerte
      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("[\"2022-11-22T09:00:00Z\"]")]
      public List<DateTime> YDAT_IMINTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_IMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"22.11.2022 09:00:00\"]")]
      public List<string> YDAT_IMINTM_FORMATTED { get; set; }

      //19	YDAT_IMIN	         double	      Minima der Intervallwerte
      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue("[12.0]")]
      public List<double> YDAT_IMIN { get; set; }

      [SwaggerSchema($"{nameof(YDAT_IMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"12,0\"]")]
      public List<string> YDAT_IMIN_FORMATTED { get; set; }

      //22	YDAT_IMAXTM	      time_t	      Zeitstempel der Maxima der Intervallwerte
      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("[\"2022-04-06T10:00:00Z\"]")]
      public List<DateTime> YDAT_IMAXTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_IMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"06.04.2022 10:00:00\"]")]
      public List<string> YDAT_IMAXTM_FORMATTED { get; set; }

      //21	YDAT_IMAX 	      double	      Maxima der Intervallwerte
      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue("[2395.0]")]
      public List<double> YDAT_IMAX { get; set; }

      [SwaggerSchema($"{nameof(YDAT_IMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"2.395,0\"]")]
      public List<string> YDAT_IMAX_FORMATTED { get; set; }

      //23	YDAT_IMINLIM	      unsigned	   Anzahl der Grenzwertunterschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> YDAT_IMINLIM { get; set; }

      //24	YDAT_IMAXLIM	      unsigned	   Anzahl der Grenzwertüberschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue("[2568]")]
      public List<uint> YDAT_IMAXLIM { get; set; }

      //25	YDAT_ICOUNT	      unsigned	   Anzahl der Intervallwerte im Tag
      [SwaggerSchema("Number of interval values")]
      [SwaggerExampleValue("[4087]")]
      public List<uint> YDAT_ICOUNT { get; set; }

      //26	YDAT_DSUM	         double	      Summe der Tageswerte
      [SwaggerSchema("Sum of daily values")]
      [SwaggerExampleValue("[5114232.0]")]
      public List<double> YDAT_DSUM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_DSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"5.114.232,0\"]")]
      public List<string> YDAT_DSUM_FORMATTED { get; set; }

      //28	YDAT_DMINTM	      time_t	      Zeitstempel der Minimas der Tageswerte
      [SwaggerSchema("Time of minimum daily value")]
      [SwaggerExampleValue("[\"2022-02-26T23:00:00Z\"]")]
      public List<DateTime> YDAT_DMINTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_DMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"26.02.2022 23:00:00\"]")]
      public List<string> YDAT_DMINTM_FORMATTED { get; set; }

      //27	YDAT_DMIN	         double	      Minima der Tageswerte
      [SwaggerSchema("Minimum daily value")]
      [SwaggerExampleValue("[772.0]")]
      public List<double> YDAT_DMIN { get; set; }

      [SwaggerSchema($"{nameof(YDAT_DMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"772,0\"]")]
      public List<string> YDAT_DMIN_FORMATTED { get; set; }

      //30	YDAT_DMAXTM	      time_t	      Zeitstempel der Maxima der Tageswerte
      [SwaggerSchema("Time of maximum daily value")]
      [SwaggerExampleValue("[\"2022-03-31T22:00:00Z\"]")]
      public List<DateTime> YDAT_DMAXTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_DMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"31.03.2022 22:00:00\"]")]
      public List<string> YDAT_DMAXTM_FORMATTED { get; set; }

      //29	YDAT_DMAX 	      double	      Maxima der Tageswerte
      [SwaggerSchema("Maximum daily value")]
      [SwaggerExampleValue("[27935.0]")]
      public List<double> YDAT_DMAX { get; set; }

      [SwaggerSchema($"{nameof(YDAT_DMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"27.935,0\"]")]
      public List<string> YDAT_DMAX_FORMATTED { get; set; }

      //31	YDAT_DMINLIM	      unsigned	   Anzahl der Grenzwertunterschreitungen der Tageswerte
      [SwaggerSchema("Number of range limit shortfalls - daily values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> YDAT_DMINLIM { get; set; }

      //32	YDAT_DMAXLIM	      unsigned	   Anzahl der Grenzwertüberschreitungen der Tageswerte
      [SwaggerSchema("Number of range limit exceedings - daily values")]
      [SwaggerExampleValue("[339]")]
      public List<uint> YDAT_DMAXLIM { get; set; }

      //33	YDAT_DCOUNT	      unsigned	   Anzahl der Tageswerte
      [SwaggerSchema("Number of daily values")]
      [SwaggerExampleValue("[341]")]
      public List<uint> YDAT_DCOUNT { get; set; }

      //34	YDAT_MSUM	         double	      Summe der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Sum of monthly/weekly values")]
      [SwaggerExampleValue("[5114232.0]")]
      public List<double> YDAT_MSUM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MSUM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"5.114.232,0\"]")]
      public List<string> YDAT_MSUM_FORMATTED { get; set; }

      //35	YDAT_MSIGMA	      float	      Standardabweichung der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Standard deviation of monthly/weekly values")]
      [SwaggerExampleValue("[51584.49]")]
      public List<float> YDAT_MSIGMA { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MSIGMA)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"51.584,49\"]")]
      public List<string> YDAT_MSIGMA_FORMATTED { get; set; }

      //36	YDAT_MPERC15	      float	      Percentilwert 15 % der Wochenwerte bzw Monatswerte
      [SwaggerSchema("15th percentile of monthly/weekly values")]
      [SwaggerExampleValue("[37702.0]")]
      public List<float> YDAT_MPERC15 { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MPERC15)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"37.702,0\"]")]
      public List<string> YDAT_MPERC15_FORMATTED { get; set; }

      //37	YDAT_MPERC85	      float	      Percentilwert 85 % der Wochenwerte bzw Monatswerte
      [SwaggerSchema("85th percentile of monthly/weekly values")]
      [SwaggerExampleValue("[159570.0]")]
      public List<float> YDAT_MPERC85 { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MPERC85)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"159.570,0\"]")]
      public List<string> YDAT_MPERC85_FORMATTED { get; set; }

      //39	YDAT_MMINTM	      time_t	      Zeitstempel der Minimas der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Time of minimum monthly/weekly value")]
      [SwaggerExampleValue("[\"2022-12-04T23:00:00Z\"]")]
      public List<DateTime> YDAT_MMINTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MMINTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"04.12.2022 23:00:00\"]")]
      public List<string> YDAT_MMINTM_FORMATTED { get; set; }

      //38	YDAT_MMIN	         double	      Minima der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Minimum monthly/weekly value")]
      [SwaggerExampleValue("[12675.0]")]
      public List<double> YDAT_MMIN { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MMIN)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"12.675,0\"]")]
      public List<string> YDAT_MMIN_FORMATTED { get; set; }

      //41	YDAT_MMAXTM	      time_t	      Zeitstempel der Maxima der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Time of maximum monthly/weekly value")]
      [SwaggerExampleValue("[\"2022-10-16T22:00:00Z\"]")]
      public List<DateTime> YDAT_MMAXTM { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MMAXTM)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"16.10.2022 22:00:00\"]")]
      public List<string> YDAT_MMAXTM_FORMATTED { get; set; }

      //40	YDAT_MMAX 	      double	      Maxima der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Maximum monthly/weekly value")]
      [SwaggerExampleValue("[186373.0]")]
      public List<double> YDAT_MMAX { get; set; }

      [SwaggerSchema($"{nameof(YDAT_MMAX)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"186.373,0\"]")]
      public List<string> YDAT_MMAX_FORMATTED { get; set; }

      //42	YDAT_MMINLIM	      unsigned	   Anzahl der Grenzwertunterschreitungen der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Number of range limit shortfalls - monthly/weekly values")]
      [SwaggerExampleValue("[0]")]
      public List<uint> YDAT_MMINLIM { get; set; }

      //43	YDAT_MMAXLIM	      unsigned	   Anzahl der Grenzwertüberschreitungen der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Number of range limit exceedings - monthly/weekly values")]
      [SwaggerExampleValue("[49]")]
      public List<uint> YDAT_MMAXLIM { get; set; }

      //44	YDAT_MCOUNT	      unsigned	   Anzahl der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Number of monthly/weekly values")]
      [SwaggerExampleValue("[49]")]
      public List<uint> YDAT_MCOUNT { get; set; }

   }
}
