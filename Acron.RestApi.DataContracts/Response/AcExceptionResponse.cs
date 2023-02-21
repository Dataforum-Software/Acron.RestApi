using Acron.RestApi.Interfaces.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcExceptionResponse : ApiControllerResponseBase, IAcExceptionResponse
   {
      [DataMember]
      public string RequestRoute { get; set; }

      [DataMember]
      public string ExceptionMessage { get; set; }

      [DataMember]
      public string StackTrace { get; set; }
   }
}
