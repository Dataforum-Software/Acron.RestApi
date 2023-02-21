using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   [DataContract]
   public class TDataBitArrayBase : ITDataBitArrayBase
   {
      //DatenTyp des Arrays (Kein Member, nur für interne Zwecke)      
      public DataTypes DataType { get; set; }

      //Kein Wert
      [DataMember]
      public bool DBFlags_NoValue { get; set; }

      //Manuell überschrieben
      [DataMember]
      public bool DBFlags_ReplacedManual { get; set; }

      //Von SPS / PLC überschrieben
      [DataMember]
      public bool DBFlags_ReplacedPLC { get; set; }

      //Wert wurde normalisiert
      [DataMember]
      public bool DBFlags_ReplacedInt { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Ausfall
      [DataMember]
      public bool ProcessCalculationFlags_ReplacedLoss { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Unterschreitung
      [DataMember]
      public bool ProcessCalculationFlags_ReplacedUnder { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Überschreitung
      [DataMember]
      public bool ProcessCalculationFlags_ReplacedOver { get; set; }

      //Zählerwechsel mit diesem Startwert
      [DataMember]
      public bool ProcessCalculationFlags_ReplacedCounter { get; set; }

      //Art des Wertes
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public DBP_ValueTypes ValueType { get; set; }

      //0-999 Millisekunden
      [DataMember]
      public int MilliSec { get; set; }      
   }
}
