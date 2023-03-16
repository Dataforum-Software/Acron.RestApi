using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataBitArrayBase
   {
      //DatenTyp des Arrays
      [SwaggerSchema("Data type (Numeric / Text)")]
      [SwaggerExampleValue(DataTypes.Numeric)]
      public DataTypes DataType { get; set; }

      //Kein Wert
      [SwaggerSchema("Process value does not exist")]
      [SwaggerExampleValue(false)]
      bool DBFlags_NoValue { get; set; }

      //Manuell überschrieben
      [SwaggerSchema("Value was manually overridden")]
      [SwaggerExampleValue(false)]
      bool DBFlags_ReplacedManual { get; set; }

      //Von SPS / PLC überschrieben
      [SwaggerSchema("Value was overridden by PLC")]
      [SwaggerExampleValue(false)]
      public bool DBFlags_ReplacedPLC { get; set; }

      //Wert wurde normalisiert
      [SwaggerSchema("Replaced - ACRON internal")]
      [SwaggerExampleValue(false)]
      public bool DBFlags_ReplacedInt { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Ausfall
      [SwaggerSchema("Value overridden by replacement value due to outage")]
      [SwaggerExampleValue(false)]
      public bool ProcessCalculationFlags_ReplacedLoss { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Unterschreitung
      [SwaggerSchema("Value overridden by replacement value due to falling short of lower value range limit")]
      [SwaggerExampleValue(false)]
      public bool ProcessCalculationFlags_ReplacedUnder { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Überschreitung
      [SwaggerSchema("Value overridden by replacement value due to exceeding of upper value range limit")]
      [SwaggerExampleValue(false)]
      public bool ProcessCalculationFlags_ReplacedOver { get; set; }

      //Zählerwechsel mit diesem Startwert
      [SwaggerSchema("Replacement counter - ACRON internal")]
      [SwaggerExampleValue(false)]
      public bool ProcessCalculationFlags_ReplacedCounter { get; set; }

      //Art des Wertes
      [SwaggerSchema("Value type")]
      [SwaggerExampleValue(DBP_ValueTypes.DBP_DEVENT_ACT)]
      public DBP_ValueTypes ValueType { get; set; }

      //0-999 Millisekunden
      [SwaggerSchema("Milliseconds of time stamp")]
      [SwaggerExampleValue(100)]
      public int MilliSec { get; set; }
   }
}
