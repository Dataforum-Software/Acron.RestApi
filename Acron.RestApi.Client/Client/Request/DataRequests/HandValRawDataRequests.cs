using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.GetHandValRawData;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawData;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using Acron.RestApi.DataContracts.Data.Request.YearData;
using Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData;
using Acron.RestApi.DataContracts.Data.Response.HandValRawData.WriteHandValComments;
using Acron.RestApi.DataContracts.Data.Response.HandValRawData.WriteHandValRawData;
using Acron.RestApi.DataContracts.Data.Response.HandValRawData.WriteHandValRawDataAndInfos;
using Acron.RestApi.DataContracts.Data.Response.YearData;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValRawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.DataRequests
{
   public class HandValRawDataRequests : DataRequestBase
   {
      public HandValRawDataRequests(RestClient pClient) : base(pClient)
      {
      }
      /// <summary>
      /// Fetches the specfied raw data of specified manual variables
      /// </summary>
      /// <param name="getHandValRawDataRequestResource">Specifies the timeframe, process variables and return values</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, GetHandValRawDataResult Result)> GetHandValRawData(GetHandValRawDataRequestResource getHandValRawDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, GetHandValRawDataResult Result) result
            = await Post_Request<GetHandValRawDataRequestResource, GetHandValRawDataResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetHandValRawData]}",
                                                                                            getHandValRawDataRequestResource,
                                                                                            CustomHeaders);

         return result;
      }
      /// <summary>
      /// Write raw data of specified manual variables
      /// </summary>
      /// <param name="writeHandValRawDataRequestResource">Specifies the variables and raw data to write</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, WriteHandValRawDataResult Result)> WriteHandValRawData(WriteHandValRawDataRequestResource writeHandValRawDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, WriteHandValRawDataResult Result) result
            = await Post_Request<WriteHandValRawDataRequestResource, WriteHandValRawDataResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.WriteHandValRawData]}",
                                                                                            writeHandValRawDataRequestResource,
                                                                                            CustomHeaders);

         return result;
      }

      /// <summary>
      /// Write comments for specified manual variables
      /// </summary>
      /// <param name="writeHandValCommentsRequestResouce"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, WriteCommentsResult Result)> WriteHandValComments(WriteHandValCommentsRequestResouce writeHandValCommentsRequestResouce)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, WriteCommentsResult Result) result
         = await Post_Request<WriteHandValCommentsRequestResouce, WriteCommentsResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.WriteHandValComments]}",
                                                                                                 writeHandValCommentsRequestResouce,
                                                                                                 CustomHeaders);

         return result;
      }

      /// <summary>
      /// Write both raw data and advanced attributes of specified manual variables
      /// </summary>
      /// <param name="writeHandValRawDataAndInfosRequestResource">Specifies the variables, raw data and attributes to write</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, WriteHandValRawDataAndInfoResult Result)> WriteHandValRawDataAndInfo(WriteHandValRawDataAndInfosRequestResource writeHandValRawDataAndInfosRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, WriteHandValRawDataAndInfoResult Result) result
            = await Post_Request<WriteHandValRawDataAndInfosRequestResource, WriteHandValRawDataAndInfoResult>
                                                                           ($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.WriteHandValRawDataAndInfos]}",
                                                                            writeHandValRawDataAndInfosRequestResource,
                                                                            CustomHeaders);

         return result;
      }

   }
}
