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
   public class ConfigurationConnectionRequests : ConfigurationRequestBase
   {
      public ConfigurationConnectionRequests(RestClient pClient) : base(pClient)
      {
      }

      #region Get Config 
      /// <summary>
      /// Retrieve all connection objects and groups
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAll(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Connection_GetAll]}",
                                                                                       getAllRequestResource);

         return result;
      }

      /// <summary>
      /// Retrieve all connection groups
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllGroups(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Connection_GetAllGroups]}",
                                                                                       getAllRequestResource);

         return result;
      }

      /// <summary>
      /// Retrieve all connection objects
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllObjects(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Connection_GetAllObjects]}",
                                                                                       getAllRequestResource);

         return result;
      }

      #endregion Get Config


      #region Validate
      /// <summary>
      /// Validates all connection objects
      /// </summary>
      /// <returns>List of invalid items</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result)> ValidateConnections()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) result
            = await Get_Request<List<ErrorItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Connection_Validate]}");

         return result;
      }

      #endregion Validate

      #region Create BaseObjects

      #endregion Create BaseObjects

      #region Update BaseObjects

      #endregion UpdateBaseObjects

      #region Delete

      #endregion Delete

   }
}
