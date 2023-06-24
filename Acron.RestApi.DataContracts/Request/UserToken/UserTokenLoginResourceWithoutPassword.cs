using Acron.RestApi.Interfaces.Request.UserToken;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.UserToken
{
   [DataContract]
   public class UserTokenLoginResourceWithoutPassword : IUserTokenLoginResourceWithoutPassword
   {
      [DataMember]
      [Required]
      [MaxLength(29)]
      public string AcronUser { get; set; }

      [DataMember]
      [MaxLength(128)]
      [Required]
      public string ClientName { get; set; }

      [DataMember]
      public string HostOrIp { get; set; }

      [DataMember]
      [Range(1, 65535)]
      public int Port { get; set; }

      [DataMember]
      public string SessionId { get; set; }
   }
}
