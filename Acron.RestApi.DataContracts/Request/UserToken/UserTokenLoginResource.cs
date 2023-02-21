using Acron.RestApi.Interfaces.Request.UserToken;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.UserToken
{
   [DataContract]
   public class UserTokenLoginResource : UserTokenLoginResourceWithoutPassword, IUserTokenLoginResource
   {
      [DataMember]
      public string Password { get; set; }
   }
}
