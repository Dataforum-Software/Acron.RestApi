using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.MonthWeekData
{
   public interface IMonthWeekWhat
   {
      //1	   MDAT_FLAG 	         byte	         Bitfeld mit Eigenschaften des Wertes
      //                                           Bit 0 gesetzt:  MDAT_ERSATZ    Ersatzwert eingestellt
      //                                           Bit 1 gesetzt:  MDAT_NOREL     Wert ist nicht freigegeben
      //                                           Bit 2 gesetzt:  MDAT_MISSING Wert ist nicht vorhanden

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_FLAG { get; set; }

      //2   	MDAT_MVAL	            double         	Wert
      [SwaggerSchema("Monthly value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVAL { get; set; }

      //3   	MDAT_MVALTM	         time_t	         Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of monthly value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVALTM { get; set; }

      //4	   MDAT_MVAL1	         double	         Wert
      [SwaggerSchema("Monthly value 1")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVAL1 { get; set; }

      //5	   MDAT_MVAL1TM	         time_t	         Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of monthly value 1")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVAL1TM { get; set; }

      //6	   MDAT_MVAL2	         double	         Wert
      [SwaggerSchema("Monthly value 2")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVAL2 { get; set; }

      //7	   MDAT_MVAL2TM	         time_t	         Zeitpunkt spezieller Wert gemäß Kompression
      [SwaggerSchema("Time of monthly value 2")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVAL2TM { get; set; }

      //8	   MDAT_MVAL3	         double	         Wert
      [SwaggerSchema("Monthly value 3")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVAL3 { get; set; }

      //9	   MDAT_MVAL3TM	         time_t	         Zeitpunkt spezieller Stundenwert gemäß Kompression
      [SwaggerSchema("Time of monthly value 3")]
      [SwaggerExampleValue("true")]
      public bool MDAT_MVAL3TM { get; set; }

      //10	MDAT_PSUM	            double	         Summe der Prozesswerte
      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PSUM { get; set; }

      //12	MDAT_PMINTM	         TDBN_Time	      Zeitstempel des Minimas der Prozesswerte
      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PMINTM { get; set; }

      //11	MDAT_PMIN	            double	         Minima der Prozesswerte
      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PMIN { get; set; }

      //14	MDAT_PMAXTM	         TDBN_Time	      Zeitstempel des Maximas der Prozesswerte
      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PMAXTM { get; set; }

      //13	MDAT_PMAX 	         double	         Maxima der Prozesswerte
      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PMAX { get; set; }

      //15	MDAT_PMINLIM	         unsigned	      Anzahl der Grenzwertunterschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PMINLIM { get; set; }

      //16	MDAT_PMAXLIM	         unsigned	      Anzahl der Grenzwertüberschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PMAXLIM { get; set; }

      //17	MDAT_PCOUNT	         unsigned	      Anzahl der Prozesswerte
      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_PCOUNT { get; set; }

      //18	MDAT_ISUM	            double	         Summe der Intervallwerte
      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_ISUM { get; set; }

      //20	MDAT_IMINTM	         time_t	         Zeitstempel der Minimas der Intervallwerte
      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_IMINTM { get; set; }

      //19	MDAT_IMIN	            double	         Minima der Intervallwerte
      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_IMIN { get; set; }

      //22	MDAT_IMAXTM	         time_t	         Zeitstempel der Maxima der Intervallwerte
      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_IMAXTM { get; set; }

      //21	MDAT_IMAX 	         double	         Maxima der Intervallwerte
      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_IMAX { get; set; }

      //23	MDAT_IMINLIM	         unsigned	      Anzahl der Grenzwertunterschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_IMINLIM { get; set; }

      //24	MDAT_IMAXLIM	         unsigned	      Anzahl der Grenzwertüberschreitungen der Intervallwerte
      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_IMAXLIM { get; set; }

      //25	MDAT_ICOUNT	         unsigned	      Anzahl der Intervallwerte im Tag
      [SwaggerSchema("Number of interval values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_ICOUNT { get; set; }

      //26	MDAT_DSUM	            double         	Summe der Tageswerte
      [SwaggerSchema("Sum of daily values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DSUM { get; set; }

      //27	MDAT_DSIGMA	         float	         Standardabweichung der Tageswerte
      [SwaggerSchema("Standard deviation of daily values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DSIGMA { get; set; }

      //28	MDAT_DPERC15	         float	         Percentilwert 15 % der Tageswerte
      [SwaggerSchema("Percentile value 15% of daily values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DPERC15 { get; set; }

      //29	MDAT_DPERC85	         float	         Percentilwert 85 % der Tageswerte
      [SwaggerSchema("Percentile value 85% of daily values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DPERC85 { get; set; }

      //31	MDAT_DMINTM	         time_t	         Zeitstempel der Minimas der Tageswerte
      [SwaggerSchema("Time of minimum daily value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DMINTM { get; set; }

      //30	MDAT_DMIN	            double	         Minima der Tageswerte
      [SwaggerSchema("Minimum daily value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DMIN { get; set; }

      //33	MDAT_DMAXTM	         time_t	         Zeitstempel der Maxima der Tageswerte
      [SwaggerSchema("Time of maximum daily value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DMAXTM { get; set; }

      //32	MDAT_DMAX 	         double	         Maxima der Tageswerte
      [SwaggerSchema("Maximum daily value")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DMAX { get; set; }

      //34	MDAT_DMINLIM	         unsigned	      Anzahl der Grenzwertunterschreitungen der Tageswerte
      [SwaggerSchema("Number of range limit shortfalls - daily values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DMINLIM { get; set; }

      //35	MDAT_DMAXLIM	         unsigned	      Anzahl der Grenzwertüberschreitungen der Tageswerte
      [SwaggerSchema("Number of range limit exceedings - daily values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DMAXLIM { get; set; }

      //36	MDAT_DCOUNT	         unsigned	      Anzahl der Tageswerte
      [SwaggerSchema("Number of daily values")]
      [SwaggerExampleValue("true")]
      public bool MDAT_DCOUNT { get; set; }
   }
}
