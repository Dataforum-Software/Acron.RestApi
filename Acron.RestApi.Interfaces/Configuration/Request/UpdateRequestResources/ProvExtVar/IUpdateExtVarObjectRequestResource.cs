using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   /// <summary>
   /// Interface for external variables
   /// </summary>
   public interface IUpdateExtVarObjectRequestResource : IUpdateBaseObjectRequestResource
   {
      void SetProviderId(int providerId);

      /// <summary> Comment </summary>
      [SwaggerSchema("Comment")]
      [SwaggerExampleValue("")]
      string PropComment { get; set; }

      /// <summary> Base object ID of related provider </summary>
      [SwaggerSchema("Base object id of related provider")]
      [SwaggerExampleValue(100000003)]
      int PropIdProvider { get; }

      /// <summary>ID of dependent external variable 1</summary>
      [SwaggerSchema("Id of dependent external variable 1")]
      [SwaggerExampleValue(104000001)]
      int PropIdDependVar1
      {
         get; set;
      }

      /// <summary>ID of dependent external variable 2</summary>
      [SwaggerSchema("Id of dependent external variable 2")]
      [SwaggerExampleValue(104000003)]
      int PropIdDependVar2
      {
         get; set;
      }

      /// <summary>ID of dependent external variable 3</summary>
      [SwaggerSchema("Id of dependent external variable 3")]
      [SwaggerExampleValue(104000004)]
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
      [SwaggerExampleValue(true)]
      bool PropMeasurementActive { get; set; }

      /// <summary> Measurement archival - average/current</summary>
      [SwaggerSchema("Measurement archival - average/current")]
      [SwaggerExampleValue(ExtVarDefines.MeasurementRecordingType.ActualValue)]
      ExtVarDefines.MeasurementRecordingType PropMeasurementRecordingType { get; set; }

      /// <summary> Record the minimum </summary>
      [SwaggerSchema("Record the minimum")]
      [SwaggerExampleValue(false)]
      bool PropCyclicMin { get; set; }

      /// <summary> Record the maximum </summary>
      [SwaggerSchema("Record the maximum")]
      [SwaggerExampleValue(false)]
      bool PropCyclicMax { get; set; }

      /// <summary>Data types in process file</summary>
      [SwaggerSchema("Data types in process file")]
      [SwaggerExampleValue(ExtVarDefines.DbpDataType.DbpChar16)]
      ExtVarDefines.DbpDataType PropDataType { get; set; }

      /// <summary>Recording in value range from</summary>         
      /// <remarks>Dafault value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Recording in value range from")]
      [SwaggerExampleValue(BaseObjectDefines.NO_VALID)]
      double PropGeneralValueFrom { get; set; }

      /// <summary>Recording in value range to</summary>
      /// <remarks>Defaultwert == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Recording in value range to")]
      [SwaggerExampleValue(BaseObjectDefines.NO_VALID)]
      double PropGeneralValueTo { get; set; }

      /// <summary>Period of validity (drivers with historical recordings only)</summary>
      [SwaggerSchema("Period of validity (drivers with historical recordings only)")]
      [SwaggerExampleValue(0)]
      int PropPeriodOfValidity { get; set; }

      /// <summary>cyclical recording every x seconds (online drivers only)</summary>
      [SwaggerSchema("cyclical recording every x seconds (online drivers only)")]
      [SwaggerExampleValue(0)]
      int PropCyclicInterval { get; set; }

      /// <summary>Delta event level 1 - active?</summary>   
      [SwaggerSchema("Check whether Delta event level 1 is active or not")]
      [SwaggerExampleValue(false)]
      bool PropDeltaEventActive1 { get; set; }

      /// <summary>Delta event level 1 - value range from</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 1 - value range from")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueFrom1 { get; set; }

      /// <summary>Delta event level 1 - value range to</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 1 - value range to")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueTo1 { get; set; }

      /// <summary>Delta event level 1 - Recording for changes in value of</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 1 - Recording for changes in value of")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueChange1 { get; set; }

      /// <summary>Delta event level 2 - active?</summary>    
      [SwaggerSchema("Check whether Delta event level 2 is active or not")]
      [SwaggerExampleValue(false)]
      bool PropDeltaEventActive2 { get; set; }

      /// <summary>Delta event level 2 - value range from</summary>          
      /// <remarks>Defaultwert == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 2 - value range from")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueFrom2 { get; set; }

      /// <summary>Delta event level 2 - value range to</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 2 - value range to")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueTo2 { get; set; }

      /// <summary>Delta event level 2 - Recording for changes in value of</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 2 - Recording for changes in value of")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueChange2 { get; set; }

      /// <summary>Delta event level 3 - active?</summary>  
      [SwaggerSchema("Check whether Delta event level 3 is active or not")]
      [SwaggerExampleValue(false)]
      bool PropDeltaEventActive3 { get; set; }

      /// <summary>Delta event level 3 - value range from</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 3 - value range from")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueFrom3 { get; set; }

      /// <summary>Delta event level 3 - value range to</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 3 - value range to")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueTo3 { get; set; }

      /// <summary>Delta event level 3 - Recording for changes in value of</summary>          
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Delta event level 3 - Recording for changes in value of")]
      [SwaggerExampleValue(0.0)]
      double PropDeltaEventValueChange3 { get; set; }

      #endregion Messwertaufzeichnung

      #region Service

      /// <summary>Maintenance active</summary>
      [SwaggerSchema("Maintenance active")]
      [SwaggerExampleValue(false)]
      bool PropServiceActive
      {
         get; set;
      }

      /// Section maintenance

      /// <summary>Recording type of maintenance; 0 none, 1 binary, 2 duration, 3 switching cycles </summary>
      [SwaggerSchema("Recording type of maintenance")]
      [SwaggerExampleValue(ExtVarDefines.ServiceType.Impuls)]
      ExtVarDefines.ServiceType PropServiceType
      {
         get; set;
      }

      /// <summary>Unit of maintenance variable</summary>
      /// <remarks> Default value == ExtVarDefines.ServiceUnit.Seconds </remarks>
      [SwaggerSchema("Unit of maintenance variable")]
      [SwaggerExampleValue(ExtVarDefines.ServiceUnit.Minutes)]
      ExtVarDefines.ServiceUnit PropServiceUnit
      {
         get; set;
      }

      /// <summary>Overflow value of maintenance counter</summary>             
      /// <remarks>Default value == BaseObjectDefines.NO_VALID</remarks>
      [SwaggerSchema("Overflow value of maintenance counter")]
      [SwaggerExampleValue(0.0)]
      double PropServiceOverflowValue
      {
         get; set;
      }

      #endregion Service

      #region Alert

      // NOT IMPLEMENTED!

      #endregion Alert
   }
}