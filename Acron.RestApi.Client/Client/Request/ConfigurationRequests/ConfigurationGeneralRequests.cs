using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.BaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.ConfigurationRequests
{
   public class ConfigurationGeneralRequests : ConfigurationRequestBase
   {
      public ConfigurationGeneralRequests(RestClient pClient) : base(pClient)
      {

      }

      /* 
      ################################################################################################################################################## 
      # You can find CreateAccess, ReleaseAccess, HasAccess, DoIHaveChanges, GetMyChangedObjects, Validate, Save in baseclass ConfigurationRequestBase #
      ##################################################################################################################################################

      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result)> CreateAccess()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) result
            = await Get_Request<PlantConfigUserInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.CreateAccess]}");

         return result;
      }


      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result)> ReleaseAccess()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) result
            = await Get_Request<PlantConfigUserInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ReleaseAccess]}");

         return result;
      }


      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result)> HasAccess()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, PlantConfigUserInfo Result) result
            = await Get_Request<PlantConfigUserInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.HasAccess]}");

         return result;
      }

      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, HasChangedInfo Result)> DoIHaveChanges()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, HasChangedInfo Result) result
            = await Get_Request<HasChangedInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.DoIHaveChanges]}");

         return result;
      }      

      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ChangedObjectInfo> Result)> GetMyChangedObjects()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ChangedObjectInfo> Result) result
            = await Get_Request<List<ChangedObjectInfo>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetMyChangedObjects]}");

         return result;
      }

      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result)> Validate()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ErrorItem> Result) result
            = await Get_Request<List<ErrorItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Validate]}");

         return result;
      }

      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result)> Save(SaveRequestResource saveRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, SaveInfo Result) result
            = await Post_Request<SaveRequestResource, SaveInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Save]}", saveRequestResource);

         return result;
      }
      */
      /// <summary>
      /// Initiate an object type with default values for use in subsequent operations
      /// Caution: The returned object is not added to the plant configuration
      /// </summary>
      /// <typeparam name="RestObjectType"></typeparam>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestObjectType Result)> DefaultValues<RestObjectType>() where RestObjectType : class, IBaseObject, new()
      {
         IBaseObject tmp = new RestObjectType();
         DefaultValuesRequestResource defaultValuesRequestResource = new DefaultValuesRequestResource() { RestApiTypeCode = tmp.RestTypeCode };
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestObjectType Result) result
            = await Post_Request<DefaultValuesRequestResource, RestObjectType>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.DefaultValues]}", 
                                                                               defaultValuesRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all properties of a given configuration object
      /// </summary>
      /// <param name="objectInfoRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestApiBaseObject Result)> ObjectInfo(ObjectInfoRequestResource objectInfoRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, RestApiBaseObject Result) result
            = await Post_Request<ObjectInfoRequestResource, RestApiBaseObject>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ObjectInfo]}", 
                                                                               objectInfoRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all properties and references of a given configuration object
      /// </summary>
      /// <param name="ObjectInfoEnhancedRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ObjectInfoEnhanced Result)> ObjectInfoEnhanced(ObjectInfoEnhancedRequestResource ObjectInfoEnhancedRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ObjectInfoEnhanced Result) result
            = await Post_Request<ObjectInfoEnhancedRequestResource, ObjectInfoEnhanced>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ObjectInfoEnhanced]}", 
                                                                                        ObjectInfoEnhancedRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all children of a given configuration object recursively
      /// </summary>
      /// <param name="getSubObjectsRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result)> GetSubObjects(GetSubObjectsRequestResource getSubObjectsRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestApiBaseObject> Result) result
            = await Post_Request<GetSubObjectsRequestResource, List<RestApiBaseObject>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetSubObjects]}", 
                                                                                        getSubObjectsRequestResource);

         return result;
      }

      /// <summary>
      /// Fetches all object types in the current configuration
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestObjectInfo> Result)> ObjectTypes()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<RestObjectInfo> Result) result
            = await Get_Request<List<RestObjectInfo>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.ObjectTypes]}");

         return result;
      }

      /// <summary>
      /// Fetches all supported Timezones
      /// </summary>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<TimeZoneIDItem> Result)> GetTimeZoneIDs()
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<TimeZoneIDItem> Result) result
            = await Get_Request<List<TimeZoneIDItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.TimeZoneIDs]}");

         return result;
      }

      /// <summary>
      /// Deletes the provided object from the configuration
      /// </summary>
      /// <param name="deleteRequestResource"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result)> Delete(DeleteRequestResource deleteRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DeleteInfo Result) result
            = await Post_Request<DeleteRequestResource, DeleteInfo>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.Delete]}",
                                                                    deleteRequestResource);

         return result;
      }
   }
}
