using Acron.RestApi.Interfaces.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcUnsupportedApiVersionResponse : AcBadRequestResponse, IAcUnsupportedApiVersionResponse
   {
      [DataMember]
      public string ErrorCode { get; set; }

      [DataMember]
      public string ErrorDetail { get; set; }
   }
}
