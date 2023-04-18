using Acron.RestApi.DataContracts.Data.Request.HandValRawData.GetHandValRawData;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawData;
using Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawData;
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
   internal class WriteHandValRawDataWrapper: HandValWrapper
   {
      public WriteHandValRawDataWrapper(RestClient client) : base(client)
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
               var jsonstring = JsonConvert.DeserializeObject<WriteHandValRawDataRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }
      public WriteHandValRawDataRequestResource Input { get; set; }

      public async override Task ExecuteMethod()
      {
         if (_myHandValWrapper == null)
            return;
         UpdateCustoms();
         (HasError, ErrorText, Response, Result) = await _myHandValWrapper.WriteHandValRawData(Input);
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
