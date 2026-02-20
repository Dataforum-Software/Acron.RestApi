using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
   public interface IGetServiceEntityDataResult<ServiceEntityDataItemType> where ServiceEntityDataItemType : IGetServiceEntityDataItem
   {
      [SwaggerSchema("List of service entity data items")]
      [SwaggerExampleValue(typeof(IGetServiceEntityDataItem))]
      public List<ServiceEntityDataItemType> ServiceEntities { get; set; }
   }
}
