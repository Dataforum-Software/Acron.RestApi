using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Data.Request.StringCompData;
using Acron.RestApi.DataContracts.Data.Response.StringCompData;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.DataRequests
{
   public class StringCompDataRequests : DataRequestBase
   {
      public StringCompDataRequests(RestClient pClient) : base(pClient)
      {

      }

      /// <summary>
      /// Fetches specified day data
      /// </summary>
      /// <param name="getStringCompDataRequestResource">Specifies the timeframe, process variables and return values</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, GetStringCompDataResult Result)> GetStringCompData(GetStringCompDataRequestResource getStringCompDataRequestResource)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, GetStringCompDataResult Result) result
            = await Post_Request<GetStringCompDataRequestResource, GetStringCompDataResult>($"{BaseAddress}{RouteDefines.Instance.Routes[RouteDefines.RouteKeys.GetStringCompData]}",
                                                                           getStringCompDataRequestResource,
                                                                           CustomHeaders);

         return result;
      }

   }
}
