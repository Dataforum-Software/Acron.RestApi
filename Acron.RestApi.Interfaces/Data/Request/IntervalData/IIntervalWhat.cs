using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.IntervalData
{
   public interface IIntervalWhat
   {
      //0
      //Daten Typ im Ergebnis: time_t
      //Bit nicht setzen, hat nur in der alten Welt Bedeutung
      //bool IDAT_TIME { get; set; }

      //1
      //Daten Typ im Ergebnis: byte
      //Bitfeld mit Eigenschaften des Wertes
      //Bit 0 gesetzt:  IDAT_ERSATZ Ersatzwert eingestellt
      //Bit 1 gesetzt:  IDAT_OVER Manuell Überschriebener Wert
      //Bit 2 gesetzt:  IDAT_LESS Wert ist kleiner als unterer Grenzwert
      //Bit 3 gesetzt:  IDAT_GREATER Wert ist größer als oberer Grenzwert
      //Bit 4 gesetzt:  IDAT_MISSING Wert ist nicht vorhanden
      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("true")]
      bool IDAT_FLAG { get; set; }

      //2
      //Daten Typ im Ergebnis: double
      //Wert
      [SwaggerSchema("Interval value")]
      [SwaggerExampleValue("true")]
      bool IDAT_IVAL { get; set; }

      //3
      //Daten Typ im Ergebnis: double
      //Summe der Prozesswerte
      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("true")]
      bool IDAT_PSUM { get; set; }

      //4
      //Daten Typ im Ergebnis: float
      //Standardabweichung der Prozesswerte
      [SwaggerSchema("Standard deviation of process values")]
      [SwaggerExampleValue("true")]
      bool IDAT_PSIGMA { get; set; }

      //5
      //Daten Typ im Ergebnis: float
      //Percentilwert 15 % der Prozesswerte
      [SwaggerSchema("Percentile value 15% of process values")]
      [SwaggerExampleValue("true")]
      bool IDAT_PPERC15 { get; set; }

      //6
      //Daten Typ im Ergebnis: float
      //Percentilwert 85 % der Prozesswerte
      [SwaggerSchema("Percentile value 85% of process values")]
      [SwaggerExampleValue("true")]
      bool IDAT_PPERC85 { get; set; }

      //7
      //Daten Typ im Ergebnis: double
      //Minima der Prozesswerte
      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("true")]
      bool IDAT_PMIN { get; set; }

      //8
      //Daten Typ im Ergebnis: TDBN_Time
      //Zeitstempel des Minimas der Prozesswerte
      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("true")]
      bool IDAT_PMINTM { get; set; }

      //9
      //Daten Typ im Ergebnis: double
      //Maxima der Prozesswerte
      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("true")]
      bool IDAT_PMAX { get; set; }

      //10
      //Daten Typ im Ergebnis: TDBN_Time
      //Zeitstempel des Maximas der Prozesswerte
      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("true")]
      bool IDAT_PMAXTM { get; set; }

      //11
      //Daten Typ im Ergebnis: uint
      //Anzahl der Grenzwertunterschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("true")]
      bool IDAT_PMINLIM { get; set; }

      //12
      //Daten Typ im Ergebnis: uint
      //Anzahl der Grenzwertüberschreitungen der Prozesswerte
      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("true")]
      bool IDAT_PMAXLIM { get; set; }

      //13
      //Daten Typ im Ergebnis: uint
      //Anzahl der Prozesswerte im Intervall
      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("true")]
      bool IDAT_PCOUNT { get; set; }
   }
}
