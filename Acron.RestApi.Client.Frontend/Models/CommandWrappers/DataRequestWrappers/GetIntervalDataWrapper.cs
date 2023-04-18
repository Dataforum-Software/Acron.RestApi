using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.DataRequests;
using Acron.RestApi.Client.Frontend.XamlConverters;
using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Data.Request.IntervalData;
using Acron.RestApi.DataContracts.Data.Response.IntervalData;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using Acron.RestApi.Interfaces.DataFormatter;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines.ConfigDefines;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal class GetIntervalDataWrapper : ObservableObject, IWrapper
   {
      #region ctor
      public GetIntervalDataWrapper(RestClient? client = null)
      {
         _myIntervalDataRequest = new IntervalDataRequests(client);
         _visualizedCollection = new();
         Name = string.Empty;
         _responseBodyText = string.Empty;
         _errorText = string.Empty;
         Input = new();
         Url = string.Empty;
         if (_myIntervalDataRequest is null)
            return;
         string helper = GetType().Name.Replace("Wrapper", "");
         FieldInfo routeKey = (typeof(RouteDefines.RouteKeys).GetFields().First(x => x.Name == helper));
         Url = _myIntervalDataRequest.BaseAddress + RouteDefines.Instance.Routes[(RouteDefines.RouteKeys)routeKey.GetValue(true)!];
         FetchCustoms();
      }
      #endregion

      #region Fields
      protected IntervalDataRequests? _myIntervalDataRequest;

      #endregion

      #region Properties
      public GetIntervalDataRequestResource Input { get; set; }

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
      public string Name
      {
         get;

         init;
      }

      public string Url
      {
         get;

         init;
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

      public virtual string InputBodyText
      {
         get
         {
            return JsonConvert.SerializeObject(Input, Formatting.Indented);
         }
         set
         {
            try
            {
               var jsonstring = JsonConvert.DeserializeObject<GetIntervalDataRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }


      private ApiControllerResponseBase? _response;
      public ApiControllerResponseBase? Response
      {
         get
         {
            return _response;
         }

         set
         {
            SetProperty(ref _response, value);
         }
      }

      public List<KeyValuePair<string, string>> Headers
      {
         get
         {
            if (_myIntervalDataRequest is null)
               return new();
            return new()
            {
               new("Accept", "application/json"),
               new("Authorization", "Bearer "+ _myIntervalDataRequest.AccessToken),
               new("Acron", _myIntervalDataRequest.UserToken)
            };
         }
      }


      private ObservableCollection<DataItem>? _customHeaders;
      public ObservableCollection<DataItem>? CustomHeaders
      {
         get { return _customHeaders; }
         set { SetProperty(ref _customHeaders, value); }
      }


      private string _errorText;
      public string ErrorText
      {
         get { return _errorText; }
         set
         {
            SetProperty(ref _errorText, value);
         }
      }

      public dynamic? Result
      {
         get; set;
      }

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
      public string StatusCodeString
      {
         get { return ((int)StatusCode).ToString() + " - " + StatusCode.ToString(); }
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

      private ObservableCollection<VisualisationHelper> _visualizedCollection;
      public ObservableCollection<VisualisationHelper> VisualizedCollection
      {
         get { return _visualizedCollection; }
         set
         {
            SetProperty(ref _visualizedCollection, value);
         }
      }

      #endregion

      #region Methods

      private void UpdateCustoms()
      {
         string? locale = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.FormatLocale.ToString())?.Value;
         if (!string.IsNullOrEmpty(locale))
            _myIntervalDataRequest?.SetFormatLocale(locale);
         string? timezone = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString())?.Value;
         if (!string.IsNullOrEmpty(timezone))
            _myIntervalDataRequest?.SetTargetTimeZone(timezone);
         string? timestamps = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.FormatTimeStampSettings.ToString())?.Value;
         if (!string.IsNullOrEmpty(timestamps))
            _myIntervalDataRequest?.SetTimestampSettingsHeader(timestamps);
         string? valueLocal = CustomHeaders?.FirstOrDefault(x => x.Key == DataFormatter_HeaderKeys.FormatValueSettings.ToString())?.Value;
         if (!string.IsNullOrEmpty(valueLocal))
            _myIntervalDataRequest?.SetFormatValueSettingsHeader(valueLocal);
      }
      private void FetchCustoms()
      {
         var cHeaders = _myIntervalDataRequest?.GetCustomHeaders();
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
      }

      public async Task ExecuteMethod()
      {
         if (_myIntervalDataRequest == null)
            return;
         UpdateCustoms();
         (HasError, ErrorText, Response, Result) = await _myIntervalDataRequest.GetIntervalData(Input);
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
            if (Result is not IntervalDataResult cResult)
               return;
            _visualizedCollection ??= new();
            _visualizedCollection.Clear();
            if(cResult.TimeStampsCount != cResult.PVCount)
               return;
            for (int i = 0; i < cResult.TimeStampsCount; i++)
            {
               VisualizedCollection.Add(new VisualisationHelper()
               {
                  TimesStamp = cResult.TimeStamps[i],
                  IValue = cResult.Data[0].IDAT_IVAL[i]
               });
            }
         }
      }

      #endregion 
   }
}
