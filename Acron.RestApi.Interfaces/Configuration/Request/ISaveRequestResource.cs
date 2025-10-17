using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface ISaveRequestResource
   {
      [SwaggerSchema("Identification of object to retrieve")]
      [SwaggerExampleValue("2022-07-16T12:00Z")]
      DateTime? RecalculateFrom { get; }

      [SwaggerSchema("Use planned recalculation")]
      [SwaggerExampleValue("true")]
      public bool UsePlannedRecalc { get; set; }

   }
}