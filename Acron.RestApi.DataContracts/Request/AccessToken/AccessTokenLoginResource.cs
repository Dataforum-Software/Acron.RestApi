using Acron.RestApi.Interfaces.Request.AccessToken;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.AccessToken
{
   [DataContract]
   public class AccessTokenLoginResource : IAccessTokenLoginResource
   {
      [DataMember]
      [Required]
      public string AppName { get; set; }

      [DataMember]
      [Required]
      public string Password { get; set; }
   }
}
