using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.DataRequests;
using Acron.RestApi.Client.Frontend.XamlConverters;
using Acron.RestApi.DataContracts.Data.Request.IntervalData;
using Acron.RestApi.DataContracts.Data.Request.ProcessData;
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
   internal class GetProcessDataWrapper : ObservableObject, IWrapper, IOnlineGraphCapable
   {
      #region Ctor
      public GetProcessDataWrapper(RestClient? client = null)
      {
         _myProcessDataRequest = new ProcessDataRequests(client);
         Name = string.Empty;
         _responseBodyText = string.Empty;
         ErrorText = string.Empty;
         Url = string.Empty;
         Input = new();
         LastExecution = DateTime.Now - TimeSpan.FromMinutes(10);
         if (_myProcessDataRequest is null)
            return;
         string helper = GetType().Name.Replace("Wrapper", "");
         FieldInfo routeKey = (typeof(RouteDefines.RouteKeys).GetFields().First(x => x.Name == helper));
         Url = _myProcessDataRequest.BaseAddress + RouteDefines.Instance.Routes[(RouteDefines.RouteKeys)routeKey!.GetValue(true)!];
         _visualizedCollection = new();
         for (int i = 0; i < MaxLengthPlot; i++)
            _visualizedCollection.Add(new VisualisationHelper()
            {
               IValue = 0,
               TimesStamp = DateTime.UtcNow - TimeSpan.FromSeconds((MaxLengthPlot * 5) + (i * 5))
            }) ;
      }

      #endregion

      #region Field
      private int MaxLengthPlot = 50;

      private ProcessDataRequests? _myProcessDataRequest;

      #endregion

      #region Properties
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
               var jsonstring = JsonConvert.DeserializeObject<GetProcessDataRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }

      public GetProcessDataRequestResource Input { get; set; }

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
            if (_myProcessDataRequest is null)
               return new();
            return new()
            {
               new("Accept", "application/json"),
               new("Authorization", "Bearer "+ _myProcessDataRequest.AccessToken),
               new("Acron", _myProcessDataRequest.UserToken)
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

      #region Method
      public async Task ExecuteMethod()
      {
         if (_myProcessDataRequest == null)
            return;
         (bool HasError, ErrorText, Response, Result) = await _myProcessDataRequest.GetProcessData(Input);
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
            if (Result is not List<ProcessDataBase> cResult)
               return;
            _visualizedCollection ??= new();
            for (int i = 0; i < cResult[0].ValuesElementCount; i++)
            {
               if (VisualizedCollection!.Count >= MaxLengthPlot)
                  VisualizedCollection.RemoveAt(0);
               VisualisationHelper vh = new()
               {
               };
               if (Input.PVIDs[0].ValueTypes.HasFlag(Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Values))
               {

                  vh.IValue = cResult[0].Values[i].Value;
                  vh.TimesStamp = cResult[0].Values[i].TimeStamp;
               }
               if (Input.PVIDs[0].ValueTypes.HasFlag(Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Maxima) && cResult[0].MaximaElementCount != 0)
               {
                  vh.MaxValue = cResult[0].Maxima[i].Value;
                  vh.TimesStamp = cResult[0].Maxima[i].TimeStamp;
               }
               if (Input.PVIDs[0].ValueTypes.HasFlag(Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Minima) && cResult[0].MinimaElementCount != 0)
               {
                  vh.MaxValue = cResult[0].Minima[i].Value;
                  vh.TimesStamp = cResult[0].Minima[i].TimeStamp;
               }
               VisualizedCollection.Add(vh);
            }
         }
      }

      public async Task ExecuteOnline()
      {
         if (_myProcessDataRequest == null)
            return;
         (bool HasError, ErrorText, Response, Result) = await _myProcessDataRequest.GetProcessData(Input);
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
            if (Result is not List<ProcessDataBase> cResult || cResult[0].Values == null)
               return;
            _visualizedCollection ??= new();
            for(int i=0;i< cResult[0].ValuesElementCount;i++)
            {
               if (cResult[0].Values[0].TimeStamp  <= VisualizedCollection![^1]._timeStamp)
                  continue;
               if (VisualizedCollection.Count >= MaxLengthPlot)
                  VisualizedCollection.RemoveAt(0);
               VisualisationHelper vh = new()
               {
               };
               if (Input.PVIDs[0].ValueTypes.HasFlag(Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Values))
               {

                  vh.IValue = cResult[0].Values[i].Value;
                  vh.TimesStamp = cResult[0].Values[i].TimeStamp;
               }
               if (Input.PVIDs[0].ValueTypes.HasFlag(Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Maxima) && cResult[0].MaximaElementCount!=0)
               {
                  vh.MaxValue = cResult[0].Maxima[i].Value;
                  vh.TimesStamp = cResult[0].Maxima[i].TimeStamp;
               }
               if (Input.PVIDs[0].ValueTypes.HasFlag(Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription.DataValueTypes.Minima) && cResult[0].MinimaElementCount!=0)
               {
                  vh.MaxValue = cResult[0].Minima[i].Value;
                  vh.TimesStamp = cResult[0].Minima[i].TimeStamp;
               }
               VisualizedCollection.Add(vh);
            }
         }

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
         Input.FromTime = new DateTimeOffset(LastExecution - TimeSpan.FromSeconds(5),TimeSpan.FromHours(1));
         OnPropertyChanged(nameof(Input));
         OnPropertyChanged(nameof(InputBodyText));
         LastExecution = Input.ToTime.DateTime;
      }
      #endregion
   }
}
