namespace Acron.RestApi.Interfaces.Data.Response.MonthWeekData
{
   public interface IMonthWeekDataFlag
   {
      //Bit 0 gesetzt:  MDAT_ERSATZ   Ersatzwert eingestellt
      public bool MDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  MDAT_NOREL   Wert nicht freigegeben
      public bool MDAT_NOREL { get; set; }

      //Bit 2 gesetzt:  MDAT_MISSING   Wert nicht vorhanden
      public bool MDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  MDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      bool MDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  MDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      bool MDAT_OVER_LIMIT { get; set; }
   }
}
