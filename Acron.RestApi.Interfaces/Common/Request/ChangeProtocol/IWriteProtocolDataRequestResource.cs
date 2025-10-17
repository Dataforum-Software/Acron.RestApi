using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Request.ChangeProtocol
{
    public interface IWriteProtocolDataRequestResource<T> where T : IWriteProtocolDataEntry
    {
      [SwaggerSchema("The user whose changes are requested")]
      [SwaggerExampleValue("acron")]
      string UserShortName { get; set; }

      [SwaggerSchema("The user whose changes are requested")]
      [SwaggerExampleValue(typeof(List<IWriteProtocolDataEntry>))]
      List<T> Values { get; set; }
   }
}
