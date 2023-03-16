using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for connections
   /// </summary>
   public interface ICreateConnectionObjectRequestResource : ICreateBaseObjectRequestResource
   {
      /// <summary>
      /// Server address
      /// </summary>
      [SwaggerSchema("Server address")]
      [SwaggerExampleValue("192.168.2.2")]
      string PropServer { get; set; }

      /// <summary>
      /// Server port
      /// </summary>
      /// 
      [SwaggerSchema("Server port")]
      [SwaggerExampleValue("3990")]
      uint PropPort { get; set; }

      /// <summary>
      /// Login name
      /// </summary>
      /// 
      [SwaggerSchema("Login name")]
      [SwaggerExampleValue("user")]
      string PropLoginName { get; set; }

      /// <summary>
      /// Syncronization interval for connected plants
      /// </summary>
      /// 
      [SwaggerSchema("Syncronization interval for connected plants")]
      [SwaggerExampleValue("300")]
      uint PropConnectedSyncInterval { get; set; }

      /// <summary>
      /// Syncronization interval for disconnected plants
      /// </summary>
      /// 
      [SwaggerSchema("Syncronization interval for disconnected plants")]
      [SwaggerExampleValue("60")]
      uint PropDisconnectedSyncInterval { get; set; }

      /// <summary>
      ///Bildungsregel Identifikation der PV-Externals
      /// </summary>
      /// 
      [SwaggerSchema("Rules to identify external process variable")]
      [SwaggerExampleValue("$ConnectionShort:$ProcessVarShort")]
      string PropFormatStringShort { get; set; }

      /// <summary>
      ///Bildungsregel Bezeichnung der PV-Externals
      /// </summary>
      /// 
      [SwaggerSchema("Rules to name external process variable")]
      [SwaggerExampleValue("")]
      string PropFormatStringLong { get; set; }

      /// <summary>
      /// Marker für in der Quellanlage nicht (mehr) vorhandene / kontaktierbare ExtVars
      /// </summary>
      /// 
      [SwaggerSchema("Marker for the non-availabale external variable in the source plant ")]
      [SwaggerExampleValue("")]
      string PropNotOnServerPrefix { get; set; }
   }

}