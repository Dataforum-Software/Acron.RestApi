using Acron.RestApi.Interfaces.Request.UserToken;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.UserToken
{
   [DataContract]
   public class UserTokenRefreshResource : IUserTokenRefreshResource
   {
      [DataMember]
      public string RefreshToken { get; set; }
   }
}
