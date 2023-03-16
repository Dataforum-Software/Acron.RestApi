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
   public class ConfigurationProcessConnectionRequests : ConfigurationRequestBase
   {
      public ConfigurationProcessConnectionRequests(RestClient pClient) : base(pClient)
      {
      }

      #region Get Config
      /// <summary>
      /// Fetches all available Provider drivers
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiProviderDriverObject> Result)> GetDriver()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiProviderDriverObject> Result) result
            = await Get_Request<List<RestApiProviderDriverObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_GetProviderDriver]}");

         return result;
      }
      /// <summary>
      /// Fetches all ProccessConnection objects and groups
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAll(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_GetAll]}",
                                                                                       getAllRequestResource);

         return result;
      }
      /// <summary>
      /// Fetches all ProcessConnection groups
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllGroups(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_GetAllGroups]}",
                                                                                       getAllRequestResource);

         return result;
      }
      /// <summary>
      /// Fetches all ProcessConnection objects
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllObjects(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_GetAllObjects]}",
                                                                                       getAllRequestResource);

         return result;
      }

      #endregion Get Config

      #region Validate
      /// <summary>
      /// Validates all ProcessConnection objects
      /// </summary>
      /// <returns>List of invalid items</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result)> ValidateProcessConnection()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) result
            = await Get_Request<List<ErrorItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_Validate]}");

         return result;
      }

      #endregion Validate

      #region Create BaseObjects
      /// <summary>
      /// Attempts to create all Provider objects specified in the input parameter
      /// </summary>
      /// <param name="provs"></param>
      /// <returns>A list of results, one for each object created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreateProvider(List<RestApiProviderObject> provs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiProviderObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_CreateProvider]}",
                                                                                    provs);

         return result;
      }
      /// <summary>
      /// Attempts to create all external variable groups specified in the input parameter
      /// </summary>
      /// <param name="groups"></param>
      /// <returns>A list of results, one for each group created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreateExtVarGroup(List<RestApiExtVarGroupObject> groups)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiExtVarGroupObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_CreateGroup]}",
                                                                                    groups);

         return result;
      }
      /// <summary>
      /// Attempts to create all external variables specified in the input parameter
      /// </summary>
      /// <param name="extVars"></param>
      /// <returns>A list of results, one for each object created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreateExtVar(List<RestApiExtVarObject> extVars)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiExtVarObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_CreateExtVar]}",
                                                                               extVars);

         return result;
      }

      #endregion Create BaseObjects

      #region Update BaseObjects
      /// <summary>
      /// Attempts to update all Provider objects specified in the input parameter
      /// </summary>
      /// <param name="provs"></param>
      /// <returns>A list of results, one for each object created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdateProvider(List<RestApiProviderObject> provs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiProviderObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_UpdateProvider]}",
                                                                                    provs);

         return result;
      }
      /// <summary>
      /// Attempts to update all external variable groups specified in the input parameter
      /// </summary>
      /// <param name="groups"></param>
      /// <returns>A list of results, one for each group created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdateExtVarGroup(List<RestApiExtVarGroupObject> groups)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiExtVarGroupObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_UpdateGroup]}",
                                                                                    groups);

         return result;
      }
      /// <summary>
      /// Attempts to update all external variables specified in the input parameter
      /// </summary>
      /// <param name="extVars"></param>
      /// <returns>A list of results, one for each object created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdateExtVar(List<RestApiExtVarObject> extVars)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<RestApiExtVarObject>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_UpdateExtVar]}",
                                                                               extVars);

         return result;
      }

      #endregion UpdateBaseObjects

      #region Delete
      /// <summary>
      /// Attempts to delete the specified ProcessConnection object or group
      /// </summary>
      /// <param name="deleteRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result)> Delete(DeleteRequestResource deleteRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) result
            = await Post_Request<DeleteRequestResource, DeleteInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessConnection_Delete]}",
                                                                    deleteRequestResource);

         return result;
      }

      #endregion Delete

   }
}
