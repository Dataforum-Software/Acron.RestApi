using System;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IGetProcessDataPVDescription
   {
      uint PVID { get; set; }

      DataValueTypes ValueTypes { get; set; }

      DBP_ReadTypes DBP_ReadType { get; set; }

      uint PVReplID { get; set; }


      [Flags]
      public enum DataValueTypes : short
      {
         Nothing = 0,
         Values = 1,
         Minima = 2,
         Maxima = 4,
      }

      public enum DBP_ReadTypes : short
      {
         /// <summary>
         /// Prozessdaten gemäß PV-Konfig aufbereitet
         /// </summary>
         DBP_NORMAL = 1,
         /// <summary>
         /// Prozessdaten gemäß PV-Konfig aufbereitet, mit garantiertem Wert zum Start- und Endzeitpunkt
         /// </summary>
         DBP_INCLUDE_FIRST_LAST = 2,
         /// <summary>
         /// Prozessdaten gemäß PV-Konfig aufbereitet ohne leere Werte bei fehlenden Werten
         /// </summary>
         DBP_WITHOUT_NOVALID = 3,
         /// <summary>
         /// Prozessrohdaten
         /// </summary>
         DBP_RAWDATA = 4
      }
   }
}
