using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.ConfigurationRequests
{
   public class ConfigurationAlertRequests : ConfigurationRequestBase
   {
      public ConfigurationAlertRequests(RestClient pClient) : base(pClient)
      {
      }

      /*
       * ### Get ###
       * [List<RestApiBaseObject>]GetAll[GetAllAlertsRequestResource]###
       * [List<RestApiBaseObject>]GetAllGroups[GetAllAlertsRequestResource]###
       * [List<RestApiBaseObject>]GetAllObjects[GetAllAlertsRequestResource]###
       * 
       * ### Validate
       * [List<ErrorItem>]Validate###
       * 
       * ### Create
       * [CreateUpdateResult]CreateAlertGroup[List<RestApiAlertGroupObject>]
       * [CreateUpdateResult]CreateAlert[List<RestApiAlertObject>]
       * 
       * ### Update
       * [CreateUpdateResult]UpdateAlertGroup[List<RestApiAlertGroupeObject>]
       * [CreateUpdateResult]UpdateAlert[List<RestApiAlertObject>]
       * 
       * ### Delete
       * [DeleteInfo]Delete[DeleteRequestResource]
       */

      #region Get Config
      /// <summary>
      /// Fetches all alert objects and groups
      /// </summary>
      /// <param name="getAllAlertsRequestResource">Specifies whether locked alerts should be fetched</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAll(GetAllAlertsRequestResource getAllAlertsRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllAlertsRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_GetAll]}",
                                                                                       getAllAlertsRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all alert groups
      /// </summary>
      /// <param name="getAllAlertsRequestResource">Specifies whether locked alerts should be fetched</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllGroups(GetAllAlertsRequestResource getAllAlertsRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllAlertsRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_GetAllGroups]}",
                                                                                       getAllAlertsRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all alert objects
      /// </summary>
      /// <param name="getAllAlertsRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllObjects(GetAllAlertsRequestResource getAllAlertsRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllAlertsRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_GetAllObjects]}",
                                                                                       getAllAlertsRequestResource);

         return result;
      }

      #endregion Get Config

      
      #region Validate
      /// <summary>
      /// Validates all alerts in the current configuration
      /// </summary>
      /// <returns>List of invalid items</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result)> ValidateAlert()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) result
            = await Get_Request<List<ErrorItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_Validate]}");
         return result;
      }

      #endregion Validate


      #region Create BaseObjects
      /// <summary>
      /// Attempts to create all alert groups specificed in the input parameter
      /// </summary>
      /// <param name="restApiAlertGroupObjectList"></param>
      /// <returns>A list of results, one for each group created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreateGroup(List<RestApiAlertGroupObject> restApiAlertGroupObjectList)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiAlertGroupObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_CreateGroup]}",
                                                                                    restApiAlertGroupObjectList);

         return result;
      }

      /// <summary>
      /// Attempts to create all alert objects specified in the input parameter
      /// </summary>
      /// <param name="RestApiAlertObjectList"></param>
      /// <returns>A list of results, one for each object created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> Create(List<RestApiAlertObject> RestApiAlertObjectList)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiAlertObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_Create]}",
                                                                               RestApiAlertObjectList);

         return result;
      }

      #endregion Create BaseObjects


      #region Update BaseObjects
      /// <summary>
      /// Attempts to update all alert groups specified in the input parameter
      /// </summary>
      /// <param name="restApiAlertGroupObjectList"></param>
      /// <returns>A list of results, one for each group created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdateGroup(List<RestApiAlertGroupObject> restApiAlertGroupObjectList)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiAlertGroupObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_UpdateGroup]}",
                                                                                    restApiAlertGroupObjectList);

         return result;
      }

      /// <summary>
      /// Attempts to update all alert objects specified in the input parameter
      /// </summary>
      /// <param name="RestApiAlertObjectList"></param>
      /// <returns>A list of results, one for each object created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> Update(List<RestApiAlertObject> RestApiAlertObjectList)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiAlertObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_Update]}",
                                                                               RestApiAlertObjectList);

         return result;
      }

      #endregion Update BaseObjects


      #region Delete
      /// <summary>
      /// Attempts to delete the specified alert object or group
      /// </summary>
      /// <param name="deleteRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result)> Delete(DeleteRequestResource deleteRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) result
            = await Post_Request<DeleteRequestResource, DeleteInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Alert_Delete]}",
                                                                    deleteRequestResource);

         return result;
      }

      #endregion Delete

   }
}
