using Acron.RestApi.Interfaces.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcServiceUnavailableResponse : ApiControllerResponseBase, IAcServiceUnavailableResponse
   {
      [DataMember]
      public int RetryAfterSeconds { get; set; }
   }
}
