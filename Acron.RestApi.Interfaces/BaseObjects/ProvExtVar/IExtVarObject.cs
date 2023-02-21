using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for external variables
   /// </summary>
   public interface IExtVarObject : IBaseObject
   {
      void SetProviderId(int providerId);

      /// <summary> Comment </summary>
      [SwaggerSchema("Comment")]
      [SwaggerExampleValue("")]
      string PropComment { get; set; }

      /// <summary> Base object ID of related provider </summary>
      [SwaggerSchema("Base object id of related provider")]
      [SwaggerExampleValue("100000003")]
      int PropIdProvider { get; }

      /// <summary>ID of dependent external variable 1</summary>
      [SwaggerSchema("Id of dependent external variable 1")]
      [SwaggerExampleValue("104000001")]
      int PropIdDependVar1
      {
         get; set;
      }

      /// <summary>ID of dependent external variable 2</summary>
      [SwaggerSchema("Id of dependent external variable 2")]
      [SwaggerExampleValue("104000003")]
      int PropIdDependVar2
      {
         get; set;
      }

      /// <summary>ID of dependent external variable 3</summary>
      [SwaggerSchema("Id of dependent external variable 3")]
      [SwaggerExampleValue("104000004")]
      int PropIdDependVar3
      {
         get; set;
      }

      /// <summary>Status variable</summary>
      [SwaggerSchema("Status variable")]
      [SwaggerExampleValue("")]
      string PropConditionVar
      {
         get; set;
      }

      /// <summary>Confirmation variable</summary>
      [SwaggerSchema("Confirmation variable")]
      [SwaggerExampleValue("")]
      string PropAcknowledgeVar
      {
         get; set;
      }

      #region Messwertaufzeichnung

      /// <summary> DDE variable for cyclical logging</summary>
      [SwaggerSchema("DDE variable for cyclical logging")]
      [SwaggerExampleValue("true")]
      bool PropMeasurementActive { get; set; }

      /// <summary> Measurement archival - average/current</summary>
      [SwaggerSchema("Measurement archival - average/current")]
      [SwaggerExampleValue("ActualValue")]
      ExtVarDefines.MeasurementRecordingType PropMeasurementRecordingType { get; set; }

      /// <summary> Record the minimum </summary>
      [SwaggerSchema("Record the minimum")]
      [SwaggerExampleValue("false")]
      bool PropCyclicMin { get; set; }

      /// <summary> Record the maximum </summary>
      [SwaggerSchema("Record the maximum")]
      [SwaggerExampleValue("false")]
      bool PropCyclicMax { get; set; }

      /// <summary>Data types in process file</summary>
      [SwaggerSchema("Data types in process file")]
      [SwaggerExampleValue("DbpChar16")]
      ExtVarDefines.DbpDataType PropDataType { get; set; }

      /// <summary>Recording in value range from</summary>         
      /// <remarks>Dafault value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Recording in value range from")]
      [SwaggerExampleValue("")]
      double PropGeneralValueFrom { get; set; }

      /// <summary>Recording in value range to</summary>
      /// <remarks>Defaultwert == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Recording in value range to")]
      [SwaggerExampleValue("")]
      double PropGeneralValueTo { get; set; }

      /// <summary>Period of validity (drivers with historical recordings only)</summary>
      [SwaggerSchema("Period of validity (drivers with historical recordings only)")]
      [SwaggerExampleValue("")]
      int PropPeriodOfValidity { get; set; }

      /// <summary>cyclical recording every x seconds (online drivers only)</summary>
      [SwaggerSchema("cyclical recording every x seconds (online drivers only)")]
      [SwaggerExampleValue("")]
      int PropCyclicInterval { get; set; }

      /// <summary>Delta event level 1 - active?</summary>   
      [SwaggerSchema("Check whether Delta event level 1 is active or not")]
      [SwaggerExampleValue("false")]
      bool PropDeltaEventActive1 { get; set; }

      /// <summary>Delta event level 1 - value range from</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 1 - value range from")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueFrom1 { get; set; }

      /// <summary>Delta event level 1 - value range to</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 1 - value range to")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueTo1 { get; set; }

      /// <summary>Delta event level 1 - Recording for changes in value of</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 1 - Recording for changes in value of")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueChange1 { get; set; }

      /// <summary>Delta event level 2 - active?</summary>    
      [SwaggerSchema("Check whether Delta event level 2 is active or not")]
      [SwaggerExampleValue("false")]
      bool PropDeltaEventActive2 { get; set; }

      /// <summary>Delta event level 2 - value range from</summary>          
      /// <remarks>Defaultwert == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 2 - value range from")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueFrom2 { get; set; }

      /// <summary>Delta event level 2 - value range to</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 2 - value range to")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueTo2 { get; set; }

      /// <summary>Delta event level 2 - Recording for changes in value of</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 2 - Recording for changes in value of")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueChange2 { get; set; }

      /// <summary>Delta event level 3 - active?</summary>  
      [SwaggerSchema("Check whether Delta event level 3 is active or not")]
      [SwaggerExampleValue("false")]
      bool PropDeltaEventActive3 { get; set; }

      /// <summary>Delta event level 3 - value range from</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 3 - value range from")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueFrom3 { get; set; }

      /// <summary>Delta event level 3 - value range to</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 3 - value range to")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueTo3 { get; set; }

      /// <summary>Delta event level 3 - Recording for changes in value of</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 3 - Recording for changes in value of")]
      [SwaggerExampleValue("")]
      double PropDeltaEventValueChange3 { get; set; }

      #endregion Messwertaufzeichnung

      #region Service

      /// <summary>Maintenance active</summary>
      [SwaggerSchema("Maintenance active")]
      [SwaggerExampleValue("false")]
      bool PropServiceActive
      {
         get; set;
      }

      /// Section maintenance

      /// <summary>Recording type of maintenance; 0 none, 1 binary, 2 duration, 3 switching cycles </summary>
      [SwaggerSchema("Recording type of maintenance")]
      [SwaggerExampleValue("Impuls")]
      ExtVarDefines.ServiceType PropServiceType
      {
         get; set;
      }

      /// <summary>Unit of maintenance variable</summary>
      /// <remarks> Default value == ExtVarDefines.ServiceUnit.Seconds </remarks>
      [SwaggerSchema("Unit of maintenance variable")]
      [SwaggerExampleValue("Minutes")]
      ExtVarDefines.ServiceUnit PropServiceUnit
      {
         get; set;
      }

      /// <summary>Overflow value of maintenance counter</summary>             
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Overflow value of maintenance counter")]
      [SwaggerExampleValue("")]
      double PropServiceOverflowValue
      {
         get; set;
      }

      #endregion Service

      #region Alert

      // NOT IMPLEMENTED!

      #endregion Alert
   }

   public static class ExtVarDefines
   {
      #region Messwertaufzeichnung

      /// <summary> Measurement archival - Type</summary>
      public enum MeasurementRecordingType : int
      {
         /// <summary>current value</summary>
         ActualValue = 0,
         /// <summary>mean value</summary>
         MediumValue = 1,
      }

      /// <summary> Data types for measurement  - !!! Database connection to C/C++ !!!</summary>
      public enum DbpDataType : uint
      {
         /// <summary>Unknown - is invalid and must not be used</summary>
         DbpUnknown = 0,
         /// <summary>4 Byte integer - unsigned</summary>
         DbpInt4 = 3,
         /// <summary>4 Byte integer - signed</summary>
         DbpSint4 = 9,
         /// <summary>2 Byte integer - unsigned</summary>
         DbpInt2 = 2,
         /// <summary>2 Byte integer - signed</summary>
         DbpSint2 = 8,
         /// <summary>Integer in the range  0 - 1 (DBP_INT1)</summary>
         DbpInt1 = 1,
         /// <summary>4 byte real</summary>
         DbpReal4 = 4,
         /// <summary>8 byte real</summary>
         DbpReal8 = 5,
         /// <summary>char arbitrary number of characters</summary>
         DbpChar = 13,
         /// <summary>wchar arbitrary number of characters</summary>
         DbpWchar = 14,

         /// <summary>char 16 characters</summary>
         DbpChar16 = 6,
         /// <summary>char 64 characters</summary>
         DbpChar64 = 7,
         /// <summary>char 128 characters</summary>
         DbpChar128 = 10,
         /// <summary>char 256 characters</summary>
         DbpChar256 = 11,
         /// <summary>char 512 characters</summary>
         DbpChar512 = 12,
         /// <summary>Last value - always contains the last (==greatest) value, is invalid und must not be used</summary>
         DbpLastValue = 15,
      };

      #endregion Messwertaufzeichnung

      #region Service

      /// <summary>
      /// Data types for maintenance - !!! Database connection to C/C++ !!!
      /// </summary>
      public enum ServiceType : int
      {
         /// <summary> Binary value </summary>
         Impuls,
         /// <summary> Duration </summary>
         Runtime,
         /// <summary> Switching cycles </summary>
         Switches,
      }

      /// <summary>
      /// Unit service duration
      /// </summary>
      public enum ServiceUnit : int
      {
         /// <summary> Seconds </summary>
         Seconds = 1,
         /// <summary> Minutes </summary>
         Minutes = 2,
         /// <summary> Hours </summary>
         Hours = 3,
         /// <summary> Industrial minutes - hundredths of a minute </summary>
         IndustrialMinutes = 4,
      }

      #endregion Service

   }

}
