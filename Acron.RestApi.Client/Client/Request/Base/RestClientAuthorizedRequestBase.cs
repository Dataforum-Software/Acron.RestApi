using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Request.AccessToken;
using Acron.RestApi.DataContracts.Request.UserToken;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.DataContracts.Response.AccessToken;
using Acron.RestApi.DataContracts.Response.UserToken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.Base
{
   public abstract class RestClientAuthorizedRequestBase : RestClientRequestBase
   {
      protected RestClientAuthorizedRequestBase(RestClient pClient) : base(pClient)
      {

      }

      protected override List<KeyValuePair<string, string>> GetFixedRequestHeaders()
      {
         List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>(base.GetFixedRequestHeaders());

         headers.Add(new KeyValuePair<string, string>(HeaderDefines.Keys.Authentication.Authorization, $"Bearer {Client.CurrentAccessToken.AccessToken}"));
         headers.Add(new KeyValuePair<string, string>(HeaderDefines.Keys.Authentication.Acron, Client.CurrentUserToken.UserToken));

         return headers;
      }
      /// <summary>
      /// Used to set and retrieve the AccessToken for Authorisation if KeepAlive is disabled 
      /// </summary>
      public string AccessToken
      {
         get {return Client.CurrentAccessToken.AccessToken; }
         set
         {
            if (string.IsNullOrEmpty(value))
               return;
            Client.CurrentAccessToken.AccessToken = value;
         }
      }
      /// <summary>
      /// Retrieve the current Refresh Token for the AccessToken
      /// </summary>
      public string AccessRefreshToken
      {
         get { return Client.CurrentAccessToken.RefreshToken; }
      }

      /// <summary>
      /// Used to set and retrieve the UserToken for Authorisation if KeepAlive is disabled
      /// </summary>
      public string UserToken
      {
         get { return Client.CurrentUserToken.UserToken; }
         set
         {
            if (string.IsNullOrEmpty(value))
               return;
            Client.CurrentUserToken.UserToken = value;
         }
      }
      /// <summary>
      /// Retrieve the current Refresh Token for the UserToken
      /// </summary>
      public string UserRefreshToken
      {
         get { return Client.CurrentUserToken.RefreshToken; }
      }
      /// <summary>
      /// Manually fetches an Access Token from the REST API for the given credentials
      /// </summary>
      /// <param name="appKey"></param>
      /// <param name="appPassword"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource Result)> GetAccessToken(string appKey, string appPassword)
      {
         string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.AuthenticateApp]}";
         AccessTokenLoginResource loginResource = new AccessTokenLoginResource() { AppName = appKey, Password = appPassword };

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource Result) result = await Post_Request<AccessTokenLoginResource, AccessTokenResource>(uri, loginResource);
         return result;
      }
      /// <summary>
      /// Manually refreshes the provided Access Token
      /// </summary>
      /// <param name="accessTokenResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource Result)> RefreshAccessToken(AccessTokenResource accessTokenResource)
      {
         string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.AuthenticateAppRefresh]}";
         AccessTokenRefreshResource refreshResource = new AccessTokenRefreshResource() { AccessToken = accessTokenResource.AccessToken, RefreshToken = accessTokenResource.RefreshToken };

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource Result) result = await Post_Request<AccessTokenRefreshResource, AccessTokenResource>(uri, refreshResource);
         return result;
      }
      /// <summary>
      /// Manually fetches a User Token from the REST API for the given credentials
      /// </summary>
      /// <param name="userTokenLoginResource"></param>
      /// <param name="accessTokenResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource Result)> GetUserToken(UserTokenLoginResource userTokenLoginResource, AccessTokenResource accessTokenResource)
      {

         string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Login]}";

         List<KeyValuePair<string, string>> customHeaders = new List<KeyValuePair<string, string>>
               {
                  new KeyValuePair<string, string>("Authorization", "Bearer {accessTokenResource.AccessToken}"),
               };

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource Result) result= await Post_Request<UserTokenLoginResource, UserTokenResource>(uri, userTokenLoginResource, customHeaders);
         return result;
      }
      /// <summary>
      /// Manually refreshes the provided User Token
      /// </summary>
      /// <param name="userTokenResource"></param>
      /// <param name="accessTokenResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource Result)> RefreshUserToken(UserTokenResource userTokenResource, AccessTokenResource accessTokenResource)
      {
         string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.LoginRefresh]}";
         UserTokenRefreshResource refreshResource = new UserTokenRefreshResource() { RefreshToken = userTokenResource.RefreshToken };

         List<KeyValuePair<string, string>> customHeaders = new List<KeyValuePair<string, string>>()
               {
                  new KeyValuePair<string, string>("Authorization", $"Bearer {accessTokenResource.AccessToken}"),
                  new KeyValuePair<string, string>("Acron", userTokenResource.UserToken),
               };

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource Result) result = await Post_Request<UserTokenRefreshResource, UserTokenResource>(uri, refreshResource, customHeaders);
         return result;
      }

   }
}
