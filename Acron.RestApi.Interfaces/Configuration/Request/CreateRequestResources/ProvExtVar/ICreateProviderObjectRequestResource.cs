using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for the provider objects (Base only; no instances)
   /// </summary>
   public interface ICreateProviderObjectRequestResource : ICreateProviderBaseObjectRequestResource
   {
      /// <summary> Base object ID of the corresponding driver </summary>
      [SwaggerSchema("Base object id of the corresponding driver")]
      [SwaggerExampleValue("100000003")]

      int PropIdDriver
      {
         get; set;
      }

      /// <summary> Driver parameter 1 </summary>
      [SwaggerSchema("Driver parameter 1")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter1
      {
         get; set;
      }

      /// <summary> Driver parameter 2 </summary>
      /// 
      [SwaggerSchema("Driver parameter 2")]
      [SwaggerExampleValue("50")]
      string PropDriverParameter2
      {
         get; set;
      }

      /// <summary> Driver parameter 3 </summary>
      /// 
      [SwaggerSchema("Driver parameter 3")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter3
      {
         get; set;
      }

      /// <summary> Driver parameter 4 </summary>
      /// 
      [SwaggerSchema("Driver parameter 4")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter4
      {
         get; set;
      }

      /// <summary> Driver parameter 5 </summary>
      /// 
      [SwaggerSchema("Driver parameter 5")]
      [SwaggerExampleValue("1")]
      string PropDriverParameter5
      {
         get; set;
      }

      /// <summary> Measurement interval (ms) </summary>
      /// 
      [SwaggerSchema("Measurement interval (ms)")]
      [SwaggerExampleValue("0")]
      int PropReadingInterval
      {
         get; set;
      }

      /// <summary> Query delay after start (s) </summary>
      /// 
      [SwaggerSchema("Query delay after start (s)")]
      [SwaggerExampleValue("0")]
      int PropStartupDelayTime
      {
         get; set;
      }

      /// <summary> Test mode </summary>
      /// 
      [SwaggerSchema("Test mode")]
      [SwaggerExampleValue("false")]
      bool PropTestMode
      {
         get; set;
      }

      /// <summary> Window always in foreground </summary>
      /// 
      [SwaggerSchema("Window always in foreground")]
      [SwaggerExampleValue("false")]
      bool PropAlwaysOnTop
      {
         get; set;
      }

      /// <summary> Create alerts automatically </summary>
      /// 
      [SwaggerSchema("Create alerts automatically")]
      [SwaggerExampleValue("true")]
      bool PropAlertAutoGeneration
      {
         get; set;
      }

      /// <summary> Composition rule group names </summary>
      /// 
      [SwaggerSchema("Composition rule group names")]
      [SwaggerExampleValue("$GroupName")]
      string PropAlertRuleGroupName
      {
         get; set;
      }

      /// <summary> Composition rule variable names </summary>
      /// 
      [SwaggerSchema("Composition rule variable names")]
      [SwaggerExampleValue("$VarName")]
      string PropAlertRuleVarName
      {
         get; set;
      }

   }
}