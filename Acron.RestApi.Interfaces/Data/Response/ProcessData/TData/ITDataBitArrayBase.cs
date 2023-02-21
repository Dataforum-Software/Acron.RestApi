using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataBitArrayBase
   {
      //DatenTyp des Arrays
      public DataTypes DataType { get; set; }

      //Kein Wert
      bool DBFlags_NoValue { get; set; }

      //Manuell überschrieben
      bool DBFlags_ReplacedManual { get; set; }

      //Von SPS / PLC überschrieben
      public bool DBFlags_ReplacedPLC { get; set; }

      //Wert wurde normalisiert
      public bool DBFlags_ReplacedInt { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Ausfall
      public bool ProcessCalculationFlags_ReplacedLoss { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Unterschreitung
      public bool ProcessCalculationFlags_ReplacedUnder { get; set; }

      //Automatischen Ersatzwert eingestellt wegen Überschreitung
      public bool ProcessCalculationFlags_ReplacedOver { get; set; }

      //Zählerwechsel mit diesem Startwert
      public bool ProcessCalculationFlags_ReplacedCounter { get; set; }

      //Art des Wertes
      public DBP_ValueTypes ValueType { get; set; }

      //0-999 Millisekunden
      public int MilliSec { get; set; }
   }
}
