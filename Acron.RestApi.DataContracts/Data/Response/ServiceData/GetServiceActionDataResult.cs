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
   public class GetServiceActionDataResult : IGetServiceActionDataResult<GetServiceActionDataItem>
   {
      [DataMember]
      public List<GetServiceActionDataItem> ServiceActions { get; set; }
   }
}
