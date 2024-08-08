using Acron.RestApi.Interfaces.Data.Response.ServiceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ServiceData
{
   [DataContract]
   public class GetServiceEntityDataResult : IGetServiceEntityDataResult<GetServiceEntityDataItem>
   {
      [DataMember]
      public List<GetServiceEntityDataItem> ServiceEntities { get; set; }
   }
}
