using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface ICompressionForIntervalOfCustomIntervalDataFlag_Interval
   {
      [SwaggerSchema($"Replacement value set")]
      [SwaggerExampleValue(false)]
      bool ICOMPDAT_REPLACEMENT { get; set; }

      [SwaggerSchema($"Is manually overwritten value")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_OVER { get; set; }

      [SwaggerSchema($"Manually overwritten value is less than minimum")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_LESS { get; set; }

      [SwaggerSchema($"Manually overwritten value is greater than maximum")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_GREATER { get; set; }

      [SwaggerSchema($"Value not accessible")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_NOREL { get; set; }

      [SwaggerSchema($"Value missing")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_MISSING { get; set; }

      [SwaggerSchema($"Value is less than minimum")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_UNDER_LIMIT { get; set; }

      [SwaggerSchema($"Value is greater than maximum")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_OVER_LIMIT { get; set; }

      [SwaggerSchema($"Compressed custom interval value is exactly at the configured minimum limit for this interval")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_MINIMUM { get; set; }

      [SwaggerSchema($"Compressed custom interval value is exactly at the configured maximum limit for this interval")]
      [SwaggerExampleValue(true)]
      bool ICOMPDAT_MAXIMUM { get; set; }

   }
}
