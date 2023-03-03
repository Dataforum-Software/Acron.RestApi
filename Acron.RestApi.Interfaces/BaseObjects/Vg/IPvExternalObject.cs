using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for process variables from connections
   /// </summary>
   public interface IPvExternalObject : IBaseObject
   {
      /// <summary>
      /// Type of the original process variable
      /// </summary>
      [SwaggerSchema("Type of the original process variable")]
      [SwaggerExampleValue("VgHand")]
      PvExternalDefines.VgExternalType PropExtType { get; }

      /// <summary>
      /// ID of the original process variable
      /// </summary>
      [SwaggerSchema("Id of the original process variable")]
      [SwaggerExampleValue(" 104000026")]
      int PropExtId { get; }

      ///// <summary>
      ///// Zugeordnetes Verbindungsobject
      ///// </summary>
      //public ConnectionObject PropConnection
      //{
      //   get
      //   {
      //      ObjectRefData objRef = GetPropertyValue<ObjectRefData>(PropKeyConnection);
      //      if (objRef == null)
      //         return null;

      //      return objRef.ReferencedObject as ConnectionObject;
      //   }
      //   set
      //   {
      //      ConnectionObject oldValue = PropConnection;
      //      SetPropertyValue<ObjectRefData>(PropKeyConnection, new ObjectRefData(value));
      //      NotifyBaseObjectPropertyChanged<ConnectionObject>("PropConnection", oldValue, value);
      //   }
      //}

      /// <summary>
      /// ID of the parent connection
      /// </summary>
      [SwaggerSchema("Id of the parent connection")]
      [SwaggerExampleValue(0)]
      int PropConnectionId { get; }

      /// <summary>Key</summary>
      [SwaggerSchema("Property Key")]
      [SwaggerExampleValue("")]
      string PropKey { get; }

      /// <summary>
      /// Subtype of the calculation variable - standard, temporary, live
      /// </summary>
      [SwaggerSchema("Subtype of the calculation variable - standard, temporary, live")]
      [SwaggerExampleValue("Standard")]
      PvCalcDefines.CalculationType PropCalculationType { get; }

      /// <summary> First active level - data origin </summary>
      [SwaggerSchema("First active level - data origin")]
      [SwaggerExampleValue("Standard")]
      PvBaseDefines.ValueType PropCompressionDataSource { get; }

      #region RG-Live

      /// <summary>
      /// Evaluation level 'process'
      /// </summary>
      [SwaggerSchema("Evaluation level 'process'")]
      [SwaggerExampleValue("false")]
      bool PropCompressionProcessActive { get; }

      #endregion

      /// <summary>Possible manual value capture(by the day, by the week, ...)</summary>
      [SwaggerSchema("Possible manual value capture(by the day, by the week, ...)")]
      [SwaggerExampleValue("PerDay")]
      PvManualDefines.VgHValEdit PropHedit { get; }

      #region Interval

      /// <summary>
      /// Evaluation level 'interval'
      /// </summary>
      [SwaggerSchema("Evaluation level 'interval'")]
      [SwaggerExampleValue("true")]
      bool PropCompressionIntervalActive { get; }

      /// <summary> Interval compression method</summary>
      [SwaggerSchema("Interval compression method")]
      [SwaggerExampleValue("Frequency")]
      PvBaseDefines.CompMethod PropCompressionIntervalMethod { get; }

      /// <summary> Interval compression used intervals</summary>
      [SwaggerSchema("Interval compression used intervals")]
      [SwaggerExampleValue("1")]
      uint PropCompressionIntervalUsedIntervals { get; }

      #endregion Interval

      #region Day

      /// <summary>
      /// Evaluation level 'day'
      /// </summary>
      [SwaggerSchema("Evaluation level 'day'")]
      [SwaggerExampleValue("true")]
      bool PropCompressionDayActive { get; }

      /// <summary> Daily compression method</summary>
      [SwaggerSchema("Daily compression method")]
      [SwaggerExampleValue("Average")]
      PvBaseDefines.CompMethod PropCompressionDayMethod { get; }

      #endregion Day


      #region Month

      /// <summary>
      /// Evaluation level month'
      /// </summary>
      [SwaggerSchema("Evaluation level month'")]
      [SwaggerExampleValue("true")]
      bool PropCompressionMonthActive { get; }

      /// <summary> Monthly compression method</summary>
      [SwaggerSchema("Monthly compression method")]
      [SwaggerExampleValue("Average")]
      PvBaseDefines.CompMethod PropCompressionMonthMethod { get; }

      #endregion Month

      #region Year

      /// <summary>
      /// Evaluation level 'year'
      /// </summary>
      [SwaggerSchema("Evaluation level 'year'")]
      [SwaggerExampleValue("true")]
      bool PropCompressionYearActive { get; }

      /// <summary> Annual compression method</summary>
      [SwaggerSchema("Annual compression method")]
      [SwaggerExampleValue("Average")]
      PvBaseDefines.CompMethod PropCompressionYearMethod { get; }

      #endregion Year

      /// <summary>Value format</summary>
      [SwaggerSchema("Value format")]
      [SwaggerExampleValue("Numerical")]
      PvBaseDefines.ValueFormat PropFormatVal { get; }

      /// <summary>Output format of values of format 'Time'</summary>
      [SwaggerSchema("Output format of values of format 'Time'")]
      [SwaggerExampleValue("Numerical")]
      PvBaseDefines.TimeFormat PropFormatTime { get; }

      #region Providing-Flags

      /// <summary>Number of days when providing moving daily value</summary>
      [SwaggerSchema("Number of days when providing moving daily value")]
      [SwaggerExampleValue("7")]
      int PropFloatingDayValue { get; }

      /// <summary>Provisioning of values old:REP_VALUE</summary>
      [SwaggerSchema("Provisioning of values old:REP_VALUE")]
      [SwaggerExampleValue("false")]
      bool PropProvidingValue { get; }

      /// <summary>Provisioning of sums old:REP_SUM</summary>
      [SwaggerSchema("Provisioning of sums old:REP_SUM")]
      [SwaggerExampleValue("false")]
      bool PropProvidingSum { get; }

      /// <summary>Provisioning of minima and maxima old:REP_MAXMIN</summary>
      [SwaggerSchema("Provisioning of minima and maxima old:REP_MAXMIN")]
      [SwaggerExampleValue("false")]
      bool PropProvidingMinMax { get; }

      /// <summary>Provisioning of standard deviation old:REP_SAVG</summary>
      [SwaggerSchema("Provisioning of standard deviation old:REP_SAVG")]
      [SwaggerExampleValue("false")]
      bool PropProvidingSDeviation { get; }

      /// <summary>Provisioning of percentile values old:REP_PERCENTIL</summary>
      [SwaggerSchema("Provisioning of percentile values old:REP_PERCENTIL")]
      [SwaggerExampleValue("false")]
      bool PropProvidingPercentil { get; }

      /// <summary>Provisioning of days for annual reports on a monthly basis old:REP_MDAYS</summary>
      [SwaggerSchema("Provisioning of days for annual reports on a monthly basis old:REP_MDAYS")]
      [SwaggerExampleValue("true")]
      bool PropProvidingMDays { get; }

      /// <summary>Provisioning of moving daily value old:REP_DAYFLOATAVG</summary>
      [SwaggerSchema("Provisioning of moving daily value old:REP_DAYFLOATAVG")]
      [SwaggerExampleValue("false")]
      bool PropProvidingFloatDayval { get; }

      /// <summary>Provisioning for the internet old:WWW_USED</summary>
      [SwaggerSchema("Provisioning for the internet old:WWW_USED")]
      [SwaggerExampleValue("false")]
      bool PropProvidingWWW { get; }

      /// <summary>Provisioning of limit violations old:REP_OUTRANGE</summary>
      [SwaggerSchema("Provisioning of limit violations old:REP_OUTRANGE")]
      [SwaggerExampleValue("true")]
      bool PropProvidingLimits { get; }

      /// <summary>Provisioning of encryption old:VG_CODED</summary>
      [SwaggerSchema("Provisioning of encryption old:VG_CODED")]
      [SwaggerExampleValue("false")]
      bool PropProvidingCoding { get; }

      /// <summary>Provisioning for multi-server</summary>
      [SwaggerSchema("Provisioning for multi-server")]
      [SwaggerExampleValue("true")]
      bool PropProvidingMultiserver { get; }

      /// <summary>Provisioning for OPC/DDE</summary>
      [SwaggerSchema("Provisioning for OPC/DDE")]
      [SwaggerExampleValue("false")]
      bool PropProvidingOpcDde { get; }

      /// <summary>Provisioning in dialogue 'day' old:DLG_DAY</summary>
      [SwaggerSchema("Provisioning in dialogue 'day' old:DLG_DAY")]
      [SwaggerExampleValue("false")]
      bool PropProvidingDialogDay { get; }

      /// <summary>Provisioning in dialogue 'month' old:DLG_MON</summary>
      [SwaggerSchema("Provisioning in dialogue 'month' old:DLG_MON")]
      [SwaggerExampleValue("false")]
      bool PropProvidingDialogMonth { get; }

      /// <summary>Provisioning in dialogue 'year' old:DLG_YEAR</summary>
      [SwaggerSchema("Provisioning in dialogue 'year' old:DLG_YEAR")]
      [SwaggerExampleValue("false")]
      bool PropProvidingDialogYear { get; }

      /// <summary>Provisioning of release management old:VG_RELEASE</summary>
      [SwaggerSchema("Provisioning of release management old:VG_RELEASE")]
      [SwaggerExampleValue("true")]
      bool PropProvidingReleased { get; }

      /// <summary>Provisioning of value key old:VIEW_VGKEY</summary>
      [SwaggerSchema("Provisioning of value key old:VIEW_VGKEY")]
      [SwaggerExampleValue("true")]
      bool PropProvidingValKeys { get; }

      #endregion Providing-Flags

   }

   public static class PvExternalDefines
   {
      public enum VgExternalType : int
      {
         [SwaggerEnumInfo("Auto variable")]
         VgAuto = 1,

         [SwaggerEnumInfo("Calculation variable")]
         VgCalc = 2,

         [SwaggerEnumInfo("Manual variable")]
         VgHand = 4,
      }

      public enum VgExternalSyncState
      {
         [SwaggerEnumInfo("Connection state not verified")]
         ReachabilityNotTesteted,

         [SwaggerEnumInfo("No connection to remote plant")]
         NotReachable,

         [SwaggerEnumInfo("Connection to remote plant successful")]
         Reachable,

         [SwaggerEnumInfo("External process variable does not exist in remote plant")]
         NotOnServer,
      }

   }
}