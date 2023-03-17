﻿using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.DataRequests;
using Acron.RestApi.Client.Frontend.XamlConverters;
using Acron.RestApi.DataContracts.Data.Request.DayData;
using Acron.RestApi.DataContracts.Data.Request.IntervalData;
using Acron.RestApi.DataContracts.Data.Request.ProcessData;
using Acron.RestApi.DataContracts.Data.Response.DayData;
using Acron.RestApi.DataContracts.Data.Response.IntervalData;
using Acron.RestApi.DataContracts.Data.Response.ProcessData;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines.ConfigDefines;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal class GetDayDataWrapper : ObservableObject, IOnlineGraphCapable
   {
      #region ctor
      public GetDayDataWrapper(RestClient? client = null)
      {
         _myDayDataRequest = new DayDataRequests(client);
         Name = string.Empty;
         _responseBodyText = string.Empty;
         ErrorText = string.Empty;
         Url = string.Empty;
         Input = new();
         if (_myDayDataRequest is null)
            return;
         string helper = GetType().Name.Replace("Wrapper", "");
         FieldInfo routeKey = (typeof(RouteDefines.RouteKeys).GetFields().First(x => x.Name == helper));
         Url = _myDayDataRequest.BaseAddress + RouteDefines.Instance.Routes[(RouteDefines.RouteKeys)routeKey.GetValue(true)!];
      }

      #endregion

      #region Fields
      private DayDataRequests? _myDayDataRequest;
      #endregion

      #region Properties

      private int _maxLength = 50;
      public int MaxLength
      {
         get { return _maxLength; }
         set
         {
            if (value == 0)
               SetProperty(ref _maxLength, 1);
            else
               SetProperty(ref _maxLength, value);
         }
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

      private ObservableCollection<VisualisationHelper>? _visualizedCollection;
      public ObservableCollection<VisualisationHelper>? VisualizedCollection
      {
         get { return _visualizedCollection; }
         set
         {
            SetProperty(ref _visualizedCollection, value);
         }
      }
      public string Name
      {
         get;init;
      }

      public string Url
      {
         get; init;
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
               var jsonstring = JsonConvert.DeserializeObject<GetDayDataRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }

      public GetDayDataRequestResource Input { get; set; }

      private ApiControllerResponseBase? _response;
      public ApiControllerResponseBase? Response
      {
         get { return _response; }
         set
         {
            SetProperty(ref _response, value);
         }
      }


      public virtual List<KeyValuePair<string, string>> Headers
      {
         get
         {
            if (_myDayDataRequest is null)
               return new();
            return new()
            {
               new("Accept", "application/json"),
               new("Authorization", "Bearer "+ _myDayDataRequest.AccessToken),
               new("Acron", _myDayDataRequest.UserToken)
            };
         }
      }

      public string ErrorText
      {
         get; set;
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

      public bool HasError
      {
         get; set;
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
      public DateTime LastExecution
      {
         get;
         private set;
      }

      #endregion

      #region Methods

      public async Task ExecuteMethod()
      {
         if (_myDayDataRequest == null)
            return;
         (bool HasError, ErrorText, Response, Result) = await  _myDayDataRequest.GetDayData(Input);
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
            if (Result is not DayDataResult cResult)
               return;
            VisualizedCollection ??= new();
            VisualizedCollection.Clear();
            for (int i=0;i<cResult.TimeStampsCount;i++)
            {
               VisualizedCollection.Add(new()
               {
                  TimesStamp = cResult.TimeStamps[i],
                  IValue = cResult.Data[0].DDAT_DVAL[i],
                  MaxValue = cResult.Data[0].DDAT_IMAX[i],
                  MinValue = cResult.Data[0].DDAT_IMIN[i]
               });
            }
            OnPropertyChanged(nameof(TimeVisible));
            OnPropertyChanged(nameof(DateVisible));
         }
      }

      public async Task ExecuteOnline()
      {
         if (_myDayDataRequest == null)
            return;
         (bool HasError, ErrorText, Response, Result) = await _myDayDataRequest.GetDayData(Input);
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
            if (Result is not DayDataResult cResult)
               return;
            if(VisualizedCollection is null)
            {
               VisualizedCollection = new();
               for(int i=0;i<MaxLength;i++)
               {
                  VisualizedCollection.Add(new() { TimesStamp = new DateTime((Input.FromTime - (TimeSpan.FromDays(MaxLength+1) -TimeSpan.FromDays(i))).Date.Ticks + TimeSpan.FromHours(23).Ticks)});
               };
            }
            for (int i = 0; i < cResult.TimeStampsCount; i++)
            {
               if (cResult.TimeStamps[i] <= VisualizedCollection![^1]._timeStamp)
                  continue;
               if (VisualizedCollection.Count >= MaxLength)
                  VisualizedCollection.RemoveAt(0);
               VisualizedCollection.Add(new()
               {
                  TimesStamp = cResult.TimeStamps[i],
                  IValue = cResult.Data[0].DDAT_DVAL[i],
                  MaxValue = cResult.Data[0].DDAT_IMAX[i],
                  MinValue = cResult.Data[0].DDAT_IMIN[i]
               }); ;
            }

         }
         OnPropertyChanged(nameof(TimeVisible));
         OnPropertyChanged(nameof(DateVisible));

      }

      protected void ReadOutResponse()
      {
         if (Response == null)
            return;

         ResponseBodyText = JsonConvert.SerializeObject(Response, Formatting.Indented);


         if (Response is AcBadRequestResponse acBadRequest)
         {
            ErrorText = acBadRequest.ErrorText;
         }
      }


      public void UpdateLastExecution()
      {
         Input.ToTime = new DateTimeOffset(DateTime.Now, TimeSpan.FromHours(1));
         if (LastExecution == new DateTime())
            Input.FromTime = Input.FromTime;
         else
            Input.FromTime = new DateTimeOffset(LastExecution- TimeSpan.FromSeconds(5),TimeSpan.FromHours(1));
         OnPropertyChanged(nameof(Input));
         OnPropertyChanged(nameof(InputBodyText));
         LastExecution = Input.ToTime.DateTime;
      }
      #endregion
   }
}
