using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ServiceData
{
   public interface IGetServiceActionDataRequestResource
   {
      [SwaggerSchema("List of Numeric IDs of Service Entities or Service Actions")]
      [SwaggerExampleValue(new int[] { 600200001, 600200002 })]
      public List<uint> ServiceActionIDs { get; set; }

      [SwaggerSchema("If true, search for Service Actions by the Numeric ID of the parent Entity.")]
      [SwaggerExampleValue(true)]
      public bool ByParentID { get; set; }      
   }
}
