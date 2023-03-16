using Acron.RestApi.Interfaces.Response.AccessToken;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Response.AccessToken
{
   [DataContract]
   public class AccessTokenResource : IAccessTokenResource
   {
      /// <summary>
      /// The Bearer token used to authenticate subsequent API calls
      /// </summary>
      [DataMember]
      public string AccessToken { get; set; }

      /// <summary>
      /// Timestamp in UTC until which the token is valid
      /// </summary>
      [DataMember]
      public DateTime ExpiresUTC { get; set; }

      /// <summary>
      /// Timestamp in UTC when the token was issued
      /// </summary>       
      [DataMember]
      public DateTime IssuedUTC { get; set; }

      /// <summary>
      /// Secondary token used to acquire a new Bearer token before it expires
      /// </summary>
      [DataMember]
      public string RefreshToken { get; set; }

      /// <summary>
      /// Timestamp in UTC until which the refresh token is valid
      /// </summary>
      [DataMember]
      public DateTime RefreshTokenExpiresUTC { get; set; }
   }
}
