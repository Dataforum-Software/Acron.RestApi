using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources;
using Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.ConfigurationRequests
{
   public class ConfigurationProcessVariablesRequests : ConfigurationRequestBase
   {
      public ConfigurationProcessVariablesRequests(RestClient pClient) : base(pClient)
      {
      }

      #region Get Config
      /// <summary>
      /// Fetches all process variables and process variable groups
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAll(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_GetAll]}",
                                                                                       getAllRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all process variable groups
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllGroups(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_GetAllGroups]}",
                                                                                       getAllRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all process variables
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllObjects(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_GetAllObjects]}",
                                                                                       getAllRequestResource);

         return result;
      }

      #endregion Get Config

      #region Validate
      /// <summary>
      /// Validates all process variables
      /// </summary>
      /// <returns>List of invalid items</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result)> ValidateProcessVariables()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) result
            = await Get_Request<List<ErrorItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_Validate]}");

         return result;
      }

      #endregion Validate

      #region Create BaseObjects
      /// <summary>
      /// Attempts to create all process variable groups specified in the input parameter
      /// </summary>
      /// <param name="groups"></param>
      /// <returns>A list of results, one for each group created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreatePvGroup(List<CreatePvVarGroupObjectRequestResource> groups)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<CreatePvVarGroupObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_CreateGroup]}", groups);

         return result;
      }

      /// <summary>
      /// Attempts to create all automatic process variables specified in the input parameter
      /// </summary>
      /// <param name="autoPvs"></param>
      /// <returns>A list of results, one for each variable created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreatePvAuto(List<CreatePvAutoObjectRequestResource> autoPvs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<CreatePvAutoObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_CreatePvAuto]}",
                                                                               autoPvs);

         return result;
      }
      /// <summary>
      /// Attempts to create all manual process variables specified in the input parameter
      /// </summary>
      /// <param name="manualPvs"></param>
      /// <returns>A list of results, one for each variable created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreatePvManual(List<CreatePvManualObjectRequestResource> manualPvs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<CreatePvManualObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_CreatePvManual]}", manualPvs);

         return result;
      }
      /// <summary>
      /// Attempts to create all calculation process variables specified in the input parameter
      /// </summary>
      /// <param name="calcPvs"></param>
      /// <returns>A list of results, one for each variable created, failed to process, or failed to create</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> CreatePvCalc(List<CreatePvCalcObjectRequestResource> calcPvs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<CreatePvCalcObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_CreatePvCalc]}",
                                                                               calcPvs);

         return result;
      }

      #endregion Create BaseObjects

      #region Update BaseObjects
      /// <summary>
      /// Attempts to update all process variable groups specified in the input parameter
      /// </summary>
      /// <param name="groups"></param>
      /// <returns>A list of results, one for each group updated, failed to process, or failed to update</returns>

      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdatePvGroup(List<UpdatePvVarGroupObjectRequestResource> groups)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<UpdatePvVarGroupObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_UpdateGroup]}", groups);

         return result;
      }
      /// <summary>
      /// Attempts to update all automatic process variables specified in the input parameter
      /// </summary>
      /// <param name="autoPvs"></param>
      /// <returns>A list of results, one for each variable updated, failed to process, or failed to update</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdatePvAuto(List<UpdatePvAutoObjectRequestResource> autoPvs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<UpdatePvAutoObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_UpdatePvAuto]}",
                                                                               autoPvs);

         return result;
      }
      /// <summary>
      /// Attempts to update all manual process variables specified in the input parameter
      /// </summary>
      /// <param name="manualPvs"></param>
      /// <returns>A list of results, one for each variable updated, failed to process, or failed to update</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdatePvManual(List<UpdatePvManualObjectRequestResource> manualPvs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<UpdatePvManualObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_UpdatePvManual]}",
                                                                               manualPvs);

         return result;
      }
      /// <summary>
      /// Attempts to update all calculation process variables specified in the input parameter
      /// </summary>
      /// <param name="calcPvs"></param>
      /// <returns>A list of results, one for each variable updated, failed to process, or failed to update</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result)> UpdatePvCalc(List<UpdatePvCalcObjectRequestResource> calcPvs)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, CreateUpdateResult Result) result
            = await Post_Request<List<UpdatePvCalcObjectRequestResource>, CreateUpdateResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_UpdatePvCalc]}",
                                                                               calcPvs);

         return result;
      }


      #endregion UpdateBaseObjects

      #region Delete
      /// <summary>
      /// Attempts to delete the specified process variable or group
      /// </summary>
      /// <param name="deleteRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result)> Delete(DeleteRequestResource deleteRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) result
            = await Post_Request<DeleteRequestResource, DeleteInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ProcessVariables_Delete]}",
                                                                    deleteRequestResource);

         return result;
      }

      #endregion Delete

   }
}
