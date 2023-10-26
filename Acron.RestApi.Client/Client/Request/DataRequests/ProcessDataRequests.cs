using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Data.Request.IntervalData;
using Acron.RestApi.DataContracts.Data.Request.ProcessData;
using Acron.RestApi.DataContracts.Data.Response.IntervalData;
using Acron.RestApi.DataContracts.Data.Response.ProcessData;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.DataRequests
{
   public class ProcessDataRequests : DataRequestBase
   {
      public ProcessDataRequests(RestClient pClient) : base(pClient)
      {

      }
      /// <summary>
      /// Fetches specified process data
      /// </summary>
      /// <param name="getProcessDataRequestResource">Specifies the timeframe, process variables and return values as well as return method</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ProcessDataBase> Result)> GetProcessData(GetProcessDataRequestResource getProcessDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<ProcessDataBase> Result) result
            = await Post_Request<GetProcessDataRequestResource, List<ProcessDataBase>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetProcessData]}",
                                                                                     getProcessDataRequestResource, 
                                                                                     CustomHeaders);

         return result;
      }

      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<WriteProcessDataResultItem> Result)> WriteProcessData(WriteProcessDataRequestResource writeProcessDataRequestResource)
      {

         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, List<WriteProcessDataResultItem> Result) result
            = await Post_Request<WriteProcessDataRequestResource, List<WriteProcessDataResultItem>>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.WriteProcessData]}",
                                                                                     writeProcessDataRequestResource,
                                                                                     CustomHeaders);

         return result;
      }
   }
}
