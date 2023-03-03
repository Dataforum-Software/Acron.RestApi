using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.GlobalDataDefines
{
   public enum HandValRawDataProvalTypes : short
   {
      [SwaggerEnumInfo("Value is a numeric value")]
      Numeric = 0,

      [SwaggerEnumInfo("Value is a alphanumeric value")]
      Text = 1,
   }
}
