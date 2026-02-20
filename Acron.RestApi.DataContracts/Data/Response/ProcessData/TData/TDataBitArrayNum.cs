using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   [DataContract]
   public class TDataBitArrayNum : TDataBitArrayBase, ITDataBitArrayNum
   {
      public TDataBitArrayNum()
      {
         base.DataType = DataTypes.Numeric;
      }

      [DataMember]
      /// <summary>
      /// Unterer Grenzbereich des Prozesswertes unterschritten
      /// </summary>
      public bool UnderLimit { get; set; }

      [DataMember]
      /// <summary>
      /// Oberer Grenzbereich des Prozesswertes überschritten
      /// </summary>
      public bool OverLimit { get; set; }

      [DataMember]
      /// <summary>
      /// Maximum: Prozesswert ist Maximum im angeforderten Bereich
      ///</summary>
      public bool Maximum { get; set; }

      [DataMember]
      /// <summary>
      /// Minimum: Prozesswert ist Minimum im angeforderten Bereich
      ///</summary>
      public bool Minimum { get; set; }
   }
}
