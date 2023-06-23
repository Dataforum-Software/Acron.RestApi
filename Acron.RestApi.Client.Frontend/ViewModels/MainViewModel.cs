using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Acron.RestApi.Client.Frontend.Models;
using Acron.RestApi.Client.Frontend.Views;
using Acron.RestApi.Client.Frontend.Views.Dialog;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Acron.RestApi.DataContracts.Request.AccessToken;
using Acron.RestApi.DataContracts.Request.UserToken;
using System.Windows;
using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Frontend.Models.CommandWrappers;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Response;

namespace Acron.RestApi.Client.Frontend.ViewModels
{
   internal class MainViewModel : ObservableObject
   {

      #region ctor
      private Dictionary<string, string> appSettingKeys = new()
      {
         {"AppName", "Test" },
         { "AppPassword", "Password" },
         { "AcronUser", "acron" },
         { "UserPassword","" },
         { "ClientName", "TestClient" },
         { "HostOrIp","localhost" },
         { "UserPort","12345" },
         { "SessionId", "MySession" },
         { "TargetUrl", "test-api-adress.com" },
         { "Port", "3900"},
         { "Version", "9.4" },
         { "KeepAlive", "True" }
      };
      public MainViewModel()
      {
         Directory.CreateDirectory(DefaultSerialisationString);
         CommandList = new();
         myLogin = new();
         DeserializeAll();
      }
      #endregion

      #region Login
      public bool IsLoggedIn { get; set; } = false;
      private Login _myLogin;
      public Login myLogin
      {
         get { return _myLogin; }
         set
         {
            SetProperty(ref _myLogin, value);
         }
      }

      private async void Login()
      {
         try
         {
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
            _restClient = new(myLogin.ClientName, myLogin.HostName, myLogin.Port, myLogin.Version, appTokenRessource, userTokenRessource);
            (bool HasError, string ErrorText) = await _restClient.Connect();
            if (HasError)
            {
               MessageBox.Show($"ClientConnect:\r\n{ErrorText}");
            }
            else
            {
               IsLoggedIn = true;
               OnPropertyChanged(nameof(IsLoggedIn));
               if (_restClient is not null)
                  FillWithCommandWrappers(_restClient);
               CanClose= false;
            }
         }
         catch (Exception ex)
         {
            Debug.WriteLine(ex);
         }
         FillTypeCodes();
      }


      #endregion

      #region Methods

      private void ModifyLogin()
      {
         var help = new ModifyLoginValuesDialog(myLogin);

         if (!help.ShowDialog() ?? true)
            return;
         myLogin = new Login(help.ListOfLoginValues.ToList());
         IsLoggedIn = false;
         OnPropertyChanged(nameof(IsLoggedIn));
         Login();
      }
      private void SerializeLogin()
      {
         string json = JsonConvert.SerializeObject(myLogin, new JsonSerializerSettings()
         {
            TypeNameHandling = TypeNameHandling.Objects,
            TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
         });
         File.WriteAllText(DefaultSerialisationString + "/Login.json", json);
      }

      private Login DeserializeLogin()
      {
         string json = File.ReadAllText(DefaultSerialisationString + "/Login.json");
         try
         {
            return JsonConvert.DeserializeObject<Login>(json, new JsonSerializerSettings()
            {
               TypeNameHandling = TypeNameHandling.Objects,
            }) ?? new();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Json could not be deserialised: " + Environment.NewLine + ex.Message);
            return new()
            {
               AppName = string.Empty,
               AppPassword = string.Empty,

               AcronUser = string.Empty,
               UserPassword = string.Empty,

               HostName = string.Empty,



               HostOrIP = Dns.GetHostAddresses(Dns.GetHostName()).OrderBy(x => x.AddressFamily).First().ToString(),
               ClientName = Environment.MachineName + "-RestAPI",
               SessionID = string.Empty,
               ClientPort = 123,
               Port = 3900,
               Version = 9.4f,
            };
         }
      }

