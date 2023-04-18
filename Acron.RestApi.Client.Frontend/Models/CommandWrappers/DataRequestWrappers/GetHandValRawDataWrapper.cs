using Acron.RestApi.DataContracts.Data.Request.HandValRawData.GetHandValRawData;
using Acron.RestApi.DataContracts.Data.Request.MonthWeekData;
using Acron.RestApi.DataContracts.Data.Request.YearData;
using Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData;
using Acron.RestApi.DataContracts.Data.Response.MonthWeekData;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.DataFormatter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal class GetHandValRawDataWrapper : HandValWrapper
   {
      public GetHandValRawDataWrapper(RestClient client) : base(client)
      {
         _visualizedCollection = new();
         Input = new();
      }
      public override string InputBodyText
      {
         get
         {
            return JsonConvert.SerializeObject(Input, Formatting.Indented);
         }
         set
         {
            try
            {
               var jsonstring = JsonConvert.DeserializeObject<GetHandValRawDataRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }
      public GetHandValRawDataRequestResource Input { get; set; }

      public override async Task ExecuteMethod()
      {
         if (_myHandValWrapper == null)
            return;
         UpdateCustoms();
         (HasError, ErrorText, Response, Result) = await _myHandValWrapper.GetHandValRawData(Input);
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
            if (Result is not GetHandValRawDataResult cResult)
               return;
            _visualizedCollection ??= new();
            _visualizedCollection.Clear();
            if (cResult.HasData)
            {
               for (int i = 0; i < cResult.PVList[0].DaysCount; i++)
               {
                  GetHandValRawDataDayValue help = cResult.PVList[0].DayList[i];
                  foreach(GetHandValRawDataValue? c in help.Data)
                  {
                     VisualisationHelper vh = c.ProvalType switch
                     {
                        HandValRawDataProvalTypes.Numeric => new VisualisationHelper() { IValue = c.NumValue, TimesStamp = c.TimeStamp.DateTime },
                        HandValRawDataProvalTypes.Text => new VisualisationHelper() { TextValue = c.AlphaNumericValue, TimesStamp = c.TimeStamp.DateTime},
                        _ => throw new NotImplementedException(),
                     } ;
                     _visualizedCollection.Add(vh);
                  }
               }
            }
            OnPropertyChanged(nameof(TimeVisible));
            OnPropertyChanged(nameof(DateVisible));
         }
      }
   }
}
