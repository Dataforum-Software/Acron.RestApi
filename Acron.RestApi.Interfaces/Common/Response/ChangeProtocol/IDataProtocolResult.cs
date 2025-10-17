using Acron.RestApi.Interfaces;
using Acron.RestApi.Interfaces.Common.Response.ChangeProtocol;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.ChangeProtocol
{
   public interface IDataProtocolResult<T> where T : IDataProtocol
   {
      [SwaggerSchema("List of individual protocol entries")]
      [SwaggerExampleValue(typeof(List<IConfigProtocol>))]
      List<T> DataProtocolEntries { get; set; }
   }
}
