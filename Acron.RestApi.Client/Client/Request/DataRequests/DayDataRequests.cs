using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Data.Request.DayData;
using Acron.RestApi.DataContracts.Data.Response.DayData;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.DataRequests
{
   public class DayDataRequests : DataRequestBase
   {
      public DayDataRequests(RestClient pClient) : base(pClient)
      {

      }

      /// <summary>
      /// Fetches specified day data
      /// </summary>
      /// <param name="getDayDataRequestResource">Specifies the timeframe, process variables and return values</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DayDataResult Result)> GetDayData(GetDayDataRequestResource getDayDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, DayDataResult Result) result
            = await Post_Request<GetDayDataRequestResource, DayDataResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetDayData]}",
                                                                           getDayDataRequestResource,
                                                                           CustomHeaders);

         return result;
      }

   }
}
