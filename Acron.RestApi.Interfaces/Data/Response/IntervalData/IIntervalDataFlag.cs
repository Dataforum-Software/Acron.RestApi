namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface IIntervalDataFlag
   {
      //Bit 0 gesetzt:  IDAT_ERSATZ   Ersatzwert eingestellt
      bool IDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  IDAT_OVER      Manuell Überschriebener Wert
      bool IDAT_OVER { get; set; }

      //Bit 2 gesetzt:  IDAT_LESS Wert ist kleiner als unterer Grenzwert
      bool IDAT_LESS { get; set; }

      //Bit 3 gesetzt:  IDAT_GREATER Wert ist größer als oberer Grenzwert
      bool IDAT_GREATER { get; set; }

      //Bit 4 gesetzt:  IDAT_MISSING Wert ist nicht vorhanden
      bool IDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  IDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      bool IDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  IDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      bool IDAT_OVER_LIMIT { get; set; }
   }
}
