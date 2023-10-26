using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Globalization;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.DataContracts.Response.AccessToken;
using Acron.RestApi.DataContracts.Request.AccessToken;
using Acron.RestApi.DataContracts.Response.UserToken;
using Acron.RestApi.DataContracts.Request.UserToken;
using System.Windows;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.Client.Client.Request;
using Microsoft.VisualBasic;

namespace Acron.RestApi.Client
{
   public class RestClient
   {
      #region CTor
      /// <summary>
      /// Initialises the RestClient
      /// </summary>
      /// <param name="pRestClientName"></param>
      /// <param name="pHostName"></param>
      /// <param name="pPort"></param>
      /// <param name="pVersion"></param>
      /// <param name="accessTokenLoginResource"></param>
      /// <param name="userTokenLoginResource"></param>
      /// <param name="pKeepAlive">Should the Client refresh its Access and UserTokens automatically</param>
      public RestClient(string pRestClientName,
                        string pHostName,
                        uint pPort,
                        float pVersion,
                        AccessTokenLoginResource accessTokenLoginResource,
                        UserTokenLoginResource userTokenLoginResource,
                        bool pKeepAlive = true
                        )
      {
         RestClientName = pRestClientName;

         HostName = pHostName;
         Port = pPort;

         BaseAddress = $"https://{HostName}:{Port}/Api/V{pVersion.ToString("N1",CultureInfo.InvariantCulture)}/";

         AccessTokenLoginResource = accessTokenLoginResource;
         UserTokenLoginResource = userTokenLoginResource;

         this.Version = pVersion;

         _HttpClient = new HttpClient()
         {
            BaseAddress = new Uri(this.BaseAddress),
            DefaultRequestVersion = new Version(VersionAsString),
            DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact
         };

         TokenRequest = new TokenHandlingRequest(this);

         KeepAlive = pKeepAlive;
      }
      #endregion CTor

      #region Props & Fields      
      internal HttpClient _HttpClient { get; set; }

      public float Version { get; private set; }
      public string VersionAsString { get { return Version.ToString("N1",CultureInfo.InvariantCulture); } }

      internal TokenHandlingRequest TokenRequest { get; private set; }

      private SemaphoreSlim _semaphore = new SemaphoreSlim(1);

      public string RestClientName { get; private set; }
      public string HostName { get; private set; }
      public uint Port { get; private set; }

      public AccessTokenLoginResource AccessTokenLoginResource { get; private set; }
      public UserTokenLoginResource UserTokenLoginResource { get; private set; }

      public string BaseAddress { get; private set; }

      public AccessTokenResource CurrentAccessToken
      {
         get
         {
            bool hasSemaphore = false;
            try
            {
               _semaphore.Wait(35000);
               hasSemaphore = true;
               return TokenRequest.CurrentAccessToken;
            }
            finally
            {
               if (hasSemaphore)
               {
                  _semaphore.Release();
                  hasSemaphore = false;
               }
            }
         }
      }


      public UserTokenResource CurrentUserToken
      {
         get
         {
            bool hasSemaphore = false;
            try
            {
               _semaphore.Wait(35000);
               hasSemaphore = true;
               return TokenRequest.CurrentUserToken;
            }
            finally
            {
               if (hasSemaphore)
               {
                  _semaphore.Release();
                  hasSemaphore = false;
               }
            }
         }
      }


      public bool ClientReady
      {
         get { return CurrentAccessToken != null && CurrentUserToken != null; }
      }

      #endregion Props & Fields
      /// <summary>
      /// Initialises the connection between Client and REST API and fetches Authorisation tokens
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText)> Connect()
      {
         _HttpClient.DefaultRequestHeaders.Accept.Clear();
         _HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/Json"));
         _HttpClient.DefaultRequestHeaders.Add("User-Agent", "dataforum Software GmbH");

         bool HasError = false;
         string ErrorText = string.Empty;
         ApiControllerResponseBase responseBase = null;

         AccessTokenResource AccessToken = null;
         (HasError, ErrorText, responseBase, AccessToken) = await TokenRequest.GetAccessToken(AccessTokenLoginResource);
         if (HasError)
         {
            return (true, ErrorText);
         }
         if (AccessToken is not null)
            AccessTokenTime = AccessToken.ExpiresUTC - TimeSpan.FromSeconds(180);
         UserTokenResource UserToken = null;
         (HasError, ErrorText, responseBase, UserToken) = await TokenRequest.GetUserToken(UserTokenLoginResource);
         if (HasError)
         {
            return (true, ErrorText);
         }
         if (UserToken is not null)
            UserTokenTime = UserToken.ExpiresUTC - TimeSpan.FromSeconds(180);

         return (false, string.Empty);
      }

