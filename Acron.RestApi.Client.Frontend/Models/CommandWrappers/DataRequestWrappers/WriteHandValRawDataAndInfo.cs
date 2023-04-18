using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments;
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

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   internal class WriteHandValRawDataAndInfo : HandValWrapper
   {
      public WriteHandValRawDataAndInfo(RestClient client) : base(client)
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
               var jsonstring = JsonConvert.DeserializeObject<WriteHandValRawDataAndInfosRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }
      public WriteHandValRawDataAndInfosRequestResource Input { get; set; }

      public override async Task ExecuteMethod()
      {
         if (_myHandValWrapper == null)
            return;
         UpdateCustoms();
         (HasError, ErrorText, Response, Result) = await _myHandValWrapper.WriteHandValRawDataAndInfo(Input);
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
