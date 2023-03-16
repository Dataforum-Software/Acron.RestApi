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

namespace Acron.RestApi.Client.Frontend.ViewModels
{
   internal class MainViewModel : ObservableObject
   {

      #region ctor
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

      public Login myLogin { get; private set; }


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
            }
            Console.WriteLine("afafa");
         }
         catch (Exception ex)
         {
            Debug.WriteLine(ex);
         }
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
         return JsonConvert.DeserializeObject<Login>(json, new JsonSerializerSettings()
         {
            TypeNameHandling = TypeNameHandling.Objects,
         }) ?? new();
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
               }
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
                  Name = "Data",
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
                  Name = "Process",
                  Input = new DataContracts.Data.Request.ProcessData.GetProcessDataRequestResource()
                  {
                     FromTime = new DateTimeOffset(DateTime.Now, TimeSpan.FromHours(1)) - TimeSpan.FromMinutes(1),
                     ToTime = new DateTimeOffset(DateTime.Now, TimeSpan.FromHours(1)),
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
      }
      #endregion

      #region Fields
      private RestClient? _restClient;
      private CancellationTokenSource _tokenSource = new();
      const string DefaultSerialisationString = "C:/ProgramData/Acron/APIDemoClient/Serialisation";

      #endregion

      #region Properties
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

      private IWrapper? _selectedItem;
      public IWrapper? SelectedItem
      {
         get { return _selectedItem; }
         set
         {
            if (SetProperty(ref _selectedItem, value))
               Resend = false;
         }
      }




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
               catch (TaskCanceledException )
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
            myLogin = new();
         }
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
            CommandList.First(x=> x.Children.Contains(SelectedItem)).Children.Remove(SelectedItem);
            SelectedItem = null;
         }
      }
      #endregion

   }
}
