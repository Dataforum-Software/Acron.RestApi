using Acron.RestApi.DataContracts.Configuration.Request;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using Acron.RestApi.Interfaces.DataFormatter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers.ConfigurationAlertRequestWrappers
{
   internal class GetAllWrapper : ConfigAlertWrapper
   {
      public GetAllWrapper(RestClient client) : base(client)
      {
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
               var jsonstring = JsonConvert.DeserializeObject<GetAllAlertsRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }
      public GetAllAlertsRequestResource Input { get; set; }

      public override async Task ExecuteMethod()
      {
         if (_myConfigurationRequest == null)
            return;
         (HasError, ErrorText, Response, Result) = await _myConfigurationRequest.GetAll(Input);
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
         }
      }
   }
}
