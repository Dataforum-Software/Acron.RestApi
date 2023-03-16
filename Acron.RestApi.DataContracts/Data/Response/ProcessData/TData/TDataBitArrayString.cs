using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   [DataContract]
   public class TDataBitArrayString : TDataBitArrayBase, ITDataBitArrayString
   {
      public TDataBitArrayString()
      {
         base.DataType = DataTypes.String;
      }
   }
}
