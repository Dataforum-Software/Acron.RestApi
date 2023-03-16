using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Data.Request.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Request.YearData;
using Acron.RestApi.DataContracts.Data.Response.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Response.YearData;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.DataRequests
{
   public class YearDataRequests : DataRequestBase
   {
      public YearDataRequests(RestClient pClient) : base(pClient)
      {
      }
      /// <summary>
      /// Fetches specified year data
      /// </summary>
      /// <param name="getYearDataRequestResource">Specifies the timeframe, process variables and return values</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, YearDataResult Result)> GetYearData(GetYearDataRequestResource getYearDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, YearDataResult Result) result
            = await Post_Request<GetYearDataRequestResource, YearDataResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetYearData]}",
                                                                             getYearDataRequestResource, 
                                                                             CustomHeaders);

         return result;
      }

   }
}
