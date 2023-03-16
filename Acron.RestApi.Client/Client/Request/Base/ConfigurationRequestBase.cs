using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Data.Response.DayData;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.Base
{
   public abstract class ConfigurationRequestBase : RestClientAuthorizedRequestBase
   {
      protected ConfigurationRequestBase(RestClient pClient) : base(pClient)
      {

      }
      /// <summary>
      /// Claims access rights for the current Client to modify configuration, only one access at a time.
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result)> CreateAccess()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) result
            = await Get_Request<PlantConfigUserInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.CreateAccess]}");

         return result;
      }

      /// <summary>
      /// Releases claimed access rights for the current Client
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result)> ReleaseAccess()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) result
            = await Get_Request<PlantConfigUserInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ReleaseAccess]}");

         return result;
      }

      /// <summary>
      /// Checks whether the current Client has access rights
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result)> HasAccess()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) result
            = await Get_Request<PlantConfigUserInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.HasAccess]}");

         return result;
      }

      /// <summary>
      /// Checks whether there are any outstanding changes to the configuration
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, HasChangedInfo Result)> DoIHaveChanges()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, HasChangedInfo Result) result
            = await Get_Request<HasChangedInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.DoIHaveChanges]}");

         return result;
      }

      /// <summary>
      /// Fetches all Objects that have outstanding changes
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ChangedObjectInfo> Result)> GetMyChangedObjects()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ChangedObjectInfo> Result) result
            = await Get_Request<List<ChangedObjectInfo>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetMyChangedObjects]}");

         return result;
      }
      /// <summary>
      /// Validates the outstanding changes to the current configuration
      /// </summary>
      /// <returns>List of invalid items</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result)> Validate()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) result
            = await Get_Request<List<ErrorItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Validate]}");

         return result;
      }

      /// <summary>
      /// Saves the outstanding changes to the current configuration
      /// </summary>
      /// <param name="saveRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result)> Save(SaveRequestResource saveRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result) result
            = await Post_Request<SaveRequestResource, SaveInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Save]}", saveRequestResource);
         return result;
      }
      /// <summary>
      /// Discards all outstanding changes
      /// Caution: This method forces a full reload of the plant configuration, which may take longer than expected.
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DiscardChangesInfo Result)> DiscardChanges()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DiscardChangesInfo Result) result
            = await Get_Request<DiscardChangesInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.DiscardChanges]}");

         return result;
      }

   }
}
