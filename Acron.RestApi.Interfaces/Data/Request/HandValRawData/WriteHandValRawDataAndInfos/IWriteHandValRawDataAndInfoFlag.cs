using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public interface IWriteHandValRawDataAndInfoFlag
   {
      //Bit 0 gesetzt:  HDAT_GREATER
      [SwaggerSchema("Actual value is greater than given value")]
      [SwaggerExampleValue(false)]
      public bool HDAT_GREATER { get; set; }

      //Bit 1 gesetzt:  HDAT_LESS
      [SwaggerSchema("Actual value is lower than given value")]
      [SwaggerExampleValue(false)]
      public bool HDAT_LESS { get; set; }

      //Bit 2 gesetzt:  HDAT_KEYVALID
      [SwaggerSchema("Key of the manual value is valid")]
      [SwaggerExampleValue(false)]
      public bool HDAT_KEYVALID { get; set; }
   }
}
