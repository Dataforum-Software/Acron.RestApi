using Acron.RestApi.Interfaces.Request.UserToken;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Request.UserToken
{
   [DataContract]
   public class UserTokenLoginResourceWithoutPassword : IUserTokenLoginResourceWithoutPassword
   {
      [DataMember]
      public string AcronUser { get; set; }

      [DataMember]
      public string ClientName { get; set; }

      [DataMember]
      public string HostOrIp { get; set; }

      [DataMember]
      public int Port { get; set; }

      [DataMember]
      public string SessionId { get; set; }
   }
}
