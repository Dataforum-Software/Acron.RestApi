using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using System.Runtime.Serialization;
using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   [DataContract]
   public class TDataNum : TDataBase, ITDataNum
   {
      public TDataNum() : base(DataTypes.Numeric)
      {

      }

      [DataMember]
      [FormatDoubleMarker(nameof(Value_FORMATTED), ValueFormatType.Process)]
      public double Value { get; set; }

      [DataMember]
      public string Value_FORMATTED { get; set; }

   }
}
