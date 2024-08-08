using Acron.RestApi.Interfaces.Data.Request.ServiceData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.ServiceData
{
   [DataContract]
   public class GetServiceActionDataRequestResource : IGetServiceActionDataRequestResource
   {
      [DataMember]
      [Required]
      public List<uint> ServiceActionIDs {  get; set; }
      [DataMember]
      public bool ByParentID {  get; set; }
   }
}
