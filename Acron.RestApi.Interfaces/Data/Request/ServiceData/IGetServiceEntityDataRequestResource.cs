using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ServiceData
{
   public interface IGetServiceEntityDataRequestResource
   {
      [SwaggerSchema("List of Numeric IDs of Service Entities")]
      [SwaggerExampleValue(new int[] { 600200001, 600200002 })]
      public List<uint> ServiceEntityIDs { get; set; }
   }
}
