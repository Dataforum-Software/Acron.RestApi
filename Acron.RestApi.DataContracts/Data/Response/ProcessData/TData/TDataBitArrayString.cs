using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   public class TDataBitArrayString : TDataBitArrayBase, ITDataBitArrayString
   {
      public TDataBitArrayString()
      {
         base.DataType = ITDataBase.DataTypes.String;
      }
   }
}
