namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataBitArrayNum : ITDataBitArrayBase
   {

      /// <summary>
      /// Unterer Grenzbereich des Prozesswertes unterschritten
      /// </summary>
      public bool UnderLimit { get; set; }

      /// <summary>
      /// Oberer Grenzbereich des Prozesswertes überschritten
      /// </summary>
      public bool OverLimit { get; set; }
   }
}
