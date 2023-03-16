using Acron.RestApi.Interfaces.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcOkResponse : ApiControllerResponseBase, IAcOkResponse<object>
   {
      /// <summary>
      /// Type of the object(s) returned in Result
      /// </summary>
      [DataMember]
      public string ResultType { get; set; }

      /// <summary>
      /// Number of objects returned in Result
      /// </summary>
      [DataMember]
      public int ResultCount { get; set; }

      /// <summary>
      /// Operation result
      /// </summary>
      [DataMember]
      public object Result { get; set; }
   }
}
