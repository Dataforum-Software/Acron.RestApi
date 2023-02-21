namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos
{
   public interface IWriteHandValRawDataInfoFlag
   {
      //Bit 0 gesetzt:  HDAT_GREATER
      public bool HDAT_GREATER { get; set; }

      //Bit 1 gesetzt:  HDAT_LESS
      public bool HDAT_LESS { get; set; }

      //Bit 2 gesetzt:  HDAT_KEYVALID
      public bool HDAT_KEYVALID { get; set; }

   }
}
