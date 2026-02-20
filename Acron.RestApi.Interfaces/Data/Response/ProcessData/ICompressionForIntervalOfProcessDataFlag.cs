using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface ICompressionForIntervalOfProcessDataFlag
   {
      [SwaggerSchema($"Replacement value is set")]
      [SwaggerExampleValue(true)]
      bool IDAT_REPLACEMENT { get; set; }

      [SwaggerSchema($"Is manually overwritten value")]
      [SwaggerExampleValue(true)]
      bool IDAT_OVER { get; set; }

      [SwaggerSchema($"Manually overwritten value is less than minimum")]
      [SwaggerExampleValue(true)]
      bool IDAT_LESS { get; set; }

      [SwaggerSchema($"Manually overwritten value is greater than maximum")]
      [SwaggerExampleValue(true)]
      bool IDAT_GREATER { get; set; }

      [SwaggerSchema($"Value is missing")]
      [SwaggerExampleValue(true)]
      bool IDAT_MISSING { get; set; }

      [SwaggerSchema($"Value is less than minimum")]
      [SwaggerExampleValue(true)]
      bool IDAT_UNDER_LIMIT { get; set; }

      [SwaggerSchema($"Value is greater than maximum")]
      [SwaggerExampleValue(true)]
      bool IDAT_OVER_LIMIT { get; set; }

   }
}
