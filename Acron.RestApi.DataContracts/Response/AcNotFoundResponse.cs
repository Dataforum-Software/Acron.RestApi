using Acron.RestApi.Interfaces.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcNotFoundResponse : AcBadRequestResponse, IAcNotFoundResponse
   {
   }
}
