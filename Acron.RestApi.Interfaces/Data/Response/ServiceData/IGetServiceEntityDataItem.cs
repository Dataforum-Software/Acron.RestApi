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

   }
}
