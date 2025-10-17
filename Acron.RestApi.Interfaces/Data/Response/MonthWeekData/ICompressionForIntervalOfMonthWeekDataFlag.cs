using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.MonthWeekData
{
   public interface ICompressionForIntervalOfMonthWeekDataFlag
   {
      [SwaggerSchema($"Replacement value is set")]
      [SwaggerExampleValue(true)]
      bool YCOMPDAT_REPLACEMENT { get; set; }

      [SwaggerSchema($"Value not accessible")]
      [SwaggerExampleValue(true)]
      bool YCOMPDAT_NOREL { get; set; }

      [SwaggerSchema($"Value is missing")]
      [SwaggerExampleValue(true)]
      bool YCOMPDAT_MISSING { get; set; }

      [SwaggerSchema($"Value is less than minimum")]
      [SwaggerExampleValue(true)]
      bool YCOMPDAT_UNDER_LIMIT { get; set; }

      [SwaggerSchema($"Value is greater than maximum")]
      [SwaggerExampleValue(true)]
      bool YCOMPDAT_OVER_LIMIT { get; set; }
   }
}
