using Acron.RestApi.Interfaces.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcBadRequestResponse : ApiControllerResponseBase, IAcBadRequestResponse
   {
      [DataMember]
      public string RequestRoute { get; set; }

      [DataMember]
      public string ErrorText { get; set; }      
   }
}
