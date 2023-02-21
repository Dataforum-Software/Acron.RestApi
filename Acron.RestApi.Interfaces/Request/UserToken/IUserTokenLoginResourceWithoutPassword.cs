using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Request.UserToken
{
   public interface IUserTokenLoginResourceWithoutPassword
   {
      [SwaggerSchema(Description = "Username of acron user")]
      [SwaggerExampleValue("acron")]
      string AcronUser { get; }

      [SwaggerSchema(Description = "Chosen name of the client device")]
      [SwaggerExampleValue("WIN10-DEVMACHINE")]
      string ClientName { get; }

      [SwaggerSchema(Description = "Hostname or IP Address of the client device")]
      [SwaggerExampleValue("192.168.178.45")]
      string HostOrIp { get; }

      [SwaggerSchema(Description = "Client-side outgoing port of connection")]
      [SwaggerExampleValue(55764)]
      int Port { get; }

      [SwaggerSchema(Description = "Self-defined session identifier for use in subsequent api calls")]
      [SwaggerExampleValue("my-id")]
      string SessionId { get; }
   }
}
