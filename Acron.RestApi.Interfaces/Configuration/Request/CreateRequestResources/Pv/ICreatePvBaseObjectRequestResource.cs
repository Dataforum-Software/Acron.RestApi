using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Base interface for process value objects (base only, no instances)
   /// </summary>
   public interface ICreatePvBaseObjectRequestResource : ICreateBaseObjectRequestResource
   {
      /// <summary>Key</summary>
      [SwaggerSchema("Key")]
      [SwaggerExampleValue("")]
      string PropKey
      {
         get; set;
      }

      /// <summary>Value format</summary>
      [SwaggerSchema("Value format")]
      [SwaggerExampleValue(PvBaseDefines.ValueFormat.Numerical)]
      PvBaseDefines.ValueFormat PropFormatVal
      {
         get; set;
      }

      /// <summary>Output format of time values</summary>
      [SwaggerSchema("Output format of time values")]
      [SwaggerExampleValue(PvBaseDefines.TimeFormat.DayMonthYear)]
      PvBaseDefines.TimeFormat PropFormatTime
      {
         get; set;
      }

      /// <summary>Decimal places basic values</summary>
      [SwaggerSchema("Decimal places basic values")]
      [SwaggerExampleValue(2)]
      int PropNk
      {
         get; set;
      }

      /// <summary>Unit basic values</summary>
      [SwaggerSchema("Unit basic values")]
      [SwaggerExampleValue("m")]
      string PropUnitFormula
      {
         get; set;
      }

      /// <summary>
      /// Description
      /// </summary>
      [SwaggerSchema("Description")]
      [SwaggerExampleValue("")]
      string PropComment
      {
         get; set;
      }

      /// <summary>Limit range minimum</summary>
      [SwaggerSchema("Limit range minimum")]
      [SwaggerExampleValue(0.0)]
      double PropGvalMin
      {
         get; set;
      }

      /// <summary>Limit range maximum</summary>
      [SwaggerSchema("Limit range maximum")]
      [SwaggerExampleValue(2.0)]
      double PropGvalMax
      {
         get; set;
      }

      /// <summary>
      /// Convert (all) units
      /// </summary>
      [SwaggerSchema("Convert (all) units")]
      [SwaggerExampleValue(false)]
      bool PropCalculateUnits
      {
         get; set;
      }

      #region Intervall

      /// <summary>
      /// Evaluation level intervall
      /// </summary>
      [SwaggerSchema("Evaluation level interval")]
      [SwaggerExampleValue("true")]
      bool PropCompressionIntervalActive
      {
         get; set;
      }

      /// <summary> Interval compression used intervals (Flag field see PlantObject.CompIValIndex)</summary>
      [SwaggerSchema("Interval compression used intervals (Flag field see PlantObject.CompIValIndex)")]
      [SwaggerExampleValue("3")]
      uint PropCompressionIntervalUsedIntervals
      {
         get; set;
      }

      /// <summary> Interval compression limit from</summary>
      [SwaggerSchema("Interval compression limit from")]
      [SwaggerExampleValue("0.0")]
      double PropCompressionIntervalRangeFrom
      {
         get; set;
      }

      /// <summary> Interval compression limit to</summary>
      [SwaggerSchema("Interval compression limit to")]
      [SwaggerExampleValue("2.0")]
      double PropCompressionIntervalRangeTo
      {
         get; set;
      }

      /// <summary>Interval unit formula</summary>
      [SwaggerSchema("Interval unit formula")]
      [SwaggerExampleValue("m")]
      string PropCompressionIntervalUnitFormula
      {
         get; set;
      }

      ///// <summary> Interval compression calculate Unit</summary>
      //bool PropCompressionIntervalUnitCalculate
      //{
      //   get; set;
      //}

      /// <summary> Interval compression decimal places</summary>
      [SwaggerSchema("Interval compression decimal places")]
      [SwaggerExampleValue(1)]
      int PropCompressionIntervalNk
      {
         get; set;
      }

      /// <summary> Interval compression percentile value %</summary>
      [SwaggerSchema("Interval compression percentile value %")]
      [SwaggerExampleValue(0.0)]
      double PropCompressionIntervalPercentil
      {
         get; set;
      }

      #endregion

      #region Tag

      /// <summary>
      /// Evaluation level day
      /// </summary>
      [SwaggerSchema("Evaluation level day")]
      [SwaggerExampleValue("true")]
      bool PropCompressionDayActive
      {
         get; set;
      }

      /// <summary> Daily compression used interval</summary>
      [SwaggerSchema("Daily compression used interval")]
      [SwaggerExampleValue("1")]
      uint PropCompressionDayUsedInterval
      {
         get; set;
      }

      /// <summary> Daily compression limit from</summary>
      [SwaggerSchema("Daily compression limit from")]
      [SwaggerExampleValue("0.0")]
      double PropCompressionDayRangeFrom
      {
         get; set;
      }

      /// <summary> Daily compression limit to</summary>
      [SwaggerSchema("Daily compression limit to")]
      [SwaggerExampleValue("2.0")]
      double PropCompressionDayRangeTo
      {
         get; set;
      }

      /// <summary>Daily compression unit formula</summary>
      [SwaggerSchema("Daily compression unit formula")]
      [SwaggerExampleValue("m")]
      string PropCompressionDayUnitFormula
      {
         get; set;
      }

      ///// <summary> Daily compression unit calculation/summary>
      //bool PropCompressionDayUnitCalculate
      //{
      //   get; set;
      //}

      /// <summary> Daily compression decimal places</summary>
      [SwaggerSchema("Daily compression decimal places")]
      [SwaggerExampleValue("1")]
      int PropCompressionDayNk
      {
         get; set;
      }

      /// <summary> Daily compression percentile value %</summary>
      [SwaggerSchema("Daily compression percentile value %")]
      [SwaggerExampleValue(0.0)]
      double PropCompressionDayPercentil
      {
         get; set;
      }

      #endregion

      #region Monat

      /// <summary>
      /// Evaluation level month
      /// </summary>
      [SwaggerSchema("Evaluation level month")]
      [SwaggerExampleValue("true")]
      bool PropCompressionMonthActive
      {
         get; set;
      }

      /// <summary> Monthly compression limit from</summary>
      [SwaggerSchema("Monthly compression limit from")]
      [SwaggerExampleValue("0.0")]
      double PropCompressionMonthRangeFrom
      {
         get; set;
      }

      /// <summary> Monthly compression limit to</summary>
      [SwaggerSchema("Monthly compression limit to")]
      [SwaggerExampleValue("2.0")]
      double PropCompressionMonthRangeTo
      {
         get; set;
      }

      /// <summary>Monthly compression unit formula</summary>
      [SwaggerSchema("Monthly compression unit formula")]
      [SwaggerExampleValue("m")]
      string PropCompressionMonthUnitFormula
      {
         get; set;
      }

      ///// <summary> Monthly compression unit calculation</summary>
      //bool PropCompressionMonthUnitCalculate
      //{
      //   get; set;
      //}

      /// <summary> Monthly compression decimal places</summary>
      [SwaggerSchema("Monthly compression decimal places")]
      [SwaggerExampleValue("1")]
      int PropCompressionMonthNk
      {
         get; set;
      }

      /// <summary> Monthly compression percentile value %</summary>
      [SwaggerSchema("Monthly compression percentile value %")]
      [SwaggerExampleValue(0.0)]
      double PropCompressionMonthPercentil
      {
         get; set;
      }

      #endregion Monat

      #region Jahr

      /// <summary>
      /// Evaluation level year
      /// </summary>
      [SwaggerSchema("Evaluation level year")]
      [SwaggerExampleValue("true")]
      bool PropCompressionYearActive
      {
         get; set;
      }

      /// <summary> Annual compression limit from</summary>
      [SwaggerSchema("Annual compression limit from")]
      [SwaggerExampleValue("0.0")]
      double PropCompressionYearRangeFrom
      {
         get; set;
      }

      /// <summary> Annual compression limit to</summary>
      [SwaggerSchema("Annual compression limit to")]
      [SwaggerExampleValue("2.0")]
      double PropCompressionYearRangeTo
      {
         get; set;
      }

      /// <summary> Annual compression unit formula</summary>
      [SwaggerSchema("Annual compression unit formula")]
      [SwaggerExampleValue("m")]
      string PropCompressionYearUnitFormula
      {
         get; set;
      }

      ///// <summary> Annual compression unit calculation</summary>
      //bool PropCompressionYearUnitCalculate
      //{
      //   get; set;
      //}

      /// <summary> Annual compression decimal places</summary>
      [SwaggerSchema("Annual compression decimal places")]
      [SwaggerExampleValue("1")]
      int PropCompressionYearNk
      {
         get; set;
      }

      /// <summary> Annual compression percentile value %</summary>
      [SwaggerSchema("Annual compression percentile value %")]
      [SwaggerExampleValue(0.0)]
      double PropCompressionYearPercentil
      {
         get; set;
      }

      #endregion Jahr

      #region ValKeys

      /// <summary>
      /// All Key-Value pairs of this process variable
      /// </summary>
      /// <remarks>
      /// In frontend and reports all data values which exists as keys in 
      /// this dictionary will be replaced by correcponding values.
      /// </remarks>
      [SwaggerSchema("All Key-Value pairs of this process variable")]
      [SwaggerExampleValue(new string[] { "1: trocken", "2: Frost", "3: Regen" })]
      Dictionary<double, string> PropValKeys { get; set; }

      #endregion ValKeys

      #region Providing-Flags

      /// <summary>Number of days when provisioning moving daily value</summary>
      [SwaggerSchema("Number of days when provisioning moving daily value")]
      [SwaggerExampleValue("7")]
      int PropFloatingDayValue
      {
         get; set;
      }

      /// <summary> Provisioning of values old:REP_VALUE</summary>
      [SwaggerSchema("Provisioning of values old:REP_VALUE")]
      [SwaggerExampleValue("true")]
      bool PropProvidingValue
      {
         get; set;
      }

      /// <summary>Provisioning of sums old:REP_SUM</summary>
      [SwaggerSchema("Provisioning of sums old:REP_SUM")]
      [SwaggerExampleValue("false")]
      bool PropProvidingSum
      {
         get; set;
      }

      /// <summary>Provisioning of minima and maxima old:REP_MAXMIN</summary>
      [SwaggerSchema("Provisioning of minima and maxima old:REP_MAXMIN")]
      [SwaggerExampleValue("true")]
      bool PropProvidingMinMax
      {
         get; set;
      }

      /// <summary>Provisioning of standard deviation old:REP_SAVG</summary>
      [SwaggerSchema("Provisioning of standard deviation old:REP_SAVG")]
      [SwaggerExampleValue("true")]
      bool PropProvidingSDeviation
      {
         get; set;
      }

      /// <summary>Provisioning of percentile values old:REP_PERCENTIL</summary>
      [SwaggerSchema("Provisioning of percentile values old:REP_PERCENTIL")]
      [SwaggerExampleValue("true")]
      bool PropProvidingPercentil
      {
         get; set;
      }

      /// <summary>Monthly provisioning of days for annual reports old:REP_MDAYS</summary>
      [SwaggerSchema("Monthly provisioning of days for annual reports old:REP_MDAYS")]
      [SwaggerExampleValue("true")]
      bool PropProvidingMDays
      {
         get; set;
      }

      /// <summary>Provisioning of moving daily value old:REP_DAYFLOATAVG</summary>
      [SwaggerSchema("Provisioning of moving daily value old:REP_DAYFLOATAVG")]
      [SwaggerExampleValue("true")]
      bool PropProvidingFloatDayval
      {
         get; set;
      }

      /// <summary>Provisioning of limit violations old:REP_OUTRANGE</summary>
      [SwaggerSchema("Provisioning of limit violations old:REP_OUTRANGE")]
      [SwaggerExampleValue("false")]
      bool PropProvidingLimits
      {
         get; set;
      }

      /// <summary>Provisioning of encryption old:VG_CODED</summary>
      [SwaggerSchema("Provisioning of encryption old:VG_CODED")]
      [SwaggerExampleValue("false")]
      bool PropProvidingCoding
      {
         get; set;
      }

      /// <summary>Provisioning for multi-server</summary>
      [SwaggerSchema("Provisioning for multi-server")]
      [SwaggerExampleValue("false")]
      bool PropProvidingMultiserver
      {
         get; set;
      }

      /// <summary>Provisioning for OPC/DDE</summary>
      [SwaggerSchema("Provisioning for OPC/DDE")]
      [SwaggerExampleValue("false")]
      bool PropProvidingOpcDde
      {
         get; set;
      }

      /// <summary>Provisioning in dialogue 'day' old:DLG_DAY</summary>
      [SwaggerSchema("Provisioning in dialogue 'day' old:DLG_DAY")]
      [SwaggerExampleValue("true")]
      bool PropProvidingDialogDay
      {
         get; set;
      }

      /// <summary>Provisioning in dialogue 'month' old:DLG_MON</summary>
      [SwaggerSchema("Provisioning in dialogue 'month' old:DLG_MON")]
      [SwaggerExampleValue("true")]
      bool PropProvidingDialogMonth
      {
         get; set;
      }

      /// <summary>Provisioning in dialogue 'year' old:DLG_YEAR</summary>
      [SwaggerSchema("Provisioning in dialogue 'year' old:DLG_YEAR")]
      [SwaggerExampleValue("true")]
      bool PropProvidingDialogYear
      {
         get; set;
      }

      /// <summary>Provisioning of release management old:VG_RELEASE</summary>
      [SwaggerSchema("Provisioning of release management old:VG_RELEASE")]
      [SwaggerExampleValue("false")]
      bool PropProvidingReleased
      {
         get; set;
      }

      /// <summary>Provisioning of value key old:VIEW_VGKEY</summary>
      [SwaggerSchema("Provisioingn of value key old:VIEW_VGKEY")]
      [SwaggerExampleValue("false")]
      bool PropProvidingValKeys
      {
         get; set;
      }

      #endregion Providing-Flags

      #region General-Flags

      /// <summary>Different units, decimal places and limit ranges</summary>
      [SwaggerSchema("Different units, decimal places and limit ranges")]
      [SwaggerExampleValue("false")]
      bool PropDifferentUnitAndLimit
      {
         get; set;
      }

      #endregion General-Flags

      /// <summary> Confirm change of data VG_RESUME2EYE,VG_RESUME4EYE</summary>
      [SwaggerSchema("Confirm change of data VG_RESUME2EYE,VG_RESUME4EYE")]
      [SwaggerExampleValue("TwoEyeMode")]
      PvBaseDefines.QuitValueChanges PropQuitValChanges
      {
         get; set;
      }

      #region Unit-Getter

      //UnitBase PropUnitPart1
      //{
      //   get { return getDBUnit(PropKeyUnitPart1); }
      //}
      // UnitBase PropUnitPart2
      //{
      //   get { return getDBUnit(PropKeyUnitPart2); }
      //}
      // UnitBase PropCompressionIntervalUnitPart1
      //{
      //   get { return getDBUnit(PropKeyCompressionIntervalUnitPart1); }
      //}
      // UnitBase PropCompressionIntervalUnitPart2
      //{
      //   get { return getDBUnit(PropKeyCompressionIntervalUnitPart2); }
      //}
      // UnitBase PropCompressionDayUnitPart1
      //{
      //   get { return getDBUnit(PropKeyCompressionDayUnitPart1); }
      //}
      // UnitBase PropCompressionDayUnitPart2
      //{
      //   get { return getDBUnit(PropKeyCompressionDayUnitPart2); }
      //}
      // UnitBase PropCompressionMonthUnitPart1
      //{
      //   get { return getDBUnit(PropKeyCompressionMonthUnitPart1); }
      //}
      // UnitBase PropCompressionMonthUnitPart2
      //{
      //   get { return getDBUnit(PropKeyCompressionMonthUnitPart2); }
      //}
      // UnitBase PropCompressionYearUnitPart1
      //{
      //   get { return getDBUnit(PropKeyCompressionYearUnitPart1); }
      //}
      // UnitBase PropCompressionYearUnitPart2
      //{
      //   get { return getDBUnit(PropKeyCompressionYearUnitPart2); }
      //}

      #endregion Unit-Getter

   }
}