using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.DataRequests;
using Acron.RestApi.DataContracts.Data.Request.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Request.ProcessData;
using Acron.RestApi.DataContracts.Data.Response.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Response.ProcessData;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using Acron.RestApi.Interfaces.DataFormatter;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines.ConfigDefines;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal class GetMonthWeekDataWrapper : ObservableObject, IWrapper
   {
      #region ctor

      public GetMonthWeekDataWrapper(RestClient client)
      {
         _myMonthWeekDataRequest = new MonthWeekDataRequests(client);
         Name = string.Empty;
         _responseBodyText = string.Empty;
         _errorText = string.Empty;
         Url = string.Empty;
         Input = new();
         string helper = GetType().Name.Replace("Wrapper", "");
         FieldInfo routeKey = (typeof(RouteDefines.RouteKeys).GetFields().First(x => x.Name == helper));
         Url = _myMonthWeekDataRequest.BaseAddress + RouteDefines.Instance.Routes[(RouteDefines.RouteKeys)routeKey!.GetValue(true)!];
         _visualizedCollection = new();
         FetchCustoms();
      }

      #endregion

      #region Fields

      MonthWeekDataRequests _myMonthWeekDataRequest;

      #endregion

      #region Properties
      public string Name
      {get;init;
      }

      public string Url
      {get;init;
      }

      public Methods HttpMethod
      {
         get
         {
            if (GetType().GetProperties().Any(x => x.Name == "Input"))
               return Methods.POST;

            return Methods.GET;
         }
         set
         {

         }
      }

      public string InputBodyText
      {
         get
         {
            return JsonConvert.SerializeObject(Input, Formatting.Indented);
         }
         set
         {
            try
            {
               var jsonstring = JsonConvert.DeserializeObject<GetMonthWeekDataRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }

      public GetMonthWeekDataRequestResource Input { get; set; }

      private ApiControllerResponseBase? _response;
      public ApiControllerResponseBase? Response
      {
         get { return _response; }
         set
         {
            SetProperty(ref _response, value);
         }
      }

      private string _errorText = string.Empty;
      public string ErrorText
      {
         get { return _errorText; }
         set
         {
            SetProperty(ref _errorText, value);
         }
      }

      public List<KeyValuePair<string, string>> Headers
      {
         get
         {
            if (_myMonthWeekDataRequest is null)
               return new();
            return new()
            {
               new("Accept", "application/json"),
               new("Authorization", "Bearer "+ _myMonthWeekDataRequest.AccessToken),
               new("Acron", _myMonthWeekDataRequest.UserToken)
            };
         }
      }

      private ObservableCollection<DataItem>? _customHeaders;
      public ObservableCollection<DataItem>? CustomHeaders
      {
         get { return _customHeaders; }
         set { SetProperty(ref _customHeaders, value); }
      }

      public dynamic? Result { get; set; }

      private string _responseBodyText;
      public string ResponseBodyText
      {
         get
         {
            return _responseBodyText;
         }

         set
         {
            SetProperty(ref _responseBodyText, value);
         }
      }
      private HttpStatusCode _statusCode = HttpStatusCode.Unused;
      public HttpStatusCode StatusCode
      {
         get
         {
            return _statusCode;
         }
         set
         {
            if (SetProperty(ref _statusCode, value))
               OnPropertyChanged(nameof(StatusCodeString));

         }
      }

      private bool _hasError;
      public bool HasError
      {
         get
         {
            return _hasError;
         }
         set
         {
            SetProperty(ref _hasError, value);
         }
      }

      public string StatusCodeString
      {
         get { return ((int)StatusCode).ToString() + " - " + StatusCode.ToString(); }
      }

      private ObservableCollection<VisualisationHelper>? _visualizedCollection;
      public ObservableCollection<VisualisationHelper>? VisualizedCollection
      {
         get { return _visualizedCollection; }
      }


      public bool TimeVisible
      {
         get
         {
            if (VisualizedCollection is null)
               return false;
            if (!VisualizedCollection.Any())
               return false;
            if (VisualizedCollection.Count == 1)
               return true;
            if (VisualizedCollection.All(x => x._timeStamp.TimeOfDay == VisualizedCollection[0]._timeStamp.TimeOfDay))
            {
               if (VisualizedCollection.All(x => x._timeStamp.Date == VisualizedCollection[0]._timeStamp.Date))
                  return true;
               else
                  return false;
            }

            return true;
         }
      }

      public bool DateVisible
      {
         get
         {
            if (VisualizedCollection is null)
               return false;
            if (!VisualizedCollection.Any())
               return false;
            if (VisualizedCollection.Count == 1)
               return true;
            if (VisualizedCollection.All(x => x._timeStamp.Date == VisualizedCollection[0]._timeStamp.Date))
            {
               if (VisualizedCollection.All(x => x._timeStamp.TimeOfDay == VisualizedCollection[0]._timeStamp.TimeOfDay))
                  return true;
               else
                  return false;
            }

            return true;
         }
      }


      private ApiActionResult? _apiResponse;
      public ApiActionResult? ApiResponse
      {
         get { return _apiResponse; }
         set
         {
            SetProperty(ref _apiResponse, value);
         }
      }

      #endregion

      #region Methods
      private void UpdateCustoms()
      {
         string? locale = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.FormatLocale.ToString())?.Value;
         if (!string.IsNullOrEmpty(locale))
            _myMonthWeekDataRequest?.SetFormatLocale(locale);
         string? timezone = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString())?.Value;
         if (!string.IsNullOrEmpty(timezone))
            _myMonthWeekDataRequest?.SetTargetTimeZone(timezone);
         string? timestamps = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.FormatTimeStampSettings.ToString())?.Value;
         if (!string.IsNullOrEmpty(timestamps))
            _myMonthWeekDataRequest?.SetTimestampSettingsHeader(timestamps);
         string? valueLocal = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.FormatValueSettings.ToString())?.Value;
         if (!string.IsNullOrEmpty(valueLocal))
            _myMonthWeekDataRequest?.SetFormatValueSettingsHeader(valueLocal);
      }
      private void FetchCustoms()
      {
         var cHeaders = _myMonthWeekDataRequest?.GetCustomHeaders();
         if (cHeaders is null)
            return;
         if (cHeaders.Count > 0)
            CustomHeaders = new();
         foreach (var cHeader in cHeaders)
         {
            CustomHeaders?.Add(new() { Key = cHeader.Key, Value = cHeader.Value });
         }
      }
      protected void ReadOutResponse()
      {
         if (Response == null)
            return;

         FetchCustoms();

         ResponseBodyText = JsonConvert.SerializeObject(Response, Formatting.Indented);


         if (Response is AcBadRequestResponse acBadRequest)
         {
            ErrorText = acBadRequest.ErrorText;
         }
      }

      public async Task ExecuteMethod()
      {
         if (_myMonthWeekDataRequest == null)
            return;
         UpdateCustoms();
         (HasError, ErrorText, Response, Result) = await _myMonthWeekDataRequest.GetMonthWeekData(Input);
         if (HasError && Response is null)   
         {
            Debug.WriteLine(ErrorText);
            MessageBox.Show(ErrorText, "Error");
         }
         else
         {
            ReadOutResponse();
            StatusCode = Response.HttpStatusCode;
            ApiResponse = Response.ApiActionResult;
            if (Result is not MonthWeekDataResult cResult)
               return;
            _visualizedCollection ??= new();
            _visualizedCollection.Clear();
            if(cResult.HasData && cResult.TimeStampsCount== cResult.PVCount)
            {
               for(int i=0;i<cResult.PVCount;i++)
               {
                  VisualisationHelper vh = new();
                  if (Input.PVDescriptions[0].MonthWeekWhat.MDAT_MVAL)
                     vh.IValue = cResult.Data[0].MDAT_MVAL[i];
                  if (Input.PVDescriptions[0].MonthWeekWhat.MDAT_IMIN)
                     vh.MinValue = cResult.Data[0].MDAT_IMIN[i];
                  if (Input.PVDescriptions[0].MonthWeekWhat.MDAT_IMAX)
                     vh.MaxValue = cResult.Data[0].MDAT_IMAX[i];
                  VisualizedCollection?.Add(vh);
               }
            }
            OnPropertyChanged(nameof(TimeVisible));
            OnPropertyChanged(nameof(DateVisible));
         }
      }


      #endregion
   }
}
