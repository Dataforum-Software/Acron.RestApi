using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
   public interface IGetServiceEntityDataItem
   {
      /// <summary>
      /// Objekt-ID des Aggregats
      /// </summary>
      [SwaggerSchema("Numeric ID of Service Entity")]
      [SwaggerExampleValue(600200001)]
      public uint EntityId { get; set; }

      [SwaggerSchema("Identification of service entity")]
      [SwaggerExampleValue("umwaelzrolle")]
      public string EntityShortName { get; set; }

      /// <summary>
      /// Objekt-ID der letzten durchgeführten Wartung
      /// </summary>
      [SwaggerSchema("Numeric ID of last Service Action")]
      [SwaggerExampleValue(650000001)]
      public uint LastServiceId { get; set; }

      /// <summary>
      /// Identifikation der letzten durchgeführten Wartung
      /// </summary>
      [SwaggerSchema("Identification of last Service Action")]
      [SwaggerExampleValue("maintenance_annul")]
      public string LastServiceShortName { get; set; }

      /// <summary>
      /// Bezeichnung der letzten durchgeführten Wartung
      /// </summary>
      [SwaggerSchema("Designation of last Service Action")]
      [SwaggerExampleValue("Annular Maintenance")]
      public string LastServiceLongName { get; set; }

      /// <summary>
      /// Zeitpunkt der letzten durchgeführten Wartung
      /// </summary>
      [SwaggerSchema("Date of last Service Action")]
      [SwaggerExampleValue("2024-04-29")]
      public DateOnly LastServiceDate { get; set; }

      [SwaggerSchema($"{nameof(LastServiceDate)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("29.04.2024")]
      public string LastServiceDate_FORMATTED { get; set; }

      /// <summary>
      /// Gibt an, ob Laufzeit als Handwerte vorliegt
      /// </summary>
      [SwaggerSchema("Indicates if Runtime is available as Hand Values")]
      [SwaggerExampleValue(true)]
      public bool IsRuntimeHandValue { get; set; }

      /// <summary>
      /// Anzahl der Einträge der Laufzeit-Handwerte
      /// </summary>
      [SwaggerSchema("Number of entries of Runtime Hand Values")]
      [SwaggerExampleValue(3)]
      public uint CountRuntimeHandValues { get; set; }

      /// <summary>
      /// Zeitstempel der Laufzeit-Handwerte 
      /// </summary>
      [SwaggerSchema("Timestamps of Runtime Hand Values")]
      [SwaggerExampleValue(new string[] { "2024-04-28T12:00:00Z", "2024-04-29T12:00:00Z", "2024-04-30T12:00:00Z" })]
      public List<DateTime> RuntimeHandValueTimestamps { get; set; }

      [SwaggerSchema($"{nameof(RuntimeHandValueTimestamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "28.04.2024 12:00", "29.04.2024 12:00", "30.04.2024 12:00" })]
      public List<string> RuntimeHandValueTimestamps_FORMATTED { get; set; }

      /// <summary>
      /// Laufzeit-Handwerte
      /// </summary>
      [SwaggerSchema("Runtime Hand Values")]
      [SwaggerExampleValue(new uint[] { 1200, 1250, 1300 })]
      public List<uint> RuntimeHandValues { get; set; }

      /// <summary>
      /// Gibt an, ob Schaltspiele als Handwerte vorliegen
      /// </summary>
      [SwaggerSchema("Indicates if Switching Plays are available as Hand Values")]
      [SwaggerExampleValue(true)]
      public bool IsSwitchingHandValue { get; set; }

      /// <summary>
      /// Anzahl der Einträge der Schaltspiel-Handwerte
      /// </summary>
      [SwaggerSchema("Number of entries of Switching Hand Values")]
      [SwaggerExampleValue(3)]
      public uint CountSwitchingHandValues { get; set; }

      /// <summary>
      /// Zeitstempel der Schaltspiel-Handwerte
      /// </summary>
      [SwaggerSchema("Timestamps of Switching Hand Values")]
      [SwaggerExampleValue(new string[] { "2024-04-28T12:00:00Z", "2024-04-29T12:00:00Z", "2024-04-30T12:00:00Z" })]
      public List<DateTime> SwitchingHandValueTimestamps { get; set; }


      [SwaggerSchema($"{nameof(SwitchingHandValueTimestamps)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "28.04.2024 12:00", "29.04.2024 12:00", "30.04.2024 12:00" })]
      public List<string> SwitchingHandValueTimestamps_FORMATTED { get; set; }

      /// <summary>
      /// Schaltspiel-Handwerte
      /// </summary>
      [SwaggerSchema("Switching Hand Values")]
      [SwaggerExampleValue(new uint[] { 300, 320, 340 })]
      public List<uint> SwitchingHandValues { get; set; }



   }
}
