using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.Client.Client.Request.DataRequests;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Data.Request.ProcessData;
using Acron.RestApi.DataContracts.Data.Response.ProcessData;
using Acron.RestApi.DataContracts.Request.AccessToken;
using Acron.RestApi.DataContracts.Request.UserToken;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acron.RestApi.Client.Frontend
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();

         if (Environment.UserName == "kai" || Environment.UserName == "karsten")
         {
            DoAction();
         }
      }

      RestClient? client;

      private async void DoAction()
      {
         if (System.Environment.UserName == "kai")
         {
            AccessTokenLoginResource accessTokenLoginResource = new AccessTokenLoginResource() { AppName = "test", Password = "test" };
            UserTokenLoginResource userTokenLoginResource = new UserTokenLoginResource() { AcronUser = "logger", Password = "", ClientName = "ClientName", HostOrIp = "localhost", Port = 23456, SessionId = "MeineSessionId" };

            client = new RestClient($"ACRON RestDemoClient", "matrix2-kmk.dataforum.local", 4712, 9.4f, accessTokenLoginResource, userTokenLoginResource, true);
            (bool HasError, string ErrorText) = await client.Connect();
            if (HasError)
            {
               MessageBox.Show($"ClientConnect:\r\n{ErrorText}");
               return;
            }

            //await DoConfigurationConnection();
            //await DoConfigurationUnits();
            //await DoConfigurationAlert();

            await DoConfigurationProcessConnection();
            //await DoConfigurationProcessVariables();

            //await DoConfigurationGeneralAction();

         }
         else if (Environment.UserName == "karsten")
         {
            AccessTokenLoginResource accessTokenLoginResource = new AccessTokenLoginResource() { AppName = "App1Name", Password = "App1Password" };
            UserTokenLoginResource userTokenLoginResource = new UserTokenLoginResource() { AcronUser = "acron", Password = "", ClientName = "MeinClient", HostOrIp = "localhost", Port = 12345, SessionId = "MeineSession1" };

            //KFR CLients
            //client = new RestClient($"ACRON RestDemoClient", "KarstenHomeWork.dataforum.local", 3900, 9.4f, accessTokenLoginResource, userTokenLoginResource, true);
            client = new RestClient($"ACRON RestDemoClient", "enternix-kfr.dataforum.local", 3900, 9.4f, accessTokenLoginResource, userTokenLoginResource, true);


            //AccessTokenLoginResource accessTokenLoginResource = new AccessTokenLoginResource() { AppName = "TestClient", Password = "123456789" };
            //UserTokenLoginResource userTokenLoginResource = new UserTokenLoginResource() { AcronUser = "acron", Password = "", ClientName = "MeinClient", HostOrIp = "localhost", Port = 12345, SessionId = "MeineSession1" };

            //client = new RestClient($"ACRON RestDemoClient", "hebe-msc.dataforum.local", 3900, 9.4f, accessTokenLoginResource, userTokenLoginResource, true);
            //client = new RestClient($"ACRON RestDemoClient", "192.168.168.143", 3900, 9.4f, accessTokenLoginResource, userTokenLoginResource, true);

            (bool HasError, string ErrorText) = await client.Connect();
            if (HasError)
            {
               MessageBox.Show($"ClientConnect:\r\n{ErrorText}");
               return;
            }

            //await DoConfigurationGeneralAction();
            //await DoConfigurationAlert();
            await DoConfigurationProcessConnection();
            //await DoDataAction();
         }
      }

      /// <summary>
      /// Verbindungen
      /// </summary>
      /// <returns></returns>
      private async Task DoConfigurationConnection()
      {
         ConfigurationConnectionRequests request = new ConfigurationConnectionRequests(client);

         #region Get Config

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllResult
            = await request.GetAll(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllGroupsResult
            = await request.GetAllGroups(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllObjectsResult
            = await request.GetAllObjects(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         #endregion Get Config

         var createAccessResult = await request.CreateAccess();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) validateResult
            = await request.ValidateConnections();

         var discardResult = await request.DiscardChanges();

         var releaseAccessResult = await request.ReleaseAccess();

      }

      /// <summary>
      /// Einheiten
      /// </summary>
      /// <returns></returns>
      private async Task DoConfigurationUnits()
      {
         ConfigurationUnitRequests request = new ConfigurationUnitRequests(client);

         #region Get Config

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllResult
            = await request.GetAll(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllGroupsResult
            = await request.GetAllBaseUnits(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllObjectsResult
            = await request.GetAllObjects(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         #endregion Get Config

         var createAccessResult = await request.CreateAccess();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) validateResult
            = await request.ValidateUnits();

         var discardResult = await request.DiscardChanges();

         var releaseAccessResult = await request.ReleaseAccess();

      }

      /// <summary>
      /// Alarme und Zub.
      /// </summary>
      /// <returns></returns>
      private async Task DoConfigurationAlert()
      {
         ConfigurationAlertRequests request = new ConfigurationAlertRequests(client);

         #region Get Config

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllResult
            = await request.GetAll(new DataContracts.Configuration.Request.GetAllAlertsRequestResource() { ShowLockedAlerts = true, SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllGroupsResult
            = await request.GetAllGroups(new DataContracts.Configuration.Request.GetAllAlertsRequestResource() { ShowLockedAlerts = true, SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllObjectsResult
            = await request.GetAllObjects(new DataContracts.Configuration.Request.GetAllAlertsRequestResource() { ShowLockedAlerts = true, SmallObjects = false });

         #endregion Get Config


         #region CrUDe

         var createAccessResult = await request.CreateAccess();

         //         if (createAccessResult.Result != null && createAccessResult.Result.AccessByMe)

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createAlertGroupResult
            = await request.CreateGroup(new List<RestApiAlertGroupObject>() { new RestApiAlertGroupObject() { LongName = "TestAlertLongName", IdParent = 200000000 } });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createAlertResult
            = await request.Create(new List<RestApiAlertObject>() { new RestApiAlertObject() { ShortName = "TestAlertShortname", LongName = "TestAlertLongName", PropState = Interfaces.BaseObjects.AlertDefines.AlertState.Message, IdParent = 200000003 } });

         int id = 200000001 + 3;

         if (!createAlertGroupResult.HasError)
         {
            var item = createAlertGroupResult.Result.Data.FirstOrDefault();
            if (item != null)
            {
               id = item.Id;
            }
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateAlertGroupResult
            = await request.UpdateGroup(new List<RestApiAlertGroupObject>() { new RestApiAlertGroupObject() { Id = id, LongName = "TestAlertLongNameX" } });

         id = 202000000 + 3;
         if (!createAlertResult.HasError)
         {
            var item = createAlertResult.Result.Data.FirstOrDefault();
            if (item != null)
            {
               id = item.Id;
            }
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateAlertResult
            = await request.Update(new List<RestApiAlertObject>() { new RestApiAlertObject() { Id = id, ShortName = "TestAlertShortnameX", LongName = "TestAlertLongNameX", PropState = Interfaces.BaseObjects.AlertDefines.AlertState.Message, IdParent = 200000003 } });

         id = 0;
         if (createAlertResult.Result != null)
         {
            var item = createAlertResult.Result.Data.FirstOrDefault();
            if (item != null)
            {
               id = item.Id;
            }
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) deleteResult
            = await request.Delete(new DeleteRequestResource() { BaseObjectID = id });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) validateResult
            = await request.ValidateAlert();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result) saveResult =
            await request.Save(new SaveRequestResource() { RecalculateFrom = DateTime.UtcNow });


         var discardResult = await request.DiscardChanges();

         var releaseAccessResult = await request.ReleaseAccess();

         #endregion CrUDe
      }

      /// <summary>
      /// Externe Variablen u. Zub.
      /// </summary>
      /// <returns></returns>
      private async Task DoConfigurationProcessConnection()
      {
         ConfigurationProcessConnectionRequests request = new ConfigurationProcessConnectionRequests(client);

         //#region Get Config

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiProviderDriverObject> Result) getProviderResult
            = await request.GetDriver();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllResult
            = await request.GetAll(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllGroupsResult
            = await request.GetAllGroups(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllObjectsResult
            = await request.GetAllObjects(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         //#endregion Get Config

         #region CrUDe

         var createAccessResult = await request.CreateAccess();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createProviderResult
            = await request.CreateProvider(new List<RestApiProviderObject>() { new RestApiProviderObject() { IdParent = 100000000, PropProviderId=10, LongName = "TestProvider001" } });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createGroupResult
            = await request.CreateExtVarGroup(new List<RestApiExtVarGroupObject>() { new RestApiExtVarGroupObject() { IdParent = 100000002, LongName="CreatedExtVarGroup"  } });

         int id = 102000000 + 1;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createExtVarResult
            = await request.CreateExtVar(new List<RestApiExtVarObject>() { new RestApiExtVarObject() { IdParent = id, ShortName = "TestExtVarShortname", LongName = "TestExtVarLongName" } });

         id = 100000001 + 1;
         if (createProviderResult.Result != null)
         {
            var item = createProviderResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateProviderResult
            = await request.UpdateProvider(new List<RestApiProviderObject>() { new RestApiProviderObject() { Id = id, LongName = "TestLongNameX" } });

         id = 102000000 + 4;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateGroupResult
            = await request.UpdateExtVarGroup(new List<RestApiExtVarGroupObject>() { new RestApiExtVarGroupObject() { Id = id, LongName = "TestLongNameX" } });

         id = 104000000 + 2;
         if (createExtVarResult.Result != null)
         {
            var item = createExtVarResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateExtVarResult
            = await request.UpdateExtVar(new List<RestApiExtVarObject>() { new RestApiExtVarObject() { Id = id, ShortName = "TestAlertShortnameX", LongName = "TestAlertLongNameX" } });

         id = 0;
         if (createExtVarResult.Result != null)
         {
            var item = createExtVarResult.Result.Data.FirstOrDefault();
            if (item != null)
            {
               id = item.Id;
            }
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) deleteResult
            = await request.Delete(new DeleteRequestResource() { BaseObjectID = id });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) validateResult
            = await request.ValidateProcessConnection();

         var discardResult = await request.DiscardChanges();

         var releaseAccessResult = await request.ReleaseAccess();

         #endregion CrUDe
      }

      private async Task DoConfigurationProcessVariables()
      {
         ConfigurationProcessVariablesRequests request = new ConfigurationProcessVariablesRequests(client);

         #region Get Config

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllResult
            = await request.GetAll(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllGroupsResult
            = await request.GetAllGroups(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getAllObjectsResult
            = await request.GetAllObjects(new DataContracts.Configuration.Request.GetAllRequestResource() { SmallObjects = false });

         #endregion Get Config

         #region CrUDe

         var createAccessResult = await request.CreateAccess();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createGroupResult
            = await request.CreatePvGroup(new List<RestApiPvVarGroupObject>() { new RestApiPvVarGroupObject() { IdParent = 300000000, LongName = "TestLongName" } });

         int id = 300000001 + 1;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvAutoResult
            //= await request.CreatePvAuto(new List<RestApiPvAutoObject>() { new RestApiPvAutoObject() { IdParent = id, ShortName = "TestAutoShortname", LongName = "TestAutoLongName" } });
            = await request.CreatePvAuto(new List<RestApiPvAutoObject>() { new RestApiPvAutoObject() { ShortName = "TestAutoShortname", LongName = "TestAutoLongName" } });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvManResult
            = await request.CreatePvManual(new List<RestApiPvManualObject>() { new RestApiPvManualObject() { IdParent = id, ShortName = "TestManualShortname", LongName = "TestManualLongName" } });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvCalcResult
            = await request.CreatePvCalc(new List<RestApiPvCalcObject>() { new RestApiPvCalcObject() { IdParent = id, ShortName = "TestCalcShortname", LongName = "TestCalcLongName" } });

         id = 300000001 + 2;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateGroupResult
            = await request.UpdatePvGroup(new List<RestApiPvVarGroupObject>() { new RestApiPvVarGroupObject() { Id = id, LongName = "TestLongNameX" } });

         id = 302000000 + 3;
         if (createPvAutoResult.Result != null)
         {
            var item = createPvAutoResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updPvAutoResult
            = await request.UpdatePvAuto(new List<RestApiPvAutoObject>() { new RestApiPvAutoObject() { Id = id, LongName = "TestAutoLongNameXYZ" } });

         id = 302000000 + 3;
         if (createPvManResult.Result != null)
         {
            var item = createPvManResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updPvManResult
            = await request.UpdatePvManual(new List<RestApiPvManualObject>() { new RestApiPvManualObject() { Id = id, LongName = "TestManualLongNameXYZ" } });

         id = 302000000 + 3;
         if (createPvCalcResult.Result != null)
         {
            var item = createPvCalcResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updPvCalcResult
            = await request.UpdatePvCalc(new List<RestApiPvCalcObject>() { new RestApiPvCalcObject() { Id = id, LongName = "TestCalcLongNameXYZ" } });

         id = 0;
         if (createPvAutoResult.Result != null)
         {
            var item = createPvAutoResult.Result.Data.FirstOrDefault();
            if (item != null)
            {
               id = item.Id;
            }
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) deleteResult
            = await request.Delete(new DeleteRequestResource() { BaseObjectID = id });

         var discardResult = await request.DiscardChanges();

         var releaseAccessResult = await request.ReleaseAccess();

         #endregion CrUDe

      }

      /// <summary>
      /// Allgemeine Aktionen
      /// </summary>
      /// <returns></returns>
      private async Task DoConfigurationGeneralAction()
      {
         ConfigurationGeneralRequests configRequest = new ConfigurationGeneralRequests(client);

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) hasAccessResult1 = await configRequest.HasAccess();
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResult = await configRequest.CreateAccess();
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) hasAccessResult2 = await configRequest.HasAccess();
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResult = await configRequest.ReleaseAccess();
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResult1 = await configRequest.ReleaseAccess();
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) hasAccessResult3 = await configRequest.HasAccess();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestApiPvManualObject Result) defaultValuesResult
            = await configRequest.DefaultValues<RestApiPvManualObject>();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestApiBaseObject Result) objectInfoResult
            = await configRequest.ObjectInfo(new DataContracts.Configuration.Request.ObjectInfoRequestResource() { BaseObjectID = 302000001 });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ObjectInfoEnhanced Result) objectInfoEnhancedResult
            = await configRequest.ObjectInfoEnhanced(new DataContracts.Configuration.Request.ObjectInfoEnhancedRequestResource()
            { BaseObjectID = 104000001, ShowObjectUsages = true, ShowReferencedObjects = true });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getSubObjectsResult
            = await configRequest.GetSubObjects(new DataContracts.Configuration.Request.GetSubObjectsRequestResource()
            { BaseObjectID = 300000002, OnlyDirectChilds = false, SmallObjects = false, WithFolder = true });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestObjectInfo> Result) getObjectTypesResult = await configRequest.ObjectTypes();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<TimeZoneIDItem> Result) getTimeZoneIDsResult = await configRequest.GetTimeZoneIDs();


         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

            //### Delete braucht eine richtige info wieso nicht gelöscht werden kann > Enum mit Grund (BlockedBy, NoRemoveableObject) und gegebenfalls eine Liste mit den BlockBy Objekten. Wieso kann ich nicht mehrer löschen ?
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) deleteResult = await configRequest.Delete(new DataContracts.Configuration.Request.DeleteRequestResource() { BaseObjectID = 302000001 });
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }


         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

            //### Wieso braucht HasChanged ein WriteAccess. Wieso gibt es ohne WriteAccess ein AcOK zurück und bei Save ein BadRequest ?
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, HasChangedInfo Result) hasChangedResult = await configRequest.DoIHaveChanges();
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }


         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

            //### Wieso braucht GetChangedObjects ein WriteAccess. BadRequest wenn es keine Änderungen gibt ?
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ChangedObjectInfo> Result) getChangedObjectsResult = await configRequest.GetMyChangedObjects();
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }



         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) validateResult = await configRequest.Validate();
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }

         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

            //### Save sollte kein BadRequest zurückgeben wenn es nichts zu speichern gibt.
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result) SaveResult = await configRequest.Save(new DataContracts.Configuration.Request.SaveRequestResource() { RecalculateFrom = DateTime.UtcNow });
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }
      }

      private async Task DoDataAction()
      {
         //DayDataRequests dayDataRequest = new DayDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DayDataResult Result) getDayDataResult
         //   = await dayDataRequest.GetDayData(new GetDayDataRequestResource()
         //   {
         //      DayType = Interfaces.Data.Request.DayData.DayTypes.DBN_DAY_1,
         //      FromTime = DateTime.UtcNow - TimeSpan.FromDays(30),
         //      ToTime = DateTime.UtcNow,
         //      PVDescriptions = new List<GetDayDataPVDescription>()
         //      {
         //         new GetDayDataPVDescription() { PVID = 302000006, DayWhat = new DayWhat(){  } },
         //         new GetDayDataPVDescription() { PVID = 302000007, DayWhat = new DayWhat(){  } },
         //      }
         //   });

         //IntervalDataRequests intervalDataRequests = new IntervalDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, IntervalDataResult Result) intervalDataResult
         //   = await intervalDataRequests.GetIntervalData(new DataContracts.Data.Request.IntervalData.GetIntervalDataRequestResource()
         //   {
         //      IntervalType = Interfaces.Data.Request.IntervalData.IntervalTypes.DBN_INT_1,
         //      FromTime = DateTime.UtcNow - TimeSpan.FromDays(30),
         //      ToTime = DateTime.UtcNow,
         //      PVDescriptions = new List<DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription>()
         //      {
         //         new DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription(){ PVID = 302000006, IntervalWhat = new DataContracts.Data.Request.IntervalData.IntervalWhat(){ } },
         //         new DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription(){ PVID = 302000007, IntervalWhat = new DataContracts.Data.Request.IntervalData.IntervalWhat(){ IDAT_IVAL=true } },
         //      }
         //   });

         //ProcessDataRequests processDataRequests = new ProcessDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ProcessDataBase> Result) processDataResult
         //   = await processDataRequests.GetProcessData(new GetProcessDataRequestResource()
         //   {
         //      FromTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500)),
         //      ToTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromHours(1)),
         //      PVIDs = new List<GetProcessDataPVDescription>()
         //      {
         //         new GetProcessDataPVDescription()
         //         {
         //            DBP_ReadType = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DBP_ReadTypes.DBP_NORMAL,
         //            PVID = 302000006,
         //            ValueTypes = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Values |
         //                         Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Minima |
         //                         Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Maxima
         //         },
         //         new GetProcessDataPVDescription()
         //         {
         //            DBP_ReadType = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DBP_ReadTypes.DBP_NORMAL,
         //            PVID = 302000029,
         //            ValueTypes = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Values |
         //                         Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Minima |
         //                         Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Maxima
         //         }
         //      }
         //   });

         ////MonthWeekDataRequest > Month
         //MonthWeekDataRequests monthWeekDataRequests_Month = new MonthWeekDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, MonthWeekDataResult Result) monthWeekDataResult_Month
         //   = await monthWeekDataRequests_Month.GetMonthWeekData(new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataRequestResource()
         //   {
         //      MonthWeekType = Interfaces.Data.Request.MonthWeekData.MonthWeekTypes.DBN_MONTH,
         //      FromTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500)),
         //      ToTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(50)),
         //      PVDescriptions = new List<DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription>()
         //      {
         //         new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription() { PVID = 302000006, MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){ } },
         //         new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription() { PVID = 302000029, MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){ } },
         //      }
         //   });

         ////MonthWeekDataRequest > Week
         //MonthWeekDataRequests monthWeekDataRequests_Week = new MonthWeekDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, MonthWeekDataResult Result) monthWeekDataResult_Week
         //   = await monthWeekDataRequests_Week.GetMonthWeekData(new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataRequestResource()
         //   {
         //      MonthWeekType = Interfaces.Data.Request.MonthWeekData.MonthWeekTypes.DBN_WEEK,
         //      FromTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500)),
         //      ToTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(50)),
         //      PVDescriptions = new List<DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription>()
         //      {
         //         new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription() { PVID = 302000006, MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){ } },
         //         new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription() { PVID = 302000029, MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){ } },
         //      }
         //   });


         //YearDataRequests yearDataRequests_Week = new YearDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.YearData.YearDataResult Result) yearDataResult
         //   = await yearDataRequests_Week.GetYearData(new DataContracts.Data.Request.YearData.GetYearDataRequestResource()
         //   {
         //      FromTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500)),
         //      ToTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(150)),
         //      YearType = Interfaces.Data.Request.YearData.YearTypes.DBN_YEAR_MONTH,
         //      PVDescriptions = new List<DataContracts.Data.Request.YearData.GetYearDataPVDescription>()
         //      {
         //         new DataContracts.Data.Request.YearData.GetYearDataPVDescription(){ PVID = 302000006, YearWhat = new DataContracts.Data.Request.YearData.YearWhat(){ } },
         //         new DataContracts.Data.Request.YearData.GetYearDataPVDescription(){ PVID = 302000007, YearWhat = new DataContracts.Data.Request.YearData.YearWhat(){ } },
         //         new DataContracts.Data.Request.YearData.GetYearDataPVDescription(){ PVID = 302000029, YearWhat = new DataContracts.Data.Request.YearData.YearWhat(){ } },
         //      }
         //   });



         //HandValRawDataRequests handValRawDataRequest = new HandValRawDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.GetHandValRawData.GetHandValRawDataResult Result) handValRawDataRequestResult
         //   = await handValRawDataRequest.GetHandValRawData(new DataContracts.Data.Request.HandValRawData.GetHandValRawData.GetHandValRawDataRequestResource()
         //   {
         //      FromTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500)),
         //      ToTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(10)),
         //      HandValReadType = Interfaces.Data.Request.HandValRawData.GetHandValRawData.HANDVALREADTYPES.READ_ALL_PERDAYS,

         //      PVs = new List<int> { 302000001, 302000005, 302000013 },
         //   });


         //HandValRawDataRequests handValRawDataRequest = new HandValRawDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.WriteHandValRawData.WriteHandValRawDataResult Result) writeHandValRawDataResult
         //   = await handValRawDataRequest.WriteHandValRawData(new DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataRequestResource()
         //   {
         //      DayTimeStamp = new DateTimeOffset(new DateTime(2022,10,3), TimeSpan.FromHours(1)),
         //      PVDescriptions = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataPVDescription>()
         //      {
         //         new DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataPVDescription()
         //         {
         //            PVID = 302000005,
         //            Provals = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataProval>() 
         //            { 
         //               new DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataProval() 
         //               { 
         //                  //TimeStamp = new DateTimeOffset(new DateTime(2022,10,5) + TimeSpan.FromMinutes(1) + TimeSpan.FromMilliseconds(333)),                                                      
         //                  TimeStamp = new DateTimeOffset(new DateTime(2022,10,3), TimeSpan.FromHours(1)),// + TimeSpan.FromMilliseconds(333)),
         //                   Value = 12,
         //               }
         //            }
         //         }
         //      }
         //   });


         //HandValRawDataRequests handValRawDataRequest = new HandValRawDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.WriteHandValComments.WriteHandValCommentsResult Result) writeHandValCommentsResult
         //   = await handValRawDataRequest.WriteHandValComments(new DataContracts.Data.Request.HandValRawData.WriteHandValComments.WriteHandValCommentsRequestResouce()
         //   {
         //      TimeStamp = new DateTimeOffset(new DateTime(2022, 10, 3), TimeSpan.FromHours(1)),
         //      AVComKind = Interfaces.Data.Request.HandValRawData.WriteHandValComments.AVComKinds.AVCOMMENT_DAY,
         //      PVDescriptions = new List<DataContracts.Data.Request.HandValRawData.WriteHandValComments.WriteHandValCommentsPVDescription>()
         //       {
         //          new DataContracts.Data.Request.HandValRawData.WriteHandValComments.WriteHandValCommentsPVDescription()
         //          {
         //              PVID=302000005,
         //              Comment = "ExampleComment"
         //          }
         //       }
         //   });


         //HandValRawDataRequests handValRawDataRequest = new HandValRawDataRequests(client);
         //(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfoResult Result) writeHandValRawDataAndInfoResult
         //   = await handValRawDataRequest.WriteHandValRawDataAndInfo(new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfosRequestResource()
         //   {
         //      DayTimeStamp = new DateTimeOffset(new DateTime(2022, 10, 3), TimeSpan.FromHours(1)),
         //      PVDescriptions = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfosPVDescription>()
         //      {
         //         new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfosPVDescription()
         //         {
         //             PVID=302000005,
         //             Values = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfos>()
         //             {
         //                new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfos()
         //                {
         //                   TimeStamp = new DateTimeOffset(new DateTime(2022,10,3), TimeSpan.FromHours(1)),// + TimeSpan.FromMilliseconds(333)),
         //                   Value = 99,
         //                   Key = "Schlüssel",
         //                   ProInfoFlag = new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfoFlag(){ HDAT_KEYVALID = true }
         //                }
         //             }

         //         }
         //      }
         //   });


      }
   }
}