      #region KeepAlive, KeepAliveThread, RefreshAllTokens
      private bool _keepAlive;
      /// <summary>
      /// Should the client automatically refresh User- and Accesstokens
      /// </summary>
      public bool KeepAlive
      {
         get
         {
            return _keepAlive;
         }
         private set
         {
            if (_keepAlive == value)
               return;

            _keepAlive = value;

            if (_keepAlive)
               KeepAliveThread();
         }
      }

      private void KeepAliveThread()
      {
         Task.Run(async() =>
         {
            Task[] tasks = new Task[2];
            //int i = 1;
            while (KeepAlive)
            {
               if (CurrentAccessToken == null || CurrentUserToken == null)
                  continue;
               tasks[0] = RefreshAccessTokenByTime(AccessTokenTime);
               tasks[1] = RefreshUserTokenByTime(UserTokenTime);

               await Task.WhenAll(tasks);
            }
         });



      }

      private DateTime AccessTokenTime = DateTime.UtcNow + TimeSpan.FromSeconds(100);
      private DateTime UserTokenTime = DateTime.UtcNow + TimeSpan.FromSeconds(100);

      private async Task RefreshAccessTokenByTime(DateTime RefreshTime)
      {
         if (CurrentAccessToken is null)
            return;
         while(DateTime.UtcNow < AccessTokenTime)
         {
            await Task.Delay(TimeSpan.FromSeconds(60));
         }
         bool hasSemaphore = false;
         try
         {
            _semaphore.Wait(35000);
            hasSemaphore = true;
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource AccessToken) = await TokenRequest.RefreshAccessToken(CurrentAccessToken);
            if (HasError)
               throw new Exception(ErrorText);
            if (AccessToken != null)
            {
               AccessTokenTime = AccessToken.ExpiresUTC - TimeSpan.FromSeconds(180);
            }
         }
         finally
         {
            if(hasSemaphore)
               _semaphore.Release();
         }
      }

      private async Task RefreshUserTokenByTime(DateTime RefreshTime)
      {
         if (CurrentUserToken is null)
            return;
         while (DateTime.UtcNow < UserTokenTime)
         {
            await Task.Delay(TimeSpan.FromSeconds(60));
         }
         bool hasSemaphore = false;
         try
         {
            _semaphore.Wait(35000);
             hasSemaphore = true;
            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource UserToken) = await TokenRequest.RefreshUserToken(CurrentUserToken);
            if (HasError)
               throw new Exception(ErrorText);
            if (UserToken != null)
            {
               UserTokenTime = UserToken.ExpiresUTC -  TimeSpan.FromSeconds(180);
            }
         }
         finally
         {
            if(hasSemaphore)
               _semaphore.Release();
         }

      }
      #endregion KeepAlive, KeepAliveThread, RefreshAllTokens

      #region Methods
      //Dictionary<string, string> _fixedAuthHeaders = null;
      //internal Dictionary<string, string> FixedAuthHeaders()
      //{
      //   if (_fixedAuthHeaders == null)
      //   {
      //      _fixedAuthHeaders = new Dictionary<string, string>()
      //      {
      //         {"Authorization", $"Bearer {CurrentAccessToken.AccessToken}" },
      //         {"Acron", CurrentUserToken.UserToken },
      //      };
      //   }

      //   return _fixedAuthHeaders;
      //}


      //Dictionary<string, string> _fixedContentHeaders = null;
      //internal Dictionary<string, string> GetFixedContentHeaders()
      //{
      //   if (_fixedContentHeaders == null)
      //   {
      //      _fixedContentHeaders = new Dictionary<string, string>()
      //      {
      //         { "Content-Type", "application/json" }
      //      };
      //   }

      //   return _fixedContentHeaders;
      //}

      #endregion Methods
   }
}
