using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Request.Base
{
   public abstract class RestClientRequestBase
   {
      /// <summary>
      /// Initializes the Request
      /// </summary>
      /// <param name="pClient">Sets the client to be used for this request</param>
      public RestClientRequestBase(RestClient pClient)
      {
         Client = pClient;
      }

      protected RestClient Client { get; private set; }
      public string BaseAddress { get { return Client.BaseAddress; } }
      public float Version { get { return Client.Version; } }


      #region Headers
      private List<KeyValuePair<string, string>> _fixedRequestHeaders = new List<KeyValuePair<string, string>>()
      {
         new KeyValuePair<string, string>(HeaderDefines.Keys.Content.Accept, HeaderDefines.Values.Content.Accept),
      };

      protected virtual List<KeyValuePair<string, string>> GetFixedRequestHeaders()
      {
         return _fixedRequestHeaders;
      }


      private List<KeyValuePair<string, string>> _fixedRequestContentHeaders = new List<KeyValuePair<string, string>>
      {
         new KeyValuePair<string, string>(HeaderDefines.Keys.Content.ContentType, HeaderDefines.Values.Content.ContentType),
      };

      protected virtual List<KeyValuePair<string, string>> GetFixedRequestContentHeaders()
      {
         return _fixedRequestContentHeaders;
      }
      #endregion Headers


      protected virtual void SetRequestHeaders(HttpRequestMessage httpRequestMessage, List<KeyValuePair<string, string>> customHeaders = null)
      {
         httpRequestMessage.Headers.Clear();

         List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();

         List<KeyValuePair<string, string>> tmp = GetFixedRequestHeaders();
         if (tmp != null && tmp.Any())
         {
            headers.AddRange(tmp);
         }
         if (customHeaders != null && customHeaders.Any())
         {
            headers.AddRange(customHeaders);
         }

         if (headers != null && headers.Any())
         {
            headers.ToList().ForEach(h =>
            {
               httpRequestMessage.Headers.Add(h.Key, h.Value);
            });
         }
      }

      private void SetRequestContentHeaders(HttpRequestMessage httpRequestMessage)
      {
         List<KeyValuePair<string, string>> contentHeaders = GetFixedRequestContentHeaders();
         if (contentHeaders != null && contentHeaders.Any())
         {
            httpRequestMessage.Content.Headers.Clear();
            contentHeaders.ForEach(h =>
            {
               httpRequestMessage.Content.Headers.Add(h.Key, h.Value);
            });
         }
      }

      /// <summary>
      /// Sends the request using the POST method
      /// </summary>
      /// <typeparam name="RequestResourceType"></typeparam>
      /// <typeparam name="ResultType"></typeparam>
      /// <param name="url"></param>
      /// <param name="content"></param>
      /// <param name="customHeaders">Custom headers outside of Content-type, Accept and Authorisation</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ResultType Result)> Post_Request<RequestResourceType, ResultType>
              (string url,
               RequestResourceType content,
               List<KeyValuePair<string, string>> customHeaders = null)
                                                                        where RequestResourceType : class, new()
                                                                        where ResultType : class, new()
      {

         try
         {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = HttpMethod.Post;
            message.RequestUri = new Uri(url);

            SetRequestHeaders(message, customHeaders);

            string contentString = JsonConvert.SerializeObject(content);
            message.Content = new StringContent(contentString);

            SetRequestContentHeaders(message);

            HttpResponseMessage httpResponse = await Client._HttpClient.SendAsync(message);

            (bool HasError, string ErrorText, AcResponseTypes ResponseBaseType, ApiControllerResponseBase ResponseBase, ResultType Result) result = await DeserializeHttpResponse<ResultType>(httpResponse);

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ResultType Result) retVal = ResolveResponse(httpResponse, result);

            return retVal;
         }
         catch (Exception ex)
         {
            return (true, ex.Message, default, default);
         }
      }

      private (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ResultType Result) ResolveResponse<ResultType>(HttpResponseMessage httpResponseMessage, (bool HasError, string ErrorText, AcResponseTypes ResponseBaseType, ApiControllerResponseBase ResponseBase, ResultType Result) responseMessage)
      {
         (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ResultType Result) retVal = (responseMessage.HasError, responseMessage.ErrorText, responseMessage.ResponseBase, responseMessage.Result);
         if (responseMessage.HasError)
            return retVal;

         switch (responseMessage.ResponseBaseType)
         {
            case AcResponseTypes.AcAuthenticationFailedResponse:
            case AcResponseTypes.AcBadModelStateResponse:
            case AcResponseTypes.AcBadRequestResponse:
            case AcResponseTypes.AcLicenceInfoResponse:
            case AcResponseTypes.AcNotFoundResponse:
            case AcResponseTypes.AcUnauthorizedResponse:
            case AcResponseTypes.AcUnsupportedApiVersionResponse:
               retVal.HasError = true;
               if (retVal.ResponseBase.ApiActionResult != null)
                  retVal.ErrorText = $"{retVal.ResponseBase.ApiActionResult}: ";               
               retVal.ErrorText += (retVal.ResponseBase as AcBadRequestResponse).ErrorText;
               break;


            case AcResponseTypes.AcExceptionResponse:
               retVal.HasError = true;
               if (retVal.ResponseBase.ApiActionResult != null)
                  retVal.ErrorText = $"{retVal.ResponseBase.ApiActionResult}: ";
               retVal.ErrorText += (retVal.ResponseBase as AcExceptionResponse).ExceptionMessage;
               break;

            case AcResponseTypes.AcServiceUnavailableResponse:
               retVal.HasError = true;
               if (retVal.ResponseBase.ApiActionResult != null)
                  retVal.ErrorText = $"{retVal.ResponseBase.ApiActionResult}: ";
               retVal.ErrorText += (retVal.ResponseBase as AcServiceUnavailableResponse).Message;
               break;


            case AcResponseTypes.AcOkResponse:
               retVal.HasError = false;
               break;

            case AcResponseTypes.AcBadCreateUpdateResponse:
               retVal.HasError = true;
               if (retVal.ResponseBase.ApiActionResult != null)
                  retVal.ErrorText = $"{retVal.ResponseBase.ApiActionResult}: ";
               retVal.ErrorText += (retVal.ResponseBase as AcBadCreateUpdateResponse).ErrorText;
               break;

            default:
               return (true, $"Unknown response type '{responseMessage.ResponseBaseType}'", default, default);
         }

         return retVal;
      }



      /// <summary>
      /// Sends the request using the GET method
      /// </summary>
      /// <typeparam name="ResultType"></typeparam>
      /// <param name="url"></param>
      /// <param name="customHeaders">Custom headers outside of Content-type, Accept and Authorisation</param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ResultType Result)> Get_Request<ResultType>
              (string url,
               List<KeyValuePair<string, string>> customHeaders = null)
                                                                        where ResultType : class, new()
      {
         try
         {
            HttpRequestMessage message = new HttpRequestMessage();
            message.Method = HttpMethod.Get;
            message.RequestUri = new Uri(url);

            SetRequestHeaders(message, customHeaders);

            HttpResponseMessage httpResponse = await Client._HttpClient.SendAsync(message);

            (bool HasError, string ErrorText, AcResponseTypes ResponseBaseType, ApiControllerResponseBase ResponseBase, ResultType Result) result = await DeserializeHttpResponse<ResultType>(httpResponse);

            (bool HasError, string ErrorText, ApiControllerResponseBase ResponseBase, ResultType Result) retVal = ResolveResponse(httpResponse, result);

            return retVal;
         }
         catch (Exception ex)
         {
            return (true, ex.Message, default, default);
         }
      }

      /// <summary>
      /// Deserialises a HttpResponseMessage into specific Acron components
      /// </summary>
      /// <typeparam name="ResultType"></typeparam>
      /// <param name="response"></param>
      /// <returns></returns>
      public async Task<(bool HasError, string ErrorText, AcResponseTypes ResponseBaseType, ApiControllerResponseBase ResponseBase, ResultType Result)> DeserializeHttpResponse<ResultType>
               (HttpResponseMessage response) where ResultType : class, new()
      {
         bool hasError = false;
         string errorText = string.Empty;
         ApiControllerResponseBase apiResponse = null;
         ResultType result = default;
         bool doDeserializeResult = false;
         AcResponseTypes responseTypeEnum = AcResponseTypes.Unknown;

         if (response.Headers.TryGetValues("AcronResponseType", out IEnumerable<string> responseTypes))
         {
            if (responseTypes != null && responseTypes.Any())
            {
               string responseType = responseTypes.FirstOrDefault();
               responseTypeEnum = (AcResponseTypes)Enum.Parse(typeof(AcResponseTypes), responseType);
               object responseResult = null;
               string responseResultType = null;

               JsonSerializer serializer = new JsonSerializer();
               using (StreamReader sr = new StreamReader(await response.Content.ReadAsStreamAsync()))
               {
                  using (JsonTextReader reader = new JsonTextReader(sr))
                  {
                     switch (responseTypeEnum)
                     {
                        case AcResponseTypes.AcBadCreateUpdateResponse:
                           apiResponse = serializer.Deserialize<AcBadCreateUpdateResponse>(reader);
                           responseResult = (apiResponse as AcBadCreateUpdateResponse).Result;
                           responseResultType = (apiResponse as AcBadCreateUpdateResponse).ResultType;
                           if (responseResult != null)
                           {
                              if (responseResult.GetType() != typeof(ResultType))
                              {
                                 doDeserializeResult = true;
                              }
                              else
                              {
                                 result = (ResultType)responseResult;
                              }
                           }
                           break;

                        case AcResponseTypes.AcOkResponse:
                           apiResponse = serializer.Deserialize<AcOkResponse>(reader);
                           responseResult = (apiResponse as AcOkResponse).Result;
                           responseResultType = (apiResponse as AcOkResponse).ResultType;
                           if (responseResult != null)
                           {
                              if (responseResult.GetType() != typeof(ResultType))
                              {
                                 doDeserializeResult = true;
                              }
                              else
                              {
                                 result = (ResultType)responseResult;
                              }
                           }
                           break;

                        case AcResponseTypes.AcAuthenticationFailedResponse:
                           apiResponse = serializer.Deserialize<AcAuthenticationFailedResponse>(reader);
                           break;
                        case AcResponseTypes.AcBadModelStateResponse:
                           apiResponse = serializer.Deserialize<AcBadModelStateResponse>(reader);
                           break;
                        case AcResponseTypes.AcBadRequestResponse:
                           apiResponse = serializer.Deserialize<AcBadRequestResponse>(reader);
                           break;
                        case AcResponseTypes.AcExceptionResponse:
                           apiResponse = serializer.Deserialize<AcExceptionResponse>(reader);
                           break;
                        case AcResponseTypes.AcLicenceInfoResponse:
                           apiResponse = serializer.Deserialize<AcLicenceInfoResponse>(reader);
                           break;
                        case AcResponseTypes.AcNotFoundResponse:
                           apiResponse = serializer.Deserialize<AcNotFoundResponse>(reader);
                           break;
                        case AcResponseTypes.AcServiceUnavailableResponse:
                           apiResponse = serializer.Deserialize<AcServiceUnavailableResponse>(reader);
                           break;
                        case AcResponseTypes.AcUnauthorizedResponse:
                           apiResponse = serializer.Deserialize<AcUnauthorizedResponse>(reader);
                           break;
                        case AcResponseTypes.AcUnsupportedApiVersionResponse:
                           apiResponse = serializer.Deserialize<AcUnsupportedApiVersionResponse>(reader);
                           break;

                        default:
                           return (true, $"ResponseType '{responseTypeEnum}' not implemented", AcResponseTypes.Unknown, default, default);
                     }

                     if (doDeserializeResult)
                     {
                        switch (responseResult)
                        {
                           case string tmp:
                              result = (ResultType)responseResult;
                              break;

                           default:
                              try
                              {
                                 result = JsonConvert.DeserializeObject<ResultType>(responseResult.ToString());
                              }
                              catch (Exception ex)
                              {
                                 hasError = true;
                                 errorText = $"{ex.Message}";
                              }
                              break;
                        }
                     }
                  }
               }
            }
            else
            {
               return (true, "Header 'AcronResponseType' not found", AcResponseTypes.Unknown, default, default);
            }
         }
         else
         {
            return (true, "Header 'AcronResponseType' not found", AcResponseTypes.Unknown, default, default);
         }

         return (hasError, errorText, responseTypeEnum, apiResponse, result);
      }
   }
}
