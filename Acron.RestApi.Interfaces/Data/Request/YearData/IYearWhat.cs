using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.YearData
{
   public interface IYearWhat
   {
      //1   	YDAT_FLAG         byte	      Bitfeld mit Eigenschaften des Wertes
      //                                     Bit 0 gesetzt:  YDAT_ERSATZ    Ersatzwert eingestellt
      //                                     Bit 1 gesetzt:  YDAT_NOREL     Wert ist nicht freigegeben
      //                                     Bit 2 gesetzt:  YDAT_MISSING  Wert ist nicht vorhanden
      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_FLAG { get; set; }

      //2	   YDAT_YVAL	         double      Wert
      [SwaggerSchema("Annual value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVAL { get; set; }

      //3	   YDAT_YVALTM	      time_t	      Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of annual value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVALTM { get; set; }

      //4	   YDAT_YVAL1	      double	      Wert
      [SwaggerSchema("Annual value 1")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVAL1 { get; set; }

      //5	   YDAT_YVAL1TM      	time_t	      Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of annual value 1")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVAL1TM { get; set; }

      //6	   YDAT_YVAL2	      double	      Wert
      [SwaggerSchema("Annual value 2")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVAL2 { get; set; }

      //7	   YDAT_YVAL2TM	      time_t	      Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of annual value 2")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVAL2TM { get; set; }

      //8	   YDAT_YVAL3	      double	      Wert
      [SwaggerSchema("Annual value 3")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVAL3 { get; set; }

      //9	   YDAT_YVAL3TM	      time_t	      Zeitpunkt spezieller Stundenwert gemäß Kompression
      [SwaggerSchema("Time of annual value 3")]
      [SwaggerExampleValue("true")]
      public bool YDAT_YVAL3TM { get; set; }

      //10	YDAT_PSUM	      double	      Summe der Prozesswerte
      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PSUM { get; set; }

      //12	YDAT_PMINTM	   TDBN_Time	   Zeitstempel des Minimas der Prozesswerte
      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PMINTM { get; set; }

      //11	YDAT_PMIN	      double	      Minima der Prozesswerte
      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PMIN { get; set; }

      //14	YDAT_PMAXTM	   TDBN_Time	   Zeitstempel des Maximas der Prozesswerte
      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PMAXTM { get; set; }

      //13	YDAT_PMAX 	   double	      Maxima der Prozesswerte
      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PMAX { get; set; }

      //15	YDAT_PMINLIM   	unsigned	   Anzahl der Grenzwertunterschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PMINLIM { get; set; }

      //16	YDAT_PMAXLIM   	unsigned	   Anzahl der Grenzwertüberschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PMAXLIM { get; set; }

      //17	YDAT_PCOUNT	   unsigned	   Anzahl der Prozesswerte
      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_PCOUNT { get; set; }

      //18	YDAT_ISUM	      double	      Summe der Intervallwerte
      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_ISUM { get; set; }

      //20	YDAT_IMINTM	   time_t	      Zeitstempel der Minimas der Intervallwerte
      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_IMINTM { get; set; }

      //19	YDAT_IMIN	      double	      Minima der Intervallwerte
      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_IMIN { get; set; }

      //22	YDAT_IMAXTM	   time_t	      Zeitstempel der Maxima der Intervallwerte
      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_IMAXTM { get; set; }

      //21	YDAT_IMAX 	   double	      Maxima der Intervallwerte
      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_IMAX { get; set; }

      //23	YDAT_IMINLIM	   unsigned	   Anzahl der Grenzwertunterschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_IMINLIM { get; set; }

      //24	YDAT_IMAXLIM	   unsigned	   Anzahl der Grenzwertüberschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_IMAXLIM { get; set; }

      //25	YDAT_ICOUNT	   unsigned	   Anzahl der Intervallwerte im Tag
      [SwaggerSchema("Number of interval values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_ICOUNT { get; set; }

      //26	YDAT_DSUM	      double	      Summe der Tageswerte
      [SwaggerSchema("Sum of daily values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DSUM { get; set; }

      //28	YDAT_DMINTM	   time_t	      Zeitstempel der Minimas der Tageswerte
      [SwaggerSchema("Time of minimum daily value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DMINTM { get; set; }

      //27	YDAT_DMIN	      double	      Minima der Tageswerte
      [SwaggerSchema("Minimum daily value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DMIN { get; set; }

      //30	YDAT_DMAXTM	   time_t	      Zeitstempel der Maxima der Tageswerte
      [SwaggerSchema("Time of maximum daily value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DMAXTM { get; set; }

      //29	YDAT_DMAX 	   double	      Maxima der Tageswerte
      [SwaggerSchema("Maximum daily value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DMAX { get; set; }

      //31	YDAT_DMINLIM	   unsigned	   Anzahl der Grenzwertunterschreitungen der Tageswerte
      [SwaggerSchema("Number of range shortfalls - daily values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DMINLIM { get; set; }

      //32	YDAT_DMAXLIM	   unsigned	   Anzahl der Grenzwertüberschreitungen der Tageswerte
      [SwaggerSchema("Number of range exceedings - daily values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DMAXLIM { get; set; }

      //33	YDAT_DCOUNT	   unsigned	   Anzahl der Tageswerte
      [SwaggerSchema("Number of daily values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_DCOUNT { get; set; }

      //34	YDAT_MSUM	      double	      Summe der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Sum of monthly/weekly values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MSUM { get; set; }

      //35	YDAT_MSIGMA	   float	      Standardabweichung der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Standard deviation of monthly/weekly values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MSIGMA { get; set; }

      //36	YDAT_MPERC15	   float	      Percentilwert 15 % der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Percentile value 15% of monthly/weekly values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MPERC15 { get; set; }

      //37	YDAT_MPERC85	   float	      Percentilwert 85 % der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Percentile value 85% of monthly/weekly values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MPERC85 { get; set; }

      //39	YDAT_MMINTM	   time_t	      Zeitstempel der Minimas der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Time of minimum monthly/weekly value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MMINTM { get; set; }

      //38	YDAT_MMIN	      double	      Minima der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Minimum monthly/weekly value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MMIN { get; set; }

      //41	YDAT_MMAXTM	   time_t	      Zeitstempel der Maxima der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Time of maximum monthly/weekly value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MMAXTM { get; set; }

      //40	YDAT_MMAX 	   double	      Maxima der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Maximum monthly/weekly value")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MMAX { get; set; }

      //42	YDAT_MMINLIM	   unsigned	   Anzahl der Grenzwertunterschreitungen der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Number of range limit shortfalls - monthly/weekly values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MMINLIM { get; set; }

      //43	YDAT_MMAXLIM	   unsigned	   Anzahl der Grenzwertüberschreitungen der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Number of range limit exceedings - monthly/weekly values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MMAXLIM { get; set; }

      //44	YDAT_MCOUNT	   unsigned	   Anzahl der Wochenwerte bzw Monatswerte
      [SwaggerSchema("Number of monthly/weekly values")]
      [SwaggerExampleValue("true")]
      public bool YDAT_MCOUNT { get; set; }

   }
}
