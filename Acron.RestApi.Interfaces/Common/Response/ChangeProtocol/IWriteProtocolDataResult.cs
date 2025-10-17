using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.ChangeProtocol
{
   public interface IWriteProtocolDataResult
   {
      [SwaggerSchema("Has an error occured during writing the protocol data?")]
      [SwaggerExampleValue(false)]
      bool HasError { get; set; }

      [SwaggerSchema("Error description and information")]
      [SwaggerExampleValue("An error occured while doing XY")]
      string ErrorText { get; set; }
   }
}
