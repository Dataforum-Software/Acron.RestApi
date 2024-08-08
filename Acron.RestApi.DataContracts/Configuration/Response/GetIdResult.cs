using Acron.RestApi.Interfaces.Configuration.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Configuration.Response
{
   [DataContract]
   public class GetIdResult : IGetIdResult
   {
      [DataMember]
      public string Id { get; set; }
   }
}
