using Acron.RestApi.Interfaces.Request.AccessToken;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.AccessToken
{
   [DataContract]
   public class AccessTokenRefreshResource : IAccessTokenRefreshResource
   {
      [DataMember]
      public string AccessToken { get; set; }

      [DataMember]
      public string RefreshToken { get; set; }
   }
}
