using Acron.RestApi.Interfaces.Common.Response.ChangeProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.ChangeProtocol
{
   [DataContract]
   public class WriteProtocolDataResult : IWriteProtocolDataResult
   {
      [DataMember]
      public bool HasError { get; set; }
      [DataMember]
      public string ErrorText { get; set; }
   }
}