      public void FillWithCommandWrappers(RestClient client)
      {
         var conf = new ConfigurationGeneralRequests(_restClient);

         Folders folder = new()
         {
            Name = "Configuration Requests",
            Children =
            {
               new HasAccessWrapper(conf) { Name = "Has Access" },
               new CreateAccessWrapper(conf) { Name = "Create Access" },
               new ReleaseAccessWrapper(conf) { Name = "Release Access" },
               new DefaultValuesWrapper(conf) { Name = "Default Values", TestType = typeof(RestApiPvManualObject) },
               new ObjectInfoWrapper(conf) { Name = "Object Info", Input = new DataContracts.Configuration.Request.ObjectInfoRequestResource() { BaseObjectID = 302000001 }, },
               new ObjectInfoEnhancedWrapper(conf)
               {
                  Name = "Enhanced Object Info",
                  Input = new DataContracts.Configuration.Request.ObjectInfoEnhancedRequestResource()
                  { BaseObjectID = 104000001, ShowObjectUsages = true, ShowReferencedObjects = true }
               },
               new SaveWrapper(conf){ Name = "Save", Input = new SaveRequestResource(){RecalculateFrom=DateTime.UtcNow},},
               new DiscardChangesWrapper(conf){Name="Discard Changes"},
               new DoIHaveChangesWrapper(conf){Name= "Do I Have Changes"},
               new GetMyChangedObjectsWrapper(conf){Name="Get Changed Objects"},
               new ValidateWrapper(conf) {Name="Validate"}
            }

         };
         CommandList.Add(folder);
         Folders folder2 = new()
         {
            Name = "Data Requests",
            Children =
            {
               new GetIntervalDataWrapper(_restClient!)
               {
                  Name = "Get Interval Data",
                  Input = new DataContracts.Data.Request.IntervalData.GetIntervalDataRequestResource()
                  {
                     IntervalType = Interfaces.Data.Request.IntervalData.IntervalTypes.DBN_INT_1,
                     FromTime = DateTime.UtcNow - TimeSpan.FromDays(30),
                     ToTime = DateTime.UtcNow,
                     PVDescriptions = new List<DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription>()
                     {
                        new DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription() { PVID = 302000006, IntervalWhat = new DataContracts.Data.Request.IntervalData.IntervalWhat() { } },
                        new DataContracts.Data.Request.IntervalData.GetIntervalDataPVDescription() { PVID = 302000007, IntervalWhat = new DataContracts.Data.Request.IntervalData.IntervalWhat() { IDAT_IVAL = true } },
                     }
                  }
               },
               new GetProcessDataWrapper(_restClient!)
               {
                  Name = "Get Process Data",
                  Input = new DataContracts.Data.Request.ProcessData.GetProcessDataRequestResource()
                  {
                     FromTime = new DateTimeOffset(DateTime.Now, TimeZoneInfo.Local.GetUtcOffset(DateTime.Now - TimeSpan.FromMinutes(1))) - TimeSpan.FromMinutes(1),
                     ToTime = new DateTimeOffset(DateTime.Now, TimeZoneInfo.Local.GetUtcOffset(DateTime.Now)),
                     PVIDs = new()
                     {
                        new DataContracts.Data.Request.ProcessData.GetProcessDataPVDescription()
                        {
                           DBP_ReadType = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DBP_ReadTypes.DBP_WITHOUT_NOVALID,
                           PVID = 302_000_021,
                           ValueTypes = Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Values
                        }
                     }
                  },
               },
               new GetDayDataWrapper(_restClient)
               {
                  Name = "Get Day Data",
                  Input = new DataContracts.Data.Request.DayData.GetDayDataRequestResource()
                  {
                     DayType = Interfaces.Data.Request.DayData.DayTypes.DBN_DAY_1,
                     FromTime = DateTimeOffset.Now - TimeSpan.FromDays(30),
                     ToTime = DateTimeOffset.Now,
                     PVDescriptions = new()
                     {
                        new DataContracts.Data.Request.DayData.GetDayDataPVDescription()
                        {
                           PVID = 302_000_021,
                           DayWhat = new DataContracts.Data.Request.DayData.DayWhat()
                           {
                              DDAT_DVAL = true,
                              DDAT_IMAX = true,
                              DDAT_IMIN = true,
                           }
                        }
                     }
                  }
               }
            }
         };
         CommandList.Add(folder2);

         Folders folder3 = new()
         {
            Name = "Alert Requests",
            Children = new()
            {
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.CreateGroupWrapper(client) { Name="Create Group", Input = new(){new()
               {
                  LongName ="TestAlertLong",IdParent = 200000000
               }}},
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.CreateWrapper(client){Name="Create", Input=new(){new()
               {
                  ShortName="TestAlertShort",  LongName = "TestAlertLongName",
                  PropState = AlertDefines.AlertState.Message,
                  IdParent = 200000003
               }}},
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.DeleteWrapper(client){Name= "Delete",Input = new DeleteRequestResource(){ BaseObjectID = 202000004 } },
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.GetAllGroupsWrapper(client){Name="Get All Groups",Input= new(){ShowLockedAlerts=true, SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.GetAllObjectsWrapper(client){Name="Get All Objects",Input= new(){ShowLockedAlerts=true, SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.GetAllWrapper(client){Name="Get All",Input= new(){ShowLockedAlerts=true, SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.UpdateWrapper(client){Name="Update Alert", TargetID =202000001},
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.UpdateGroupWrapper(client){Name="Update Group", TargetID = 200000003},
               new Models.CommandWrappers.ConfigurationAlertRequestWrappers.ValidateWrapper(client){ Name = "Validate"}
            }
         };
         CommandList.Add(folder3);
         Folders folder4 = new()
         {
            Name = "Connection Requests",
            Children = new()
            {
               new Models.CommandWrappers.ConfigurationConnectionRequestWrappers.GetAllGroupsWrapper(client){Name="Get All Groups",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationConnectionRequestWrappers.GetAllObjectsWrapper(client){Name="Get All Objects",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationConnectionRequestWrappers.GetAllWrapper(client){Name="Get All",Input= new(){SmallObjects=false }},
            }
         };
         CommandList.Add(folder4);
         Folders folder5 = new()
         {
            Name = "Process Connection Requests",
            Children = new()
            {
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.GetAllGroupsWrapper(client){Name="Get All Groups",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.GetAllObjectsWrapper(client){Name="Get All Objects",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.GetAllWrapper(client){Name="Get All",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.DeleteWrapper(client){Name="Delete",Input= new(){ BaseObjectID = 104000004}},
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.CreateProviderWrapper(client)
               {
                  Name = "CreateProvider",
                  Input = new()
                  {
                     new(){IdParent=100000000,PropProviderId=10,LongName="TestProvider1337"}
                  }
               },
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.CreateGroupWrapper(client)
               {
                  Name = "Create External Variable Group",
                  Input=new()
                  {
                     new(){IdParent = 100000003, LongName = "CreatedExtVarGroup"}
                  }
               },
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.CreateExtVarWrapper(client)
               {
                  Name = "Create External Variable",
                  Input = new()
                  {
                     new (){IdParent=102000002 , ShortName="TestExtVarShortName",LongName="TestExtVarLongName"}
                  }
               },
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.GetProviderDriverWrapper(client){Name = "Get Provider Driver"},
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.UpdateGroupWrapper(client)
               {
                  Name = "Update External Variable Group",                  
                  TargetID =102000002,
               },
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.UpdateExtVarWrapper(client)
               {
                  Name = "Update External Variable",
                  TargetID = 104000003
               },
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.UpdateProviderWrapper(client)
               {
                  Name = "Update Provider",
                  TargetID = 100000003,
               },
               new Models.CommandWrappers.ConfigurationProcessConnectionWrappers.ValidateWrapper(client){Name="Validate"},
            }
         };
         CommandList.Add(folder5);
         Folders folder6 = new()
         {
            Name = "Process Variable Requests",
            Children = new()
            {
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.GetAllGroupsWrapper(client){Name="Get All Groups",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.GetAllObjectsWrapper(client){Name="Get All Objects",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.GetAllWrapper(client){Name="Get All",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.DeleteWrapper(client){Name="Delete",Input= new(){ BaseObjectID = 302000003}},
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.CreatePvAutoWrapper(client)
               {
                  Name="Create Auto",
                  Input= new()
                  {
                     new()
                     {
                        IdParent=300000002,
                        ShortName="TestAutoShortName",
                        LongName="TestAutoLongName"
                     }
                  }
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.CreatePvCalcWrapper(client)
               {
                  Name="Create Calc",
                  Input= new()
                  {
                     new()
                     {
                        IdParent=300000002,
                        ShortName="TestCalcShortName",
                        LongName="TestCalcLongName"
                     }
                  }
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.CreateGroupWrapper(client)
               {
                  Name="Create Group",
                  Input= new()
                  {
                     new()
                     {
                        IdParent=300000000,
                        LongName="TestGroupLongName"
                     }
                  }
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.CreatePvManualWrapper(client)
               {
                  Name="Create Manual",
                  Input= new()
                  {
                     new()
                     {
                        IdParent=300000002,
                        ShortName="TestManualShortName",
                        LongName="TestManualLongName"
                     }
                  }
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.UpdatePvAutoWrapper(client)
               {
                  Name="Update Auto",
                  TargetID = 302000004,
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.UpdatePvCalcWrapper(client)
               {
                  Name="Update Calc",
                  TargetID = 302000028,
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.UpdateGroupWrapper(client)
               {
                  Name="Update Group",
                  TargetID = 300000002,
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.UpdatePvManualWrapper(client)
               {
                  Name="Update Manual",
                  TargetID = 302000001
               },
               new Models.CommandWrappers.ConfigurationProcessVariableWrappers.ValidateWrapper(client)
               {
                  Name="Validate",
               }
            }
         };
         CommandList.Add(folder6);
         Folders folder7 = new()
         {
            Name = "Unit Requests",
            Children = new()
            {
               new Models.CommandWrappers.ConfigurationUnitWrappers.ValidateWrapper(client){ Name="Validate Units"},
               new Models.CommandWrappers.ConfigurationUnitWrappers.GetAllBaseUnitsWrapper(client){Name="Get All Groups",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationUnitWrappers.GetAllObjectsWrapper(client){Name="Get All Objects",Input= new(){SmallObjects=false }},
               new Models.CommandWrappers.ConfigurationUnitWrappers.GetAllWrapper(client){Name="Get All",Input= new(){ SmallObjects=false }},
            }
         };
         CommandList.Add(folder7);
      }
      #endregion

      #region Fields
      private RestClient? _restClient;
      private CancellationTokenSource _tokenSource = new();
      const string DefaultSerialisationString = "C:/ProgramData/Acron/APIDemoClient/Serialisation";

      #endregion

      #region Properties
      public int MaxFieldHeightLoginMask { get; } = 25;

      public ObservableCollection<Folders> CommandList { get; set; }

      private bool _showResultsAsList = false;
      public bool ShowResultsAsList
      {
         get { return _showResultsAsList; }
         set
         {
            SetProperty(ref _showResultsAsList, value);
         }
      }

      public IEnumerable<Methods> MethodValues
      {
         get { return (IEnumerable<Methods>)Enum.GetValues(typeof(Methods)); }
      }


      private void FillTypeCodes()
      {

         List<Type> ret = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => !x.IsAbstract && !x.IsInterface && x.IsAssignableTo(typeof(IBaseObject))).ToList();
         _typeCodes = ret.Where(x => !x.Name.Contains("Base") || (x.Name == nameof(RestApiBaseObject) || x.Name == nameof(RestApiBaseUnitObject))).ToList();
         _typeCodes.Remove(typeof(RestApiBaseObject));
         _typeCodes.Remove(typeof(RestApiProviderDriverObject));
         _typeCodes.Remove(typeof(RestApiDefaultGroupObject));
         _typeCodes.Remove(typeof(RestApiPlantObject));
         OnPropertyChanged(nameof(TypeCodes));
      }

      private List<Type> _typeCodes = new();
      public List<Type> TypeCodes
      {
         get
         {
            return _typeCodes;
         }
      }

      private IWrapper? _selectedItem;
      public IWrapper? SelectedItem
      {
         get { return _selectedItem; }
         set
         {
            if (SetProperty(ref _selectedItem, value))
            {
               Resend = false;
               OnPropertyChanged(nameof(SelectedOnlineGraph));
               OnPropertyChanged(nameof(SelectedGeneric));
            }
         }
      }

      public IOnlineGraphCapable? SelectedOnlineGraph
      {
         get
         {
            return SelectedItem as IOnlineGraphCapable;
         }
      }

      public IGenericMethodWrapper? SelectedGeneric
      {
         get
         {
            return SelectedItem as IGenericMethodWrapper;
         }
      }
      private bool _hasChanges;
      public bool HasChanges
      {
         get { return _hasChanges; }
         set
         {
            SetProperty(ref _hasChanges, value);
         }
      }

      public bool CanClose { get; set; } = true;

      private bool _resend;
      public bool Resend
      {
         get { return _resend; }
         set
         {
            if (SetProperty(ref _resend, value))
            {
               if (!_resend)
                  _tokenSource.Cancel();
               else
                  _tokenSource = new();
            }
         }
      }

      private int _interval = 5;
      public string Interval
      {
         get { return _interval.ToString(); }
         set
         {
            if (int.TryParse(value, out int temp))
               SetProperty(ref _interval, temp);
         }
      }

      #endregion

      #region RelayCommands

      private RelayCommand? _modifyLoginCommand;
      public RelayCommand ModifyLoginCommand
      {
         get { return _modifyLoginCommand ??= new(ModifyLogin); }
      }


      private RelayCommand? _loginCommand;
      public RelayCommand LoginCommand
      {
         get { return _loginCommand ??= new(Login); }
      }


      private RelayCommand? _restoreDefaultsCommand;
      public RelayCommand RestoreDefaultsCommand
      {
         get { return _restoreDefaultsCommand ??= new(RestoreDefaults); }
      }
      private void RestoreDefaults()
      {
         CommandList.Clear();
         if (_restClient is null)
         {
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
            _restClient = new(myLogin.ClientName, myLogin.HostName, myLogin.Port, myLogin.Version, appTokenRessource, userTokenRessource);
         }
         FillWithCommandWrappers(_restClient);
      }

      private AsyncRelayCommand? _sendRequestCommand;
      public AsyncRelayCommand SendRequestCommand
      {
         get { return _sendRequestCommand ??= new AsyncRelayCommand(SendRequest); }
      }

      private async Task SendRequest()
      {
         if (SelectedItem is null)
            return;
         if (!Resend)
         {
            await SelectedItem.ExecuteMethod();
            return;
         }
         CancellationToken myToken = _tokenSource.Token;

         while (Resend)
         {
            if (SelectedItem is IOnlineGraphCapable graph)
            {
               graph.UpdateLastExecution();
               await graph.ExecuteOnline();
               try
               {
                  await Task.Delay(TimeSpan.FromSeconds(_interval), myToken);
               }
               catch (TaskCanceledException)
               {
                  //Catching Cancelled Tasks
               }
            }
         }
      }


      private RelayCommand? _serializeAllCommand;
      public RelayCommand SerializeAllCommand
      {
         get { return _serializeAllCommand ??= new(SerializeAll); }
      }



      private void SerializeAll()
      {
         SerializeLogin();
      }

      private void DeserializeAll()
      {

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

               AcronUser = string.Empty,
               UserPassword = string.Empty,

               HostName = string.Empty,



               HostOrIP = Dns.GetHostAddresses(Dns.GetHostName()).OrderBy(x => x.AddressFamily).First().ToString(),
               ClientName = Environment.MachineName + "-RestAPI",
               SessionID = string.Empty,
               ClientPort = 123,
               Port = 3900,
               Version = 9.4f,
            };


         }
      }
      private AsyncRelayCommand _returnAccessCommand;
      public AsyncRelayCommand ReturnAccessCommand
      {
         get { return _returnAccessCommand ??= new(async () => await ReturnAccess()); }
      }


      private async Task ReturnAccess()
      {
         IWrapper changes = CommandList?.FirstOrDefault(x => x.Children.Any(x => x.Name == "Do I Have Changes"))?.Children?.FirstOrDefault(x => x.Name == "Do I Have Changes");
         if (changes is null)
         {
            CanClose = true;
            return;
         }
         IWrapper discard = CommandList?.FirstOrDefault(x => x.Children.Any(x => x.Name == "Discard Changes"))?.Children?.FirstOrDefault(x => x.Name == "Discard Changes");
         if (discard is null)
         {
            CanClose = true;
            return;
         }
         IWrapper release = CommandList?.FirstOrDefault(x => x.Children.Any(x => x.Name == "Release Access"))?.Children?.FirstOrDefault(x => x.Name == "Release Access");
         if (release is null)
         {
            CanClose = true;
            return;
         }
         await changes.ExecuteMethod();
         if(changes!.Response?.Message == "Configuration has changed.")
            await discard.ExecuteMethod();
         await release.ExecuteMethod();
         CanClose = true;
      }

      private RelayCommand _getCommand;
      public RelayCommand GetCommand
      {
         get { return _getCommand ??= new(Get); }
      }

      private async void Get()
      {
         if (_restClient == null)
            return;
         var help = new ObjectInfoWrapper(new(_restClient)) { Input = { BaseObjectID = SelectedItem?.TargetID } };
         await help.ExecuteMethod();
         if (SelectedItem == null || help.HasError)
            return;
         var eh = new List<object?> { (help.Response as AcOkResponse)?.Result };
         SelectedItem.InputBodyText = JsonConvert.SerializeObject(eh);
      }

      private RelayCommand? _deleteSelectedCommand;
      public RelayCommand DeleteSelectedCommand
      {
         get { return _deleteSelectedCommand ??= new(DeleteSelected, CanDeleteSelected); }
      }

      private bool CanDeleteSelected()
      {
         return SelectedItem is not null;
      }
      private void DeleteSelected()
      {
         if (SelectedItem is not null)
         {
            CommandList.First(x => x.Children.Contains(SelectedItem)).Children.Remove(SelectedItem);
            SelectedItem = null;
         }
      }
      #endregion

   }
}
