using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.ChangeProtocol
{
    public interface IConfigProtocolResult<T> where T : IConfigProtocol
    {
      [SwaggerSchema("List of individual protocol entries")]
      [SwaggerExampleValue(typeof(List<IConfigProtocol>))]
      List<T> ConfigProtocolEntries { get; set; }
    }
}
