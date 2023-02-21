using Acron.RestApi.Interfaces.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcBadModelStateResponse : AcBadRequestResponse, IAcBadModelStateResponse
   {
      [DataMember]
      public object ModelStateDictionary { get; set; }
   }
}
