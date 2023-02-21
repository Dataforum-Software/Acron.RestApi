
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   /// <summary>
   /// Informations about user with exclusive config access
   /// </summary>
   public interface IPlantConfigUserInfo
   {
      /// <summary>
      /// true if prperties are filled with valid values
      /// </summary>
      [SwaggerSchema("Does this object contain valid data")]
      [SwaggerExampleValue(true)]
      bool ContentIsValid { get; }

      /// <summary>
      /// Program
      /// </summary>
      [SwaggerSchema("Name of the program that currently locks the plant configuration")]
      [SwaggerExampleValue("Designer")]
      string Program { get; }

      /// <summary>
      /// HostOrIp
      /// </summary>
      [SwaggerSchema("The hostname or IP-Address of the client that currently locks the plant configuration")]
      [SwaggerExampleValue("192.168.178.45")]
      string HostOrIp { get; }

      /// <summary>
      /// Port
      /// </summary>
      [SwaggerSchema("Client-side outgoing port of the corresponding connection")]
      [SwaggerExampleValue(55764)]
      int Port { get; }

      /// <summary>
      /// ClientID
      /// </summary>
      [SwaggerSchema("Unique numeric client identifier")]
      [SwaggerExampleValue(333163802472019700)]
      long ClientID { get; }

      /// <summary>
      /// SessionID
      /// </summary>
      [SwaggerSchema("Session identifier as defined on user login")]
      [SwaggerExampleValue("my-id")]
      string SessionID { get; }

      /// <summary>
      /// user from acron user management
      /// </summary>
      [SwaggerSchema("Name of ACRON user that currently locks the plant configuration")]
      [SwaggerExampleValue("acron")]
      string AcronUser { get; }

      /// <summary>
      /// Text with formated informations of complete content
      /// </summary>
      [SwaggerSchema("Above information in user friendly format")]
      [SwaggerExampleValue("ACRON user 'acron' (Program=Designer, HostIP=192.168.178.45, Port=55764, ClientID=333163802472019700, SessionID=my-id)")]
      string DisplayText { get; }

   }
}