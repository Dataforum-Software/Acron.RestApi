using Acron.RestApi.DataContracts.Data.Attributes;
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
   public class GetServiceEntityDataRequestResource : IGetServiceEntityDataRequestResource
   {
      [DataMember]
      [Required]
      [ObjectId]
      public List<uint> ServiceEntityIDs { get; set; }
   }
}
