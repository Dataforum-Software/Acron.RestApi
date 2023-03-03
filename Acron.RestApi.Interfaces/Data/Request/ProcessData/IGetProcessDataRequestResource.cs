using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IGetProcessDataRequestResource<T> where T : IGetProcessDataPVDescription
   {
      /// <summary>
      /// Von Zeit
      /// </summary>
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T12:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      DateTime FromTime_UTC { get; }

      /// <summary>
      /// Bis Zeit
      /// </summary>
      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-15T15:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      DateTime ToTime_UTC { get; }

      /// <summary>
      /// Differenzzeit in Sekunden für Sonderfälle, sonst -1
      /// </summary>
      [SwaggerSchema("Time difference for ")]
      [SwaggerExampleValue(10)]
      int DiffTime { get; set; }

      /// <summary>
      /// Liste der PV ObjectIDs mit Optionen
      /// </summary>
      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetProcessDataPVDescription))]
      List<T> PVIDs { get; set; }
   }
}
