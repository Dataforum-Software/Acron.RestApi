using Acron.RestApi.Interfaces.Request.AccessToken;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.AccessToken
{
   [DataContract]
   public class AccessTokenLoginResource : IAccessTokenLoginResource
   {
      [DataMember]
      public string AppName { get; set; }

      [DataMember]
      public string Password { get; set; }
   }
}
