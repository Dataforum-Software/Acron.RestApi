using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for manual variables
   /// </summary>
   public interface ICreatePvManualObjectRequestResource : ICreatePvManualAutoBaseObjectRequestResource
   {
      /// <summary>Manual value has the key VGHVAL_KEY</summary>
      [SwaggerSchema("Manual value has the key VGHVAL_KEY")]
      [SwaggerExampleValue("false")]
      bool PropHValUseKey
      {
         get; set;
      }

      /// <summary>
      /// Base object ID of the assigned external variable 
      /// </summary>
      [SwaggerSchema("Base object id of the assigned external variable")]
      [SwaggerExampleValue("104000026")]
      int PropIdExternalVariable
      {
         get; set;
      }

      /// <summary>Possible manual value capture (by the day, by the week, ...)</summary>
      [SwaggerSchema("Possible manual value capture (by day, by week, ...)")]
      [SwaggerExampleValue("PerDay")]
      PvManualDefines.VgHValEdit PropHedit
      {
         get; set;
      }

      /// <summary>Key to a manual value </summary>
      [SwaggerSchema("Key to a manual value")]
      [SwaggerExampleValue("")]
      string PropHvalKey
      {
         get; set;
      }

      /// <summary>Manual value times (there can be several )</summary>
      [SwaggerSchema("Manual value times (there can be several)")]
      [SwaggerExampleValue(new string[] { "(1,43200)" })]
      Dictionary<int, int> PropHandValueTimeStamps
      {
         get; set;
      }

      /// <summary> Interval compression method</summary>
      [SwaggerSchema("Interval compression method")]
      [SwaggerExampleValue("Frequency = PvBaseDefines.CompMethod.Frequency")]
      PvManualDefines.CompIntervalMethod PropCompressionIntervalMethod
      {
         get; set;
      }

      /// <summary> Daily compression methode</summary>
      [SwaggerSchema("Daily compression method")]
      [SwaggerExampleValue("Average")]
      PvManualDefines.CompDayMethod PropCompressionDayMethod
      {
         get; set;
      }

      /// <summary> Monthly compression methode</summary>
      [SwaggerSchema("Monthly compression method")]
      [SwaggerExampleValue("Average")]
      PvManualDefines.CompMonthMethod PropCompressionMonthMethod
      {
         get; set;
      }

      /// <summary> Annual compression methode</summary>
      [SwaggerSchema("Annual compression methode")]
      [SwaggerExampleValue("Average")]
      PvManualDefines.CompYearMethod PropCompressionYearMethod
      {
         get; set;
      }

   }
}