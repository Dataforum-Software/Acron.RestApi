using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{
   [DataContract]
   public class WriteProcessDataRequestResource : IWriteProcessDataRequestResource<WriteProcessDataDescription>
   {
      [DataMember]
      [Required]
      [ObjectId]
      public List<WriteProcessDataDescription> ProcessDataDescriptions { get; set; }
   }
}
