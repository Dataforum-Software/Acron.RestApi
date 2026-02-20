using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface ICompressionForIntervalOfDayDataFlag
   {
      [SwaggerSchema($"Replacement value set")]
      [SwaggerExampleValue(false)]
      bool DCOMPDAT_REPLACEMENT { get; set; }

      [SwaggerSchema($"Value not accessible")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_NOREL { get; set; }

      [SwaggerSchema($"Value missing")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_MISSING { get; set; }

      [SwaggerSchema($"Value falls below limit")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_UNDER_LIMIT { get; set; }

      [SwaggerSchema($"Value exceeds limit")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_OVER_LIMIT { get; set; }

      [SwaggerSchema($"Indicates that the compressed day data value for this interval represents the minimum observed value within the compression period.")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_MINIMUM { get; set; }

      [SwaggerSchema($"Indicates that the compressed day data value for this interval represents the maximum observed value within the compression period.")]
      [SwaggerExampleValue(true)]
      bool DCOMPDAT_MAXIMUM { get; set; }

   }
}
