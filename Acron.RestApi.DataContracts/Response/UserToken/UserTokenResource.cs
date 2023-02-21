using Acron.RestApi.Interfaces.Response.UserToken;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response.UserToken
{
   [DataContract]
   public class UserTokenResource : IUserTokenResource
   {
      [DataMember]
      public string UserToken { get; set; }

      [DataMember]
      public DateTime ExpiresUTC { get; set; }

      [DataMember]
      public DateTime IssuedUTC { get; set; }

      [DataMember]
      public string RefreshToken { get; set; }

      [DataMember]
      public DateTime RefreshTokenExpiresUTC { get; set; }
   }
}
