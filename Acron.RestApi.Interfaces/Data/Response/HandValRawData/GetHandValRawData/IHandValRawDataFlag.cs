namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataFlag
   {
      //Bit 0 gesetzt:  HDAT_GREATER
      public bool HDAT_GREATER { get; set; }

      //Bit 1 gesetzt:  HDAT_LESS
      public bool HDAT_LESS { get; set; }

      //Bit 2 gesetzt:  HDAT_KEYVALID
      public bool HDAT_KEYVALID { get; set; }

      //Bit 6 gesetzt:  YDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      public bool HDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  YDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      public bool HDAT_OVER_LIMIT { get; set; }

   }
}
