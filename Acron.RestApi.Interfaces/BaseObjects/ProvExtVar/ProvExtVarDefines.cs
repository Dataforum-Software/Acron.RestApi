namespace Acron.RestApi.Interfaces.BaseObjects
{
   public static class ProvExtVarDefines
   {
      #region ExtVar

      /// <summary> Messwertarchivierung - Type</summary>
      public enum MeasurementRecordingType : int
      {
         /// <summary>Momentanwert</summary>
         ActualValue = 0,
         /// <summary>Mittelwert</summary>
         MediumValue = 1,
      }

      /// <summary> Datentypen fuer Messwerterfassung - !!! Datenbankanbindung nach C/C++ !!!</summary>
      public enum DbpDataType : uint
      {
         /// <summary>Unbekannt - ist ungültig und darf nicht verwendet werden</summary>
         DbpUnknown = 0,
         /// <summary>4 Byte Integer - ohne Vorzeichen</summary>
         DbpInt4 = 3,
         /// <summary>4 Byte Integer - mit Vorzeichen</summary>
         DbpSint4 = 9,
         /// <summary>2 Byte Integer - ohne Vorzeichen</summary>
         DbpInt2 = 2,
         /// <summary>2 Byte Integer - mit Vorzeichen</summary>
         DbpSint2 = 8,
         /// <summary>Integer im Bereich  0 - 1 (DBP_INT1)</summary>
         DbpInt1 = 1,
         /// <summary>Real</summary>
         DbpReal4 = 4,
         /// <summary>8 Byte Real</summary>
         DbpReal8 = 5,
         /// <summary>char x-beliebige Anzahl Zeichen</summary>
         DbpChar = 13,
         /// <summary>wchar x-beliebige Anzahl Zeichen</summary>
         DbpWchar = 14,

         /// <summary>char 16 Zeichen</summary>
         DbpChar16 = 6,
         /// <summary>char 64 Zeichen</summary>
         DbpChar64 = 7,
         /// <summary>char 128 Zeichen</summary>
         DbpChar128 = 10,
         /// <summary>char 256 Zeichen</summary>
         DbpChar256 = 11,
         /// <summary>char 512 Zeichen</summary>
         DbpChar512 = 12,
         /// <summary>Letzter Wert - enthält immer den letzten (==grössten) Wert, ist ungültig und darf nicht verwendet werden</summary>
         DbpLastValue = 15,
      };

      #endregion ExtVar

   }
}
