using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for calculation variables
   /// </summary>
   public interface ICreatePvCalcObjectRequestResource : ICreatePvBaseObjectRequestResource
   {
      ///// <summary>calculation variable is temporary</summary>
      //bool PropIsTemporary { get; set; }

      /// <summary>
      /// Subtype of calculation variable - standard, temporary, live
      /// </summary>
      [SwaggerSchema("Subtype of calculation variable")]
      [SwaggerExampleValue("Standard")]
      PvCalcDefines.CalculationType PropCalculationType { get; set; }

      /// <summary>
      /// Calculation source values
      /// </summary>
      [SwaggerSchema("Calculation source values")]
      [SwaggerExampleValue("Process")]
      PvBaseDefines.ValueType PropSourceVal { get; set; }

      /// <summary> Formula of process variable </summary>
      [SwaggerSchema("Formula of process variable ")]
      [SwaggerExampleValue("")]
      string PropFormulaEdit { get; set; }


      #region Process for RG-Live 

      /// <summary>
      /// Evaluation level 'process'
      /// </summary>
      [SwaggerSchema("Evaluation level 'process'")]
      [SwaggerExampleValue("false")]
      bool PropCompressionProcessActive { get; set; }

      /// <summary> Process values limit from</summary>
      [SwaggerSchema("Process values limit from")]
      [SwaggerExampleValue("0")]
      double PropCompressionProcessRangeFrom { get; set; }

      /// <summary> Process values limit to</summary>
      [SwaggerSchema("Process values limit to")]
      [SwaggerExampleValue("100")]
      double PropCompressionProcessRangeTo { get; set; }

      /// <summary>Process unit formula</summary>
      [SwaggerSchema("Process unit formula")]
      [SwaggerExampleValue("")]
      string PropCompressionProcessUnitFormula { get; set; }

      /// <summary> Process value decimal places</summary>
      [SwaggerSchema("Process value decimal places")]
      [SwaggerExampleValue("0")]
      int PropCompressionProcessNk { get; set; }

      #endregion Process for RG-Live 

      /// <summary> Interval compression method</summary>
      [SwaggerSchema("Interval compression method")]
      [SwaggerExampleValue("None")]
      PvBaseDefines.CompMethod PropCompressionIntervalMethod { get; set; }

      /// <summary> Daily compression method</summary>
      [SwaggerSchema("Daily compression method")]
      [SwaggerExampleValue("None")]
      PvBaseDefines.CompMethod PropCompressionDayMethod { get; set; }

      /// <summary> Daily compression seconds for moving daily values</summary>
      [SwaggerSchema("Daily compression seconds for moving daily values")]
      [SwaggerExampleValue("0")]
      int PropCompressionDayFloatSeconds { get; set; }

      /// <summary> Monthly compression method</summary>
      [SwaggerSchema("Monthly compression method")]
      [SwaggerExampleValue("None")]
      PvBaseDefines.CompMethod PropCompressionMonthMethod { get; set; }

      /// <summary> Monthly compression seconds for moving daily values</summary>
      [SwaggerSchema("Monthly compression seconds for moving daily values")]
      [SwaggerExampleValue("0")]
      int PropCompressionMonthFloatSeconds { get; set; }

      /// <summary> Annual compression method</summary>
      [SwaggerSchema("Annual compression method")]
      [SwaggerExampleValue("None")]
      PvBaseDefines.CompMethod PropCompressionYearMethod { get; set; }

   }
}