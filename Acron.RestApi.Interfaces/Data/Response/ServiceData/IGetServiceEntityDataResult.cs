using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
   public interface IGetServiceEntityDataResult<ServiceEntityDataItemType> where ServiceEntityDataItemType : IGetServiceEntityDataItem
   {
        public List<ServiceEntityDataItemType> ServiceEntities { get; set; }
    }
}
