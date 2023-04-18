using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.DataContracts.Response;
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines.ConfigDefines;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal abstract class ConfigAlertWrapper : ObservableObject, IWrapper
   {
      #region ctor
      public ConfigAlertWrapper(RestClient client)
      {
         _myConfigurationRequest = new ConfigurationAlertRequests(client);
         Name = string.Empty;
         _responseBodyText = string.Empty;
         _errorText = string.Empty;
         Url = string.Empty;
         if (_myConfigurationRequest is null)
            return;
         string helper = "Alert_" + GetType().Name.Replace("Wrapper", "");
         
         FieldInfo routeKey = (typeof(RouteDefines.RouteKeys).GetFields().First(x => x.Name == helper));
         Url = _myConfigurationRequest.BaseAddress + RouteDefines.Instance.Routes[(RouteDefines.RouteKeys)routeKey.GetValue(true)!];
         Method = _myConfigurationRequest.GetType().GetMethod(helper);
      }
      #endregion

      #region Fields

      protected ConfigurationAlertRequests? _myConfigurationRequest;

      #endregion

      #region Properties
      public string Url { get; init; }
      public string Name { get; init; }

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


      public MethodInfo? Method { get; private set; }

      public Methods HttpMethod
      {
         get
         {
            if (GetType().GetProperties().Any(x => x.Name == "Input" || x.Name == "TestType"))
               return Methods.POST;

            return Methods.GET;
         }
         set
         {

         }
      }



      public virtual string InputBodyText
      {
         get { return string.Empty; }
         set { }
      }


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
            if (_myConfigurationRequest is null)
               return new();
            return new()
            {
               new("Accept", "application/json"),
               new("Authorization", "Bearer "+ _myConfigurationRequest.AccessToken),
               new("Acron", _myConfigurationRequest.UserToken)
            };
         }
      }

      public virtual ObservableCollection<DataItem>? CustomHeaders { get; set; } = null;

      private string _errorText;
      public string ErrorText
      {
         get { return _errorText; }
         set
         {
            SetProperty(ref _errorText, value);
         }
      }


      public dynamic? Result { get; set; }


      private string _responseBodyText;
      public string ResponseBodyText
      {
         get { return _responseBodyText; }
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

      public ObservableCollection<VisualisationHelper>? VisualizedCollection
      {
         get
         {
            return null;
         }
      }
      #endregion

      #region Method
      public abstract Task ExecuteMethod();
      protected void ReadOutResponse()
      {
         if (Response == null)
            return;

         ResponseBodyText = JsonConvert.SerializeObject(Response, Formatting.Indented);
      }

      #endregion


   }
}
