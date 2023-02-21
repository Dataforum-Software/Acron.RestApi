namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface IDayDataFlag
   {
      //Bit 0 gesetzt:  DDAT_ERSATZ   Ersatzwert eingestellt
      bool DDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  DDAT_OVER      Manuell Überschriebener Wert
      bool DDAT_OVER { get; set; }

      //Bit 2 gesetzt:  DDAT_LESS Wert ist kleiner als unterer Grenzwert
      bool DDAT_LESS { get; set; }

      //Bit 3 gesetzt:  DDAT_GREATER Wert ist größer als oberer Grenzwert
      bool DDAT_GREATER { get; set; }

      //Bit 4 gesetzt:  DDAT_NOREL Wert ist nicht freigegeben
      bool DDAT_NOREL { get; set; }

      //Bit 5 gesetzt:  DDAT_MISSING Wert ist nicht vorhanden
      bool DDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  DDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      bool DDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  DDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      bool DDAT_OVER_LIMIT { get; set; }

   }
}
