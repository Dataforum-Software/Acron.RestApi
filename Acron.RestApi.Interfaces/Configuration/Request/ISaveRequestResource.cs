using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface ISaveRequestResource
   {
      [SwaggerSchema("Identification of object to retrieve")]
      [SwaggerExampleValue("2022-07-16T12:00+01:00")]
      DateTime? RecalculateFrom { get; }
   }
}