using Acron.RestApi.Client.Frontend.Views.Dialog;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models
{
   public class Login : ObservableObject
   {
      #region ctor
      public Login()
      {
         ClientName = string.Empty;
         HostName = string.Empty;
         Port = uint.MinValue;
         Version = 10.0f;
         AppName = string.Empty;
         AppPassword = string.Empty;
         AcronUser = string.Empty;
         UserPassword = string.Empty;
         HostOrIP = string.Empty;
         ClientPort = uint.MinValue;
         SessionID = string.Empty;
      }
      public Login(List<DataItem> data)
      {
         ClientName = data.FirstOrDefault(x => x.Key == nameof(ClientName))?.Value ?? string.Empty;
         HostName = data.FirstOrDefault(x => x.Key == nameof(HostName))?.Value ?? string.Empty;
         Port = uint.Parse(data.FirstOrDefault(x => x.Key == nameof(Port))?.Value ?? string.Empty, CultureInfo.InvariantCulture);
         Version = float.Parse(data.FirstOrDefault(x => x.Key == nameof(Version))?.Value ?? "10.0", CultureInfo.InvariantCulture);
         AppName = data.FirstOrDefault(x => x.Key == nameof(AppName))?.Value ?? string.Empty;
         AppPassword = data.FirstOrDefault(x => x.Key == nameof(AppPassword))?.Value ?? string.Empty;
         AcronUser = data.FirstOrDefault(x => x.Key == nameof(AcronUser))?.Value ?? string.Empty;
         UserPassword = data.FirstOrDefault(x => x.Key == nameof(UserPassword))?.Value ?? string.Empty;
         HostOrIP = data.FirstOrDefault(x => x.Key == nameof(HostOrIP))?.Value ?? string.Empty;
         SessionID = data.FirstOrDefault(x => x.Key == nameof(SessionID))?.Value ?? string.Empty;
         ClientPort = uint.Parse(data.FirstOrDefault(x => x.Key == nameof(ClientPort))?.Value ?? string.Empty, CultureInfo.InvariantCulture);
      }
      #endregion

      #region Properties
      private string _clientName;
      public string ClientName
      {
         get { return _clientName; }
         set
         {
            SetProperty(ref _clientName, value);
         }
      }
      private string _hostName;
      public string HostName
      {
         get { return _hostName; }
         set
         {
            SetProperty(ref _hostName, value);
         }
      }
      private uint _port;
      public uint Port
      {
         get
         {
            return _port;
         }
         set
         {
            SetProperty(ref _port, value);
         }
      }
      public float Version { get; set; }

      private string _appName;
      public string AppName
      {
         get { return _appName; }
         set
         {
            SetProperty(ref _appName, value);
         }
      }
      private string _appPassword;
      public string AppPassword
      {
         get { return _appPassword; }
         set
         {
            SetProperty(ref _appPassword, value);
         }
      }
      private string _acronUser;
      public string AcronUser
      {
         get { return _acronUser; }
         set
         {
            SetProperty(ref _acronUser, value);
         }
      }

      private string _userPassword;
      public string UserPassword
      {
         get { return _userPassword; }
         set
         {
            SetProperty(ref _userPassword, value);
         }
      }
      private string _hostOrIP;
      public string HostOrIP
      {
         get { return _hostOrIP; }
         set
         {
            SetProperty(ref _hostOrIP, value);
         }
      }
      private uint _clientPort;
      public uint ClientPort
      {
         get
         {
            return _clientPort;
         }
         set
         {
            SetProperty(ref _clientPort, value);
         }
      }
      private string _sessionID;
      public string SessionID
      {
         get { return _sessionID; }
         set
         {
            SetProperty(ref _sessionID, value);
         }
      }
      #endregion
   }
}
