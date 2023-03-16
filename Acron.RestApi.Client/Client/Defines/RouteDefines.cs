using Acron.RestApi.DataContracts.Data.Response.DayData;
using Acron.RestApi.DataContracts.Data.Response.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Response.YearData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Defines
{
   public class RouteDefines
   {
      #region CTor (Singleton)
      private RouteDefines()
      {
         _routes = new Dictionary<RouteKeys, string>()
         {
            //App Authentication
            { RouteKeys.AuthenticateApp, "Authorization/AuthenticateApp" },
            { RouteKeys.AuthenticateAppRefresh,"Authorization/AuthenticateAppRefresh" },

            //Acron User Authentication
            { RouteKeys.Login,"acron/UserManagement/Login" },
            { RouteKeys.LoginRefresh,"acron/UserManagement/LoginRefresh" },
            { RouteKeys.Logout, "acron/UserManagement/Logout" },

            //acron/data/
            {RouteKeys.GetProcessData,"Acron/Data/ProcessData/GetProcessData" },
            {RouteKeys.GetDayData,"acron/Data/DayData/GetDayData" },
            {RouteKeys.GetIntervalData,"Acron/Data/IntervalData/GetIntervalData" },
            {RouteKeys.GetMonthWeekData,"Acron/Data/MonthWeekData/GetMonthWeekData" },
            {RouteKeys.GetYearData,"Acron/Data/YearData/GetYearData" },

            //acron/Data/HandValRawData
            {RouteKeys.GetHandValRawData, "Acron/Data/HandValRawData/GetHandValRawData" },
            {RouteKeys.WriteHandValComments, "Acron/Data/HandValRawData/WriteHandValComments" },
            {RouteKeys.WriteHandValRawData, "Acron/Data/HandValRawData/WriteHandValRawData" },
            {RouteKeys.WriteHandValRawDataAndInfos, "Acron/Data/HandValRawData/WriteHandValRawDataAndInfos" },

            //acron/general
            { RouteKeys.HasAccess, "acron/general/HasAccess" },
            { RouteKeys.CreateAccess, "acron/general/CreateAccess" },
            { RouteKeys.ReleaseAccess, "acron/general/ReleaseAccess" },

            {RouteKeys.DefaultValues,"acron/general/DefaultValues" },
            {RouteKeys.ObjectInfo,"acron/general/ObjectInfo" },
            {RouteKeys.ObjectInfoEnhanced,"acron/general/ObjectInfoEnhanced" },
            {RouteKeys.GetSubObjects,"acron/general/GetSubObjects" },
            {RouteKeys.ObjectTypes,"acron/general/ObjectTypes" },
            {RouteKeys.TimeZoneIDs,"acron/general/TimeZoneIDs" },

            {RouteKeys.Delete, "acron/General/Delete" },
            {RouteKeys.DoIHaveChanges, "acron/general/DoIHaveChanges" },
            {RouteKeys.GetMyChangedObjects, "acron/general/GetMyChangedObjects" },
            {RouteKeys.Validate, "acron/General/Validate" },
            {RouteKeys.Save,"acron/General/Save" },
            {RouteKeys.DiscardChanges,"acron/General/DiscardChanges" },

            //acron/alert
            { RouteKeys.Alert_GetAll,"acron/Alert/GetAll" },
            { RouteKeys.Alert_GetAllGroups,"acron/Alert/GetAllGroups" },
            { RouteKeys.Alert_GetAllObjects,"acron/Alert/GetAllObjects" },
            { RouteKeys.Alert_Validate,"acron/Alert/Validate" },
            { RouteKeys.Alert_CreateGroup,"acron/Alert/CreateAlertGroup" },
            { RouteKeys.Alert_Create,"acron/alert/CreateAlert" },
            { RouteKeys.Alert_UpdateGroup,"acron/Alert/UpdateAlertGroup" },
            { RouteKeys.Alert_Update,"acron/Alert/UpdateAlert" },
            { RouteKeys.Alert_Delete,"acron/Alert/Delete" },

            //acron/connection
            { RouteKeys.Connection_GetAll,"acron/Connection/GetAll" },
            { RouteKeys.Connection_GetAllGroups,"acron/Connection/GetAllGroups" },
            { RouteKeys.Connection_GetAllObjects,"acron/Connection/GetAllObjects" },
            { RouteKeys.Connection_Validate,"acron/Connection/Validate" },
            //{ RouteKeys.Connection_CreateGroup,"acron/Connection/CreateConnectionGroup" },
            //{ RouteKeys.Connection_Create,"acron/Connection/CreateConnection" },
            //{ RouteKeys.Connection_UpdateGroup,"acron/Connection/UpdateConnectionGroup" },
            //{ RouteKeys.Connection_Update,"acron/Connection/UpdateConnection" },
            //{ RouteKeys.Connection_Delete,"acron/Connection/Delete" },

            //acron/ProcessConnection
            { RouteKeys.ProcessConnection_GetProviderDriver,"acron/ProcessConnection/GetDriver" },
            { RouteKeys.ProcessConnection_GetAll,"acron/ProcessConnection/GetAll" },
            { RouteKeys.ProcessConnection_GetAllGroups,"acron/ProcessConnection/GetAllGroups" },
            { RouteKeys.ProcessConnection_GetAllObjects,"acron/ProcessConnection/GetAllObjects" },
            { RouteKeys.ProcessConnection_Validate,"acron/ProcessConnection/Validate" },
            { RouteKeys.ProcessConnection_CreateProvider,"acron/ProcessConnection/CreateProvider" },
            { RouteKeys.ProcessConnection_CreateGroup,"acron/ProcessConnection/CreateExtVarGroup" },
            { RouteKeys.ProcessConnection_CreateExtVar,"acron/ProcessConnection/CreateExtVar" },
            { RouteKeys.ProcessConnection_UpdateProvider,"acron/ProcessConnection/UpdateProvider" },
            { RouteKeys.ProcessConnection_UpdateGroup,"acron/ProcessConnection/UpdateExtVarGroup" },
            { RouteKeys.ProcessConnection_UpdateExtVar,"acron/ProcessConnection/UpdateExtVar" },
            { RouteKeys.ProcessConnection_Delete,"acron/ProcessConnection/Delete" },

            //acron/ProcessVariables
            { RouteKeys.ProcessVariables_GetAll,"acron/ProcessVariables/GetAll" },
            { RouteKeys.ProcessVariables_GetAllGroups,"acron/ProcessVariables/GetAllGroups" },
            { RouteKeys.ProcessVariables_GetAllObjects,"acron/ProcessVariables/GetAllObjects" },
            { RouteKeys.ProcessVariables_Validate,"acron/ProcessVariables/Validate" },
            { RouteKeys.ProcessVariables_CreateGroup,"acron/ProcessVariables/CreatePvGroup" },
            { RouteKeys.ProcessVariables_CreatePvAuto,"acron/ProcessVariables/CreatePvAuto" },
            { RouteKeys.ProcessVariables_CreatePvManual,"acron/ProcessVariables/CreatePvManual" },
            { RouteKeys.ProcessVariables_CreatePvCalc,"acron/ProcessVariables/CreatePvCalc" },
//            { RouteKeys.ProcessVariables_CreatePvExternal,"acron/ProcessVariables/CreatePvExternal" },
            { RouteKeys.ProcessVariables_UpdateGroup,"acron/ProcessVariables/UpdatePvGroup" },
            { RouteKeys.ProcessVariables_UpdatePvAuto,"acron/ProcessVariables/UpdatePvAuto" },
            { RouteKeys.ProcessVariables_UpdatePvManual,"acron/ProcessVariables/UpdatePvManual" },
            { RouteKeys.ProcessVariables_UpdatePvCalc,"acron/ProcessVariables/UpdatePvCalc" },
//            { RouteKeys.ProcessVariables_UpdatePvExternal,"acron/ProcessVariables/UpdatePvExternal" },
            { RouteKeys.ProcessVariables_Delete,"acron/ProcessVariables/Delete" },

            //acron/Unit
            { RouteKeys.Unit_GetAll,"acron/Unit/GetAll" },
            { RouteKeys.Unit_GetAllBaseUnits,"acron/Unit/GetBaseUnits" },
            { RouteKeys.Unit_GetAllObjects,"acron/Unit/GetAllObjects" },
            { RouteKeys.Unit_Validate,"acron/Unit/Validate" },
            //{ RouteKeys.Unit_CreateBaseUnit,"acron/Unit/CreateBaseUnit" },
            //{ RouteKeys.Unit_CreateUnit,"acron/Unit/CreateUnit" },
            //{ RouteKeys.Unit_UpdateBaseUnit,"acron/Unit/UpdateBaseUnit" },
            //{ RouteKeys.Unit_UpdateUnit,"acron/Unit/UpdateUnit" },
            //{ RouteKeys.Unit_Delete,"acron/Unit/Delete" },
         };
      }


      static RouteDefines()
      {
         Instance = new RouteDefines();
      }

      public static readonly RouteDefines Instance;
      #endregion CTor (Singleton)


      private readonly Dictionary<RouteKeys, string> _routes;
      public Dictionary<RouteKeys, string> Routes { get { return _routes; } }

      public enum RouteKeys
      {
         //App Authentication
         AuthenticateApp,                                   //Authorization/AuthenticateApp
         AuthenticateAppRefresh,                            //Authorization/AuthenticateAppRefresh

         //Acron User Authentication
         Login,                                             //acron/UserManagement/Login
         LoginRefresh,                                      //acron/UserManagement/LoginRefresh
         Logout,                                            //acron/UserManagement/Logout

         //acron/data
         GetProcessData,
         GetDayData,
         GetIntervalData,
         GetMonthWeekData,
         GetYearData,

         //acron/Data/HandValRawData
         GetHandValRawData,
         WriteHandValComments,
         WriteHandValRawData,
         WriteHandValRawDataAndInfos,


         //acron/general
         HasAccess,
         CreateAccess,
         ReleaseAccess,

         DefaultValues,
         ObjectInfo,
         ObjectInfoEnhanced,
         GetSubObjects,
         ObjectTypes,
         TimeZoneIDs,

         Delete,
         DoIHaveChanges,
         GetMyChangedObjects,
         Validate,
         Save,
         DiscardChanges,

         //Alert
         Alert_GetAll,
         Alert_GetAllGroups,
         Alert_GetAllObjects,
         Alert_Validate,
         Alert_CreateGroup,
         Alert_Create,
         Alert_UpdateGroup,
         Alert_Update,
         Alert_Delete,

         // Connection
         Connection_GetAll,
         Connection_GetAllGroups,
         Connection_GetAllObjects,
         Connection_Validate,
         //Connection_CreateGroup,
         //Connection_Create,
         //Connection_UpdateGroup,
         //Connection_Update,
         //Connection_Delete,

         // Process Connection
         ProcessConnection_GetProviderDriver,
         ProcessConnection_GetAll,
         ProcessConnection_GetAllGroups,
         ProcessConnection_GetAllObjects,
         ProcessConnection_Validate,
         ProcessConnection_CreateProvider,
         ProcessConnection_CreateGroup,
         ProcessConnection_CreateExtVar,
         ProcessConnection_UpdateProvider,
         ProcessConnection_UpdateGroup,
         ProcessConnection_UpdateExtVar,
         ProcessConnection_Delete,

         // Process Variables
         ProcessVariables_GetAll,
         ProcessVariables_GetAllGroups,
         ProcessVariables_GetAllObjects,
         ProcessVariables_Validate,
         ProcessVariables_CreateGroup,
         ProcessVariables_CreatePvAuto,
         ProcessVariables_CreatePvManual,
         ProcessVariables_CreatePvCalc,
//         ProcessVariables_CreatePvExternal,
         ProcessVariables_UpdateGroup,
         ProcessVariables_UpdatePvAuto,
         ProcessVariables_UpdatePvManual,
         ProcessVariables_UpdatePvCalc,
//         ProcessVariables_UpdatePvExternal,
         ProcessVariables_Delete,

         // Units
         Unit_GetAll,
         Unit_GetAllBaseUnits,
         Unit_GetAllObjects,
         Unit_Validate,
         //Unit_CreateBaseUnit,
         //Unit_CreateUnit,
         //Unit_UpdateBaseUnit,
         //Unit_UpdateUnit,
         //Unit_Delete,

      }
   }
}
