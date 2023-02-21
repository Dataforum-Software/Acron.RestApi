namespace Acron.RestApi.Interfaces.Data.Response.YearData
{
   public interface IYearDataFlag
   {
      //Bit 0 gesetzt:  YDAT_ERSATZ   Ersatzwert eingestellt
      public bool YDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  YDAT_NOREL   Wert nicht freigegeben
      public bool YDAT_NOREL { get; set; }

      //Bit 2 gesetzt:  YDAT_MISSING   Wert nicht vorhanden
      public bool YDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  YDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      bool YDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  YDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      bool YDAT_OVER_LIMIT { get; set; }

   }
}
