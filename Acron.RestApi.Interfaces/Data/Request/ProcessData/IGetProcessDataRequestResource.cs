using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IGetProcessDataRequestResource<T> where T : IGetProcessDataPVDescription
   {
      /// <summary>
      /// Von Zeit
      /// </summary>
      DateTime FromTime { get; set; }
      DateTime FromTime_UTC { get; set; }

      /// <summary>
      /// Bis Zeit
      /// </summary>
      DateTime ToTime { get; set; }
      DateTime ToTime_UTC { get; set; }

      /// <summary>
      /// Differenzzeit in Sekunden für Sonderfälle, sonst -1
      /// </summary>
      int DiffTime { get; set; }
      /// <summary>
      /// Liste der PV ObjectIDs mit Optionen
      /// </summary>
      List<T> PVIDs { get; set; }
   }
}
