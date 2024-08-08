using Acron.RestApi.Interfaces.Request.UserToken;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.UserToken
{
   [DataContract]
   public class UserTokenRefreshResource2 : IUserTokenRefreshResource2
   {
      [DataMember]
      [Required]
      public string UserToken { get; set; }

      [DataMember]
      [Required]
      public string RefreshToken { get; set; }

   }
}
