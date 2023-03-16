using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.ConfigurationRequests
{
   public class ConfigurationUnitRequests : ConfigurationRequestBase
   {
      public ConfigurationUnitRequests(RestClient pClient) : base(pClient)
      {
      }

      #region Get Config 

      /// <summary>
      /// Fetches all unit and base unit objects 
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAll(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Unit_GetAll]}",
                                                                                       getAllRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all base unit objects
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllBaseUnits(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Unit_GetAllBaseUnits]}",
                                                                                       getAllRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all unit objects
      /// </summary>
      /// <param name="getAllRequestResource">Specifies whether small objects should be included</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetAllObjects(GetAllRequestResource getAllRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetAllRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Unit_GetAllObjects]}",
                                                                                       getAllRequestResource);

         return result;
      }

      #endregion Get Config


      #region Validate
      /// <summary>
      /// Validates all unit and base unit objects
      /// </summary>
      /// <returns>List of invalid items</returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result)> ValidateUnits()
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
