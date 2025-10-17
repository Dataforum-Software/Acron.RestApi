using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface ICompressionForIntervalOfCustomIntervalDataFlag_Day
   {
      [SwaggerSchema($"Replacement value set")]
      [SwaggerExampleValue(false)]
      bool DCOMPDAT_REPLACEMENT { get; set; }

      [SwaggerSchema($"Is manually overwritten value")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_OVER { get; set; }

      [SwaggerSchema($"Manually overwritten value is less than minimum")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_LESS { get; set; }

      [SwaggerSchema($"Manually overwritten value is greater than maximum")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_GREATER { get; set; }

      [SwaggerSchema($"Value not accessible")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_NOREL { get; set; }

      [SwaggerSchema($"Value missing")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_MISSING { get; set; }

      [SwaggerSchema($"Value is less than minimum")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_UNDER_LIMIT { get; set; }

      [SwaggerSchema($"Value is greater than maximum")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_OVER_LIMIT { get; set; }

   }
}
