using Acron.RestApi.Client.Frontend.Views.Dialog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models
{
   public class Login
   {
      #region ctor
      public Login() 
      {
         ClientName = string.Empty;
         HostName= string.Empty;
         Port = uint.MinValue;
         Version = float.NaN;
         AppName= string.Empty;
         AppPassword= string.Empty;
         AcronUser = string.Empty;
         UserPassword= string.Empty;
         HostOrIP= string.Empty;
         ClientPort = uint.MinValue;
         SessionID= string.Empty;
      }
      public Login(List<DataItem> data)
      {
         ClientName = data.FirstOrDefault(x => x.Key == nameof(ClientName))?.Value ?? string.Empty;
         HostName = data.FirstOrDefault(x => x.Key == nameof(HostName))?.Value ?? string.Empty;
         Port = uint.Parse(data.FirstOrDefault(x => x.Key == nameof(Port))?.Value ?? string.Empty,CultureInfo.InvariantCulture);
         Version = float.Parse(data.FirstOrDefault(x => x.Key == nameof(Version))?.Value ?? string.Empty, CultureInfo.InvariantCulture);
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
      public string ClientName { get; set; }
      public string HostName { get; set; }
      public uint Port { get; set; }
      public float Version { get; set; }


      public string AppName { get; set; }
      public string AppPassword { get; set; }

      public string AcronUser { get; set; }
      public string UserPassword { get; set; }
      public string HostOrIP { get; set; }
      public uint ClientPort { get; set; }
      public string SessionID { get; set; }
      #endregion
   }
}
