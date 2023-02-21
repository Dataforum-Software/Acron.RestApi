using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using Acron.RestApi.Interfaces.Response;
using System.Net;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class ApiControllerResponseBase : IApiControllerResponseBase
   {
      /// <summary>
      /// HTTP status code as defined in RFC 9110
      /// </summary>
      [DataMember] 
      public HttpStatusCode HttpStatusCode { get; set; }

      /// <summary>
      /// String representation of HTTP status code as defined in RFC 9110
      /// </summary>
      [DataMember] 
      public string HttpStatusCodeMessage { get; set; }

      /// <summary>
      /// Return code of REST API methods
      /// </summary>
      /// <remarks>
      /// int-Val &lt; 0   ===> Error
      /// int-Val == 0  ===> Ok
      /// int-Val &gt; 0   ===> Warning or hint
      /// </remarks>
      [DataMember] 
      public ConfigDefines.ApiActionResult? ApiActionResult { get; set; }

      [DataMember] 
      public string Message { get; set; }
   }
}
