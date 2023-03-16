using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Request.AccessToken;
using Acron.RestApi.DataContracts.Response.AccessToken;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.DataContracts.Request.UserToken;
using Acron.RestApi.DataContracts.Response.UserToken;
using Microsoft.AspNetCore.Http.Headers;

namespace Acron.RestApi.Client
{
   internal class TokenHandlingRequest : RestClientRequestBase
   {
      internal TokenHandlingRequest(RestClient pClient) : base(pClient)
      {
      }

      public AccessTokenResource CurrentAccessToken { get; private set; }
      public UserTokenResource CurrentUserToken { get; private set; }

      internal async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource AccessToken)> GetAccessToken(AccessTokenLoginResource accessTokenLoginResource)
      {
         try
         {
            string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.AuthenticateApp]}";

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource AccessToken) result = await Post_Request<AccessTokenLoginResource, AccessTokenResource>(uri, accessTokenLoginResource);

            if (result.HasError)
            {
               CurrentAccessToken = null;
               return (result.HasError, result.ErrorText, default, default);
            }

            CurrentAccessToken = result.AccessToken;
            return (result.HasError, result.ErrorText, result.ResponseBase, result.AccessToken);
         }
         catch (Exception ex)
         {
            CurrentAccessToken = null;
            return (true, ex.Message, default, default);
         }
      }

      internal async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource AccessToken)> RefreshAccessToken(AccessTokenResource accessTokenResource)
      {
         try
         {
            string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.AuthenticateAppRefresh]}";
            AccessTokenRefreshResource refreshResource = new AccessTokenRefreshResource() { AccessToken = accessTokenResource.AccessToken, RefreshToken = accessTokenResource.RefreshToken };

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, AccessTokenResource AccessToken) result = await Post_Request<AccessTokenRefreshResource, AccessTokenResource>(uri, refreshResource);
            if (result.HasError)
            {
               CurrentAccessToken = null;
               return (result.HasError, result.ErrorText, default, default);
            }

            CurrentAccessToken = result.AccessToken;
            return (result.HasError, result.ErrorText, result.ResponseBase, result.AccessToken);
         }
         catch (Exception ex)
         {
            CurrentAccessToken = null;
            return (true, ex.Message, default, default);
         }
      }

      internal Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource UserToken)> GetUserToken(UserTokenLoginResource userTokenLoginResource)
      {
         return Task.Run(async () =>
         {
            try
            {
               string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Login]}";

               List<KeyValuePair<string, string>> customHeaders = new List<KeyValuePair<string, string>>
               {
                  new KeyValuePair<string, string>("Authorization", "Bearer " + CurrentAccessToken.AccessToken),
               };

               (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource UserToken) result = await Post_Request<UserTokenLoginResource, UserTokenResource>(uri, userTokenLoginResource, customHeaders);
               if (result.HasError)
               {
                  CurrentUserToken = null;
                  return (result.HasError, result.ErrorText, default, default);
               }

               CurrentUserToken = result.UserToken;
               return (result.HasError, result.ErrorText, result.ResponseBase, result.UserToken);
            }
            catch (Exception ex)
            {
               CurrentUserToken = null;
               return (true, ex.Message, default, default);
            }
         });
      }


      internal Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource UserToken)> RefreshUserToken(UserTokenResource userTokenResource)
      {
         return Task.Run(async () =>
         {
            try
            {
               string uri = $"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.LoginRefresh]}";
               UserTokenRefreshResource refreshResource = new UserTokenRefreshResource() { RefreshToken = userTokenResource.RefreshToken };

               List<KeyValuePair<string, string>> customHeaders = new List<KeyValuePair<string, string>>()
               {
                  new KeyValuePair<string, string>("Authorization", "Bearer " + CurrentAccessToken.AccessToken),
                  new KeyValuePair<string, string>("Acron", userTokenResource.UserToken),
               };

               (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, UserTokenResource UserToken) result = await Post_Request<UserTokenRefreshResource, UserTokenResource>(uri, refreshResource, customHeaders);
               if (result.HasError)
               {
                  CurrentUserToken = null;
                  return (result.HasError, result.ErrorText, default, default);
               }

               CurrentUserToken = result.UserToken;
               return (result.HasError, result.ErrorText, result.ResponseBase, result.UserToken);
            }
            catch (Exception ex)
            {
               CurrentUserToken = null;
               return (true, ex.Message, default, default);
            }
         });
      }


   }
}
