using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
   public interface IGetServiceActionDataResult<ServiceActionDataItemType> where ServiceActionDataItemType : IGetServiceActionDataItem
   {

      public List<ServiceActionDataItemType> ServiceActions { get; set; }
   }
}
