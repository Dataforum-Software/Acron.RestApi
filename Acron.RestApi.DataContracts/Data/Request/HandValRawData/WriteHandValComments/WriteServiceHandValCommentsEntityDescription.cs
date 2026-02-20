using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   [DataContract]
   public class WriteServiceHandValCommentsEntityDescription : IWriteServiceHandValCommentsEntityDescription
   {
      [DataMember]
      public int ServiceEntityId { get; set; }

      [DataMember]
      public string Comment { get; set; }
   }
}
