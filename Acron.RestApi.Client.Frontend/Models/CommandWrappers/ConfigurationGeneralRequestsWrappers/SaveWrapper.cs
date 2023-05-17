using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.DataContracts.Configuration.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Models
{
   class SaveWrapper : ConfigGeneralWrapper
   {
      #region ctor
      public SaveWrapper() : base()
      {
      }

      public SaveWrapper(ConfigurationGeneralRequests re) : base(re)
      {
         _myConfigurationRequest = re;
      }

      #endregion

      #region Properties
      public SaveRequestResource Input { get; set; }


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
               var jsonstring = JsonConvert.DeserializeObject<SaveRequestResource>(value);
               if (jsonstring is not null)
                  Input = jsonstring;
            }
            catch
            {
            }
         }
      }
      #endregion

      #region Methods
      public override async Task ExecuteMethod()
      {
         if (_myConfigurationRequest == null)
            return;
         (HasError, ErrorText, Response, Result) = await _myConfigurationRequest.Save(Input);
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
            Debug.WriteLine(Response.Message);
         }
      }
      #endregion
   }
}
