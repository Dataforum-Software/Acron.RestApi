using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using System.Runtime.Serialization;
using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   [DataContract]
   public class TDataString : TDataBase, ITDataString
   {
      public TDataString() : base(DataTypes.String)
      {

      }

      [DataMember]
      public string Value { get; set; }
   }
}
