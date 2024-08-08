using Acron.RestApi.Interfaces.Configuration.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class GetIdRequestResource : IGetIdRequestResource
   {
      [DataMember]
      public string ShortName {get; set;}
   }
}
