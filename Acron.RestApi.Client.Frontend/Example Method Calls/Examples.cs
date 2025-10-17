using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.Client.Client.Request.DataRequests;
using Acron.RestApi.Client.Frontend.Models;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources;
using Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Data.Request.DayData;
using Acron.RestApi.DataContracts.Data.Request.ProcessData;
using Acron.RestApi.DataContracts.Data.Response.DayData;
using Acron.RestApi.DataContracts.Data.Response.IntervalData;
using Acron.RestApi.DataContracts.Data.Response.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Response.ProcessData;
using Acron.RestApi.DataContracts.Request.AccessToken;
using Acron.RestApi.DataContracts.Request.UserToken;
using Acron.RestApi.DataContracts.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Example_Method_Calls
{
   

   internal static class Examples
   {
      const string DefaultSerialisationString = "C:/ProgramData/Acron/APIDemoClient/Serialisation";
      static RestClient? client;
      /// <summary>
      /// Entry Point, please uncomment the sections you want to test
      /// All Methods written with the assumption of using the DemoPlant
      /// </summary>
      /// 

      public static async void DoAction()
      {
         ///Replace the dummy AppName and Password with the one set in your REST API
         AccessTokenLoginResource accessTokenLoginResource = new AccessTokenLoginResource()
         {
            AppName = string.Empty,
            Password = string.Empty,
         };

         ///Replace the dummy values with your user credentials
         UserTokenLoginResource userTokenLoginResource = new UserTokenLoginResource()
         {
            AcronUser = string.Empty,
            Password = string.Empty,
            ClientName = string.Empty,
            HostOrIp = string.Empty,
            Port = 3900,
            SessionId = string.Empty
         };

         string url =string.Empty;
         string clientName = string.Empty;
         uint port = 0;
         float version = 9.4f;
         bool keepAlive = true;


         if (string.IsNullOrEmpty(url))
            client = CreateClient();
         else
            client = new RestClient(clientName,url,port,version,accessTokenLoginResource, userTokenLoginResource, keepAlive);

         (bool HasError, string ErrorText) = await client.Connect();
         if (HasError)
         {
            MessageBox.Show($"ClientConnect:\r\n{ErrorText}");
            return;
         }

         //await DoConfigurationConnection();
         //await DoConfigurationUnits();
         //await DoConfigurationAlert();

         //await DoConfigurationProcessConnection();
         //await DoConfigurationProcessVariables();
         await DoCreateProcessVariablesSteps();


         //await DoConfigurationGeneralAction();

         //await DoDataAction();
      }


      private static Login DeserializeLogin()
      {
         string json = File.ReadAllText(DefaultSerialisationString + "/Login.json");
         return JsonConvert.DeserializeObject<Login>(json, new JsonSerializerSettings()
         {
            TypeNameHandling = TypeNameHandling.Objects,
         }) ?? new();
      }

      private static RestClient CreateClient()
      {
         Login myLogin = new();
         if (File.Exists(DefaultSerialisationString + "/Login.json"))
         {
            myLogin = DeserializeLogin();
         }
         else
         {
            myLogin = new()
            {
               AppName = string.Empty,
               AppPassword = string.Empty,
               ClientPort = 0,
               AcronUser = string.Empty,
               SessionID = string.Empty,
               ClientName = string.Empty,
               HostName = string.Empty,
               HostOrIP = string.Empty,
               Port = 3900,
               UserPassword = string.Empty,
               Version = 9.4f,
            };
         }

         AccessTokenLoginResource appTokenRessource = new()
         {
            AppName = myLogin.AppName,
            Password = myLogin.AppPassword,
         };
         UserTokenLoginResource userTokenRessource = new()
         {
            AcronUser = myLogin.AcronUser ?? string.Empty,
            Password = myLogin.UserPassword ?? string.Empty,
            ClientName = myLogin.ClientName ?? string.Empty,
            HostOrIp = myLogin.HostOrIP ?? string.Empty,
            Port = (int)myLogin.ClientPort,
            SessionId = myLogin.SessionID ?? string.Empty,
         };

         return new RestClient(myLogin.ClientName, myLogin.HostName, myLogin.Port, myLogin.Version, appTokenRessource, userTokenRessource);

      }


      /// <summary>
      /// Connections
      /// </summary>
      /// <returns></returns>
      private static async Task DoConfigurationConnection()
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
      /// Units
      /// </summary>
      /// <returns></returns>
      private static async Task DoConfigurationUnits()
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
      /// Alarms and accessories
      /// </summary>
      /// <returns></returns>
      private static async Task DoConfigurationAlert()
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

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createAlertGroupResult
            = await request.CreateGroup(new List<CreateAlertGroupObjectRequestResource>(){ new CreateAlertGroupObjectRequestResource()
               {
                  LongName = "TestAlertLongName", IdParent = 200000000
               }
            });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createAlertResult
            = await request.Create(new List<CreateAlertObjectRequestResource>() { new CreateAlertObjectRequestResource()
               {
                  ShortName = "TestAlertShortname", LongName = "TestAlertLongName",
                  PropState = Interfaces.BaseObjects.AlertDefines.AlertState.Message,
                  IdParent = 200000003
               }
            });

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
            = await request.UpdateGroup(new List<UpdateAlertGroupObjectRequestResource>() { new UpdateAlertGroupObjectRequestResource()
               {
                  Id = id,
                  LongName = "TestAlertLongNameX"
               }
            });

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
            = await request.Update(new List<UpdateAlertObjectRequestResource>() { new UpdateAlertObjectRequestResource()
               {
                  Id = id,
                  ShortName = "TestAlertShortnameX",
                  LongName = "TestAlertLongNameX",
                  PropState = Interfaces.BaseObjects.AlertDefines.AlertState.Message,
                  IdParent = 200000003
               }
            });

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
      /// External variables and accessories
      /// </summary>
      /// <returns></returns>
      private static async Task DoConfigurationProcessConnection()
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

         #region CrUD

         var createAccessResult = await request.CreateAccess();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createProviderResult
            = await request.CreateProvider(new List<CreateProviderObjectRequestResource>() { new CreateProviderObjectRequestResource()
               {
                  IdParent = 100000000,
                  PropProviderId = 10,
                  LongName = "TestProvider001"
               }
            });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createGroupResult
            = await request.CreateExtVarGroup(new List<CreateExtVarGroupObjectRequestResource>() { new CreateExtVarGroupObjectRequestResource()
               {
                  IdParent = 100000002,
                  LongName = "CreatedExtVarGroup"
               }
            });

         int id = 102000000 + 1;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createExtVarResult
            = await request.CreateExtVar(new List<CreateExtVarObjectRequestResource>() { new CreateExtVarObjectRequestResource()
               {
                  IdParent = id,
                  ShortName = "TestExtVarShortname",
                  LongName = "TestExtVarLongName"
               }
            });

         id = 100000001 + 1;
         if (createProviderResult.Result != null)
         {
            var item = createProviderResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }
        /* (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateProviderResult
            = await request.UpdateProvider(new List<RestApiProviderObject>() { new RestApiProviderObject()
               {
                  Id = id,
                  LongName = "TestLongNameX"
               }
            });
        */
         id = 102000000 + 4;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateGroupResult
            = await request.UpdateExtVarGroup(new List<UpdateExtVarGroupObjectRequestResource>() { new UpdateExtVarGroupObjectRequestResource()
               {
                  Id = id,
                  LongName = "TestLongNameX"
               }
            });

         id = 104000000 + 2;
         if (createExtVarResult.Result != null)
         {
            var item = createExtVarResult.Result.Data.FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateExtVarResult
            = await request.UpdateExtVar(new List<UpdateExtVarObjectRequestResource>() { new UpdateExtVarObjectRequestResource()
               {
                  Id = id,
                  ShortName = "TestAlertShortnameX",
                  LongName = "TestAlertLongNameX"
               }
            });

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

      /// <summary>
      /// External variables and accessories
      /// </summary>
      /// <returns></returns>
      private static async Task DoConfigurationProcessVariables()
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

         if (createAccessResult.HasError)
            return;

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createGroupResult
            = await request.CreatePvGroup(new List<CreatePvVarGroupObjectRequestResource>() { new CreatePvVarGroupObjectRequestResource()
               {
                  IdParent = 300000000,
                  LongName = "TestLongName"
               }
            });

         int id = 300000001 + 1;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvAutoResult
            = await request.CreatePvAuto(new List<CreatePvAutoObjectRequestResource>() { new CreatePvAutoObjectRequestResource()
               {
                  IdParent = id,
                  ShortName = "TestAutoShortname",
                  LongName = "TestAutoLongName"
               }
            });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvManResult
            = await request.CreatePvManual(new List<CreatePvManualObjectRequestResource>() { new CreatePvManualObjectRequestResource()
               {
                  IdParent = id,
                  ShortName = "TestManualShortname",
                  LongName = "TestManualLongName"
               }
            });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvCalcResult
            = await request.CreatePvCalc(new List<CreatePvCalcObjectRequestResource>() { new CreatePvCalcObjectRequestResource()
               {
                  IdParent = id,
                  ShortName = "TestCalcShortname",
                  LongName = "TestCalcLongName"
               }
            });

         id = 300000001 + 2;
         if (createGroupResult.Result != null)
         {
            var item = createGroupResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateGroupResult
            = await request.UpdatePvGroup(new List<UpdatePvVarGroupObjectRequestResource>() { new UpdatePvVarGroupObjectRequestResource()
               {
                  Id = id,
                  LongName = "TestLongNameX"
               }
            });

         id = 302000000 + 3;
         if (createPvAutoResult.Result != null)
         {
            var item = createPvAutoResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updPvAutoResult
            = await request.UpdatePvAuto(new List<UpdatePvAutoObjectRequestResource>() { new UpdatePvAutoObjectRequestResource()
               {
                  Id = id,
                  LongName = "TestAutoLongNameXYZ"
               }
            });

         id = 302000000 + 3;
         if (createPvManResult.Result != null)
         {
            var item = createPvManResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updPvManResult
            = await request.UpdatePvManual(new List<UpdatePvManualObjectRequestResource>() { new UpdatePvManualObjectRequestResource()
               {
                  Id = id,
                  LongName = "TestManualLongNameXYZ"
               }
            });

         id = 302000000 + 3;
         if (createPvCalcResult.Result != null)
         {
            var item = createPvCalcResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
            if (item != null)
               id = item.Id;
         }

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updPvCalcResult
            = await request.UpdatePvCalc(new List<UpdatePvCalcObjectRequestResource>() { new UpdatePvCalcObjectRequestResource()
               { 
                  Id = id,
                  LongName = "TestCalcLongNameXYZ"
               }
            });

         id = 0;
         if (createPvAutoResult.Result != null)
         {
            var item = createPvAutoResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
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

      private static async Task DoCreateProcessVariablesSteps()
      {
         ConfigurationProcessVariablesRequests request = new ConfigurationProcessVariablesRequests(client);

         #region CrUDe

         var createAccessResult = await request.CreateAccess();

         if (createAccessResult.HasError)
         {
            return;
         }

         string grpNameDef = "TestGrpName";
         string pvAutoNameDef = "TestPvAuto";
         string pvManNameDef = "TestPvMan";
         string pvCalcNameDef = "TestPvCalc";

         string name = string.Empty;
         bool breakMainLoop = false;
         bool doLoop = false;

         for (int idx = 1; idx <= 25; idx++)
         {

            #region Create

            name = string.Format("{0}_{1:D3}", grpNameDef, idx);

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createGroupResult = (false, "", new ApiControllerResponseBase(), new CreateUpdateResult());

            doLoop = true;
            while (doLoop)
            {
               doLoop = false;
            
               createGroupResult = await request.CreatePvGroup(new List<CreatePvVarGroupObjectRequestResource>() { new CreatePvVarGroupObjectRequestResource() { IdParent = 300000000, LongName = name } });

               if (createGroupResult.HasError)
               {
                  if (createGroupResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {
                     switch (createGroupResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }
               }
            }

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) validate;
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result) save;

            validate = await request.Validate();
            save = await request.Save(new SaveRequestResource());

            int id = 300000001 + 1;
            if (createGroupResult.Result != null)
            {
               var item = createGroupResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
               if (item != null)
                  id = item.Id;
            }

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvAutoResult = (false, "", new ApiControllerResponseBase(), new CreateUpdateResult());

            name = string.Format("{0}_{1:D3}", pvAutoNameDef, idx);

            doLoop = true;
            while (doLoop)
            {
               doLoop = false;
               createPvAutoResult = await request.CreatePvAuto(new List<CreatePvAutoObjectRequestResource>() { new CreatePvAutoObjectRequestResource() { IdParent = id, ShortName = name, LongName = name } });

               if (createPvAutoResult.HasError)
               {
                  if (createPvAutoResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {
                     switch (createPvAutoResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }
               }
            }

            if (breakMainLoop)
               break;

            validate = await request.Validate();
            save = await request.Save(new SaveRequestResource());

            name = string.Format("{0}_{1:D3}", pvManNameDef, idx);

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvManResult = (false, "", new ApiControllerResponseBase(), new CreateUpdateResult());

            doLoop = true;
            while (doLoop)
            {
               doLoop = false;

               createPvManResult = await request.CreatePvManual(new List<CreatePvManualObjectRequestResource>() { new CreatePvManualObjectRequestResource() { IdParent = id, ShortName = name, LongName = name } });

               if (createPvManResult.HasError)
               {
                  if (createPvManResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {

                     switch (createPvManResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }
               }
            }

            if (breakMainLoop)
               break;

            validate = await request.Validate();
            save = await request.Save(new SaveRequestResource());

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) createPvCalcResult = (false, "", new ApiControllerResponseBase(), new CreateUpdateResult());

            name = string.Format("{0}_{1:D3}", pvCalcNameDef, idx);

            doLoop = true;

            while (doLoop)
            {
               doLoop = false;

               createPvCalcResult = await request.CreatePvCalc(new List<CreatePvCalcObjectRequestResource>() { new CreatePvCalcObjectRequestResource() { IdParent = id, ShortName = name, LongName = name } });

               if (createPvCalcResult.HasError)
               {
                  if (createPvCalcResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {
                     switch (createPvCalcResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }
               }
            }

            if (breakMainLoop)
               break;

            validate = await request.Validate();
            save = await request.Save(new SaveRequestResource());

            #endregion Create

            #region Update

            var grpItem = createGroupResult.Result.Data.Where(res => res.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success).FirstOrDefault();
            if (grpItem == null)
               break;

            id = grpItem.Id;
            name = string.Format("{0}_{1:D3}_xyz", grpNameDef, idx);

            doLoop = true;

            while (doLoop)
            {
               doLoop = false;

               (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updateGroupResult
               = await request.UpdatePvGroup(new List<UpdatePvVarGroupObjectRequestResource>() { new UpdatePvVarGroupObjectRequestResource() { Id = id, LongName = name } });

               if (updateGroupResult.HasError)
               {
                  if (updateGroupResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {

                     switch (updateGroupResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }
               }
            }

            if (breakMainLoop)
               break;

            var pvAutoItem = createPvAutoResult.Result.Data.FirstOrDefault(d => d.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success);
            if (pvAutoItem == null)
               break;

            id = pvAutoItem.Id;
            name = string.Format("{0}_{1:D3}_xyz", pvAutoNameDef, idx);

            doLoop = true;

            while (doLoop)
            {
               doLoop = false;

               (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updatePvAutoResult
               = await request.UpdatePvAuto(new List<UpdatePvAutoObjectRequestResource>() { new UpdatePvAutoObjectRequestResource() { Id = id, ShortName = name, LongName = name } });

               if (updatePvAutoResult.HasError)
               {
                  if (updatePvAutoResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {

                     switch (updatePvAutoResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }

               }
            }

            if (breakMainLoop)
               break;

            validate = await request.Validate();
            save = await request.Save(new SaveRequestResource());

            var pvManItem = createPvManResult.Result.Data.FirstOrDefault(d => d.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success);
            if (pvManItem == null)
               break;

            id = pvManItem.Id;
            name = string.Format("{0}_{1:D3}_xyz", pvManNameDef, idx);

            doLoop = true;

            while (doLoop)
            {
               doLoop = false;

               (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updatePvManResult
               = await request.UpdatePvManual(new List<UpdatePvManualObjectRequestResource>() { new UpdatePvManualObjectRequestResource() { Id = id, ShortName = name, LongName = name } });

               if (updatePvManResult.HasError)
               {
                  if (updatePvManResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {

                     switch (updatePvManResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }
               }
            }

            if (breakMainLoop)
               break;

            validate = await request.Validate();
            save = await request.Save(new SaveRequestResource());

            var pvCalcItem = createPvCalcResult.Result.Data.FirstOrDefault(d => d.State == Interfaces.Configuration.Response.CreateUpdateResultStates.Success);
            if (pvCalcItem == null)
               break;

            id = pvCalcItem.Id;
            name = string.Format("{0}_{1:D3}_xyz", pvCalcNameDef, idx);

            doLoop = true;

            while (doLoop)
            {
               doLoop = false;

               (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) updatePvCalcResult
               = await request.UpdatePvCalc(new List<UpdatePvCalcObjectRequestResource>() { new UpdatePvCalcObjectRequestResource() { Id = id, ShortName = name, LongName = name } });

               if (updatePvCalcResult.HasError)
               {
                  if (updatePvCalcResult.ResponseBase.HttpStatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
                  {
                     doLoop = true;
                     Thread.Sleep(2500);
                  }
                  else
                  {
                     switch (updatePvCalcResult.ResponseBase.ApiActionResult)
                     {
                        case Interfaces.Configuration.GlobalConfigDefines.ConfigDefines.ApiActionResult.WaitingForReload:
                           doLoop = true;
                           Thread.Sleep(2500);
                           break;
                        default:
                           doLoop = false;
                           breakMainLoop = true;
                           break;
                     }
                  }

               }
            }

            if (breakMainLoop)
               break;

            validate = await request.Validate();
            save = await request.Save(new SaveRequestResource());

            #endregion Update

         }

         var discardChangesResult = await request.DiscardChanges();

         var releaseAccessResult = await request.ReleaseAccess();

         #endregion CrUDe

      }


      /// <summary>
      /// General Actions
      /// </summary>
      /// <returns></returns>
      private static async Task DoConfigurationGeneralAction()
      {
         ConfigurationGeneralRequests configRequest = new ConfigurationGeneralRequests(client);

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) hasAccessResult1 = await configRequest.HasAccess();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestApiPvManualObject Result) defaultValuesResult
            = await configRequest.DefaultValues<RestApiPvManualObject>();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestApiBaseObject Result) objectInfoResult
            = await configRequest.ObjectInfo(new DataContracts.Configuration.Request.ObjectInfoRequestResource() { BaseObjectID = 302000001 });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ObjectInfoEnhanced Result) objectInfoEnhancedResult
            = await configRequest.ObjectInfoEnhanced(new DataContracts.Configuration.Request.ObjectInfoEnhancedRequestResource()
            {
               BaseObjectID = 104000001,
               ShowObjectUsages = true,
               ShowReferencedObjects = true
            });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) getSubObjectsResult
            = await configRequest.GetSubObjects(new DataContracts.Configuration.Request.GetSubObjectsRequestResource()
            { BaseObjectID = 300000002, OnlyDirectChilds = false, SmallObjects = false, WithFolder = true });

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestObjectInfo> Result) getObjectTypesResult = await configRequest.ObjectTypes();

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<TimeZoneIDItem> Result) getTimeZoneIDsResult = await configRequest.GetTimeZoneIDs();


         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) deleteResult = await configRequest.Delete(new DataContracts.Configuration.Request.DeleteRequestResource() { BaseObjectID = 302000001 });
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }


         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, HasChangedInfo Result) hasChangedResult = await configRequest.DoIHaveChanges();
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }


         try
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) createAccessResultX = await configRequest.CreateAccess();

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

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result) SaveResult = await configRequest.Save(new DataContracts.Configuration.Request.SaveRequestResource() { RecalculateFrom = DateTime.UtcNow });
         }
         finally
         {
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) releaseAccessResultX = await configRequest.ReleaseAccess();
         }
      }
      /// <summary>
      /// Data related requests
      /// </summary>
      /// <returns></returns>
      private static async Task DoDataAction()
      {
         DayDataRequests dayDataRequest = new DayDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DayDataResult Result) getDayDataResult
            = await dayDataRequest.GetDayData(new GetDayDataRequestResource()
            {
               DayType = Interfaces.Data.Request.DayData.DayTypes.DBN_DAY_1,
               FromTime = DateTime.UtcNow - TimeSpan.FromDays(30),
               ToTime = DateTime.UtcNow,
               PVDescriptions = new List<GetDayDataPVDescription>()
               {
                  new GetDayDataPVDescription()
                  {
                     PVID = 302000006,
                     DayWhat = new DayWhat(){}
                  },
                  new GetDayDataPVDescription() 
                  {
                     PVID = 302000007,
                     DayWhat = new DayWhat(){}
                  },
               }
            });

         IntervalDataRequests intervalDataRequests = new IntervalDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, IntervalDataResult Result) intervalDataResult
            = await intervalDataRequests.GetIntervalData(new DataContracts.Data.Request.IntervalData.GetIntervalDataRequestResource()
            {
               IntervalType = Interfaces.Data.Request.IntervalData.IntervalTypes.DBN_INT_1,
               FromTime = DateTime.UtcNow - TimeSpan.FromDays(30),
               ToTime = DateTime.UtcNow,
               PVDescriptions = new List<DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription>()
               {
                  new DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription()
                  { 
                     PVID = 302000006, 
                     IntervalWhat = new DataContracts.Data.Request.IntervalData.IntervalWhat(){}
                  },
                  new DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription()
                  { 
                     PVID = 302000007, 
                     IntervalWhat = new DataContracts.Data.Request.IntervalData.IntervalWhat(){ IDAT_IVAL=true }
                  },
               }
            });

         ProcessDataRequests processDataRequests = new ProcessDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ProcessDataBase> Result) processDataResult
            = await processDataRequests.GetProcessData(new GetProcessDataRequestResource()
            {
               FromTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500)),
               ToTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromHours(1)),
               PVIDs = new List<GetProcessDataPVDescription>()
               {
                  new GetProcessDataPVDescription()
                  {
                     DBP_ReadType = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DBP_ReadTypes.DBP_NORMAL,
                     PVID = 302000006,
                     ValueTypes = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Values |
                                  Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Minima |
                                  Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Maxima
                  },
                  new GetProcessDataPVDescription()
                  {
                     DBP_ReadType = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DBP_ReadTypes.DBP_NORMAL,
                     PVID = 302000029,
                     ValueTypes = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Values |
                                  Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Minima |
                                  Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Maxima
                  }
               }
            });

         ////MonthWeekDataRequest > Month
         MonthWeekDataRequests monthWeekDataRequests_Month = new MonthWeekDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, MonthWeekDataResult Result) monthWeekDataResult_Month
            = await monthWeekDataRequests_Month.GetMonthWeekData(new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataRequestResource()
            {
               MonthWeekType = Interfaces.Data.Request.MonthWeekData.MonthWeekTypes.DBN_MONTH,
               FromTime = new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500),
               ToTime = new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(50),
               PVDescriptions = new List<DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription>()
               {
                  new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription() 
                  { 
                     PVID = 302000006, 
                     MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){}
                  },
                  new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription() 
                  { 
                     PVID = 302000029, 
                     MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){}
                  },
               }
            });

         ////MonthWeekDataRequest > Week
         MonthWeekDataRequests monthWeekDataRequests_Week = new MonthWeekDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, MonthWeekDataResult Result) monthWeekDataResult_Week
            = await monthWeekDataRequests_Week.GetMonthWeekData(new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataRequestResource()
            {
               MonthWeekType = Interfaces.Data.Request.MonthWeekData.MonthWeekTypes.DBN_WEEK,
               FromTime = new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500),
               ToTime = new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(50),
               PVDescriptions = new List<DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription>()
               {
                  new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription()
                  { 
                     PVID = 302000006, 
                     MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){}
                  },
                  new DataContracts.Data.Request.MonthWeekData.GetMonthWeekDataPVDescription() 
                  { 
                     PVID = 302000029, 
                     MonthWeekWhat = new DataContracts.Data.Request.MonthWeekData.MonthWeekWhat(){} 
                  },
               }
            });


         YearDataRequests yearDataRequests_Week = new YearDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.YearData.YearDataResult Result) yearDataResult
            = await yearDataRequests_Week.GetYearData(new DataContracts.Data.Request.YearData.GetYearDataRequestResource()
            {
               FromTime = new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500),
               ToTime = new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(150),
               YearType = Interfaces.Data.Request.YearData.YearTypes.DBN_YEAR_MONTH,
               PVDescriptions = new List<DataContracts.Data.Request.YearData.GetYearDataPVDescription>()
               {
                  new DataContracts.Data.Request.YearData.GetYearDataPVDescription()
                  { 
                     PVID = 302000006, 
                     YearWhat = new DataContracts.Data.Request.YearData.YearWhat(){} 
                  },
                  new DataContracts.Data.Request.YearData.GetYearDataPVDescription()
                  { 
                     PVID = 302000007, 
                     YearWhat = new DataContracts.Data.Request.YearData.YearWhat(){}
                  },
                  new DataContracts.Data.Request.YearData.GetYearDataPVDescription()
                  { 
                     PVID = 302000029, 
                     YearWhat = new DataContracts.Data.Request.YearData.YearWhat(){}
                  },
               }
            });



         HandValRawDataRequests handValRawDataRequest = new HandValRawDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.GetHandValRawData.GetHandValRawDataResult Result) handValRawDataRequestResult
            = await handValRawDataRequest.GetHandValRawData(new DataContracts.Data.Request.HandValRawData.GetHandValRawData.GetHandValRawDataRequestResource()
            {
               FromTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(500)),
               ToTime = new DateTimeOffset(new DateTime(2022, 10, 1, 0, 0, 0) + TimeSpan.FromMilliseconds(200) + TimeSpan.FromDays(10)),
               HandValReadType = Interfaces.Data.Request.HandValRawData.GetHandValRawData.HANDVALREADTYPES.READ_ALL_PERDAYS,

               PVs = new List<int> { 302000001, 302000005, 302000013 },
            });


         handValRawDataRequest = new HandValRawDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.WriteHandValRawData.WriteHandValRawDataResult Result) writeHandValRawDataResult
            = await handValRawDataRequest.WriteHandValRawData(new DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataRequestResource()
            {
               DayTimeStamp = new DateTimeOffset(new DateTime(2022, 10, 3), TimeSpan.FromHours(1)),
               PVDescriptions = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataPVDescription>()
               {
                  new DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataPVDescription()
                  {
                     PVID = 302000005,
                     Provals = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataProval>()
                     {
                        new DataContracts.Data.Request.HandValRawData.WriteHandValRawData.WriteHandValRawDataProval()
                        {
                           TimeStamp = new DateTimeOffset(new DateTime(2022,10,3), TimeSpan.FromHours(1)),// + TimeSpan.FromMilliseconds(333)),
                           Value = 12,
                        }
                     }
                  }
               }
            });


         handValRawDataRequest = new HandValRawDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.WriteHandValComments.WriteHandValCommentsResult Result) writeHandValCommentsResult
            = await handValRawDataRequest.WriteHandValComments(new DataContracts.Data.Request.HandValRawData.WriteHandValComments.WriteHandValCommentsRequestResouce()
            {
               TimeStamp = new DateTimeOffset(new DateTime(2022, 10, 3), TimeSpan.FromHours(1)),
               AVComKind = Interfaces.Data.Request.HandValRawData.WriteHandValComments.AVComKinds.AVCOMMENT_DAY,
               PVDescriptions = new List<DataContracts.Data.Request.HandValRawData.WriteHandValComments.WriteHandValCommentsPVDescription>()
                {
                   new DataContracts.Data.Request.HandValRawData.WriteHandValComments.WriteHandValCommentsPVDescription()
                   {
                       PVID=302000005,
                       Comment = "ExampleComment"
                   }
                }
            });


         handValRawDataRequest = new HandValRawDataRequests(client);
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DataContracts.Data.Response.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfoResult Result) writeHandValRawDataAndInfoResult
            = await handValRawDataRequest.WriteHandValRawDataAndInfo(new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfosRequestResource()
            {
               DayTimeStamp = new DateTimeOffset(new DateTime(2022, 10, 3), TimeSpan.FromHours(1)),
               PVDescriptions = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfosPVDescription>()
               {
                  new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfosPVDescription()
                  {
                      PVID=302000005,
                      Values = new List<DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfos>()
                      {
                         new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfos()
                         {
                            TimeStamp = new DateTimeOffset(new DateTime(2022,10,3), TimeSpan.FromHours(1)),// + TimeSpan.FromMilliseconds(333)),
                            Value = 99,
                            Key = "Schlüssel",
                            ProInfoFlag = new DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos.WriteHandValRawDataAndInfoFlag(){ HDAT_KEYVALID = true }
                         }
                      }

                  }
               }
            });


      }
   }
}
