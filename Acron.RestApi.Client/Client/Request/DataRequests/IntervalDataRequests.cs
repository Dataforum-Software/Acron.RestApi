using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Data.Request.DayData;
using Acron.RestApi.DataContracts.Data.Request.IntervalData;
using Acron.RestApi.DataContracts.Data.Response.DayData;
using Acron.RestApi.DataContracts.Data.Response.IntervalData;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.DataRequests
{
   public class IntervalDataRequests : DataRequestBase
   {
      public IntervalDataRequests(RestClient pClient) : base(pClient)
      {

      }
      /// <summary>
      ///Fetches specified interval data
      /// </summary>
      /// <param name="getIntervalDataRequestResource">Specifies the timeframe, interval type, process variables and return values</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, IntervalDataResult Result)> GetIntervalData(GetIntervalDataRequestResource getIntervalDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, IntervalDataResult Result) result
            = await Post_Request<GetIntervalDataRequestResource, IntervalDataResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetIntervalData]}",
                                                                                     getIntervalDataRequestResource,
                                                                                     CustomHeaders);

         return result;
      }

   }
}
