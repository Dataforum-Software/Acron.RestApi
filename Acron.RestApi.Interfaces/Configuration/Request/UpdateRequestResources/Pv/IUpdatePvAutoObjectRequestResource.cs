using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   /// <summary>
   /// Interface for auto variables
   /// </summary>
   public interface IUpdatePvAutoObjectRequestResource : IUpdatePvManualAutoBaseObjectRequestResource
   {
      #region General

      /// <summary> Formula of the process variable </summary>
      [SwaggerSchema("Formula of the process variable")]
      [SwaggerExampleValue("Füllstand KT20IL001")]
      string PropFormulaEdit { get; set; }

      /// <summary>Substitute value in case of measurement value underrun - active?</summary>
      [SwaggerSchema("Substitute value in case of measurement value underrun - active?")]
      [SwaggerExampleValue("false")]
      bool PropReplacementMinLimit { get; set; }

      /// <summary>Substitute value in case of measurement value underrun</summary>
      [SwaggerSchema("Substitute value in case of measurement value underrun")]
      [SwaggerExampleValue("0.0")]
      double PropRepValMinLimit { get; set; }

      /// <summary>Substitute value in case of measurement value underrun - value type</summary>
      [SwaggerSchema("Substitute value in case of measurement value underrun - value type")]
      [SwaggerExampleValue("FixValue")]
      PvAutoDefines.ReplacementType PropRepValMinLimitType { get; set; }

      /// <summary>Substitute value in case of measurement value overrun - active?</summary>
      [SwaggerSchema("Substitute value in case of measurement value overrun - active?")]
      [SwaggerExampleValue("false")]
      bool PropReplacementMaxLimit { get; set; }

      /// <summary>Substitute value in case of measurement value overrun</summary>
      [SwaggerSchema("Substitute value in case of measurement value overrun")]
      [SwaggerExampleValue("2.0")]
      double PropRepValMaxLimit { get; set; }

      /// <summary>Substitute value in case of measurement value overrun - Wertetyp</summary>
      [SwaggerSchema("Substitute value in case of measurement value overrun - Wertetyp")]
      [SwaggerExampleValue("LastValue")]
      PvAutoDefines.ReplacementType PropRepValMaxLimitType { get; set; }

      /// <summary>Substitute value in case of failure - active?</summary>
      [SwaggerSchema("Substitute value in case of failure - active?")]
      [SwaggerExampleValue("false")]
      bool PropReplacementLoss { get; set; }

      /// <summary>Substitute value in case of failure</summary>
      [SwaggerSchema("Substitute value in case of failure")]
      [SwaggerExampleValue("100")]
      double PropRepValLoss { get; set; }

      /// <summary>Substitute value in case of failure - value type</summary>
      [SwaggerSchema("Substitute value in case of failure - value type")]
      [SwaggerExampleValue("LastValue")]
      PvAutoDefines.ReplacementType PropRepValLossType { get; set; }

      #endregion General

      #region Interval

      /// <summary> Interval compression method</summary>
      [SwaggerSchema("Interval compression method")]
      [SwaggerExampleValue("AverageWeighted = PvBaseDefines.CompMethod.AverageWeighted")]
      PvAutoDefines.CompIntervalMethod PropCompressionIntervalMethod { get; set; }

      #endregion Interval

      #region Tag

      /// <summary> Compression method - Day </summary>
      [SwaggerSchema("Compression method - Day")]
      [SwaggerExampleValue("Average = PvBaseDefines.CompMethod.Average")]
      PvAutoDefines.CompDayMethod PropCompressionDayMethod { get; set; }

      #endregion Tag

      #region Monat

      /// <summary> Compression method - Month </summary>
      [SwaggerSchema("Compression method - Month")]
      [SwaggerExampleValue(" Average = PvBaseDefines.CompMethod.Average")]
      PvAutoDefines.CompMonthMethod PropCompressionMonthMethod { get; set; }

      #endregion Monat

      #region Jahr

      /// <summary> Compression method - Year </summary>
      [SwaggerSchema("Compression method - Year")]
      [SwaggerExampleValue(" Average = PvBaseDefines.CompMethod.Average,")]
      PvAutoDefines.CompYearMethod PropCompressionYearMethod { get; set; }

      #endregion Jahr

   }
}