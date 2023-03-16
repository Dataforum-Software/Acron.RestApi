using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Data.Request.IntervalData;
using Acron.RestApi.DataContracts.Data.Request.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Response.IntervalData;
using Acron.RestApi.DataContracts.Data.Response.MonthWeekData;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.DataRequests
{
   public class MonthWeekDataRequests : DataRequestBase
   {
      public MonthWeekDataRequests(RestClient pClient) : base(pClient)
      {

      }


      /// <summary>
      /// Fetches specified Monthly or weekly data
      /// </summary>
      /// <param name="getMonthWeekDataRequestResource">Specifies the timeframe, process variables and return values</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, MonthWeekDataResult Result)> GetMonthWeekData(GetMonthWeekDataRequestResource getMonthWeekDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, MonthWeekDataResult Result) result
            = await Post_Request<GetMonthWeekDataRequestResource, MonthWeekDataResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetMonthWeekData]}",
                                                                                     getMonthWeekDataRequestResource, 
                                                                                     CustomHeaders);

         return result;
      }

   }
}
