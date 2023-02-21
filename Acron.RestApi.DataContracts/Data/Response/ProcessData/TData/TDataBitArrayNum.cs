using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   public class TDataBitArrayNum : TDataBitArrayBase, ITDataBitArrayNum
   {
      public TDataBitArrayNum()
      {
         base.DataType = ITDataBase.DataTypes.Numeric;
      }

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
