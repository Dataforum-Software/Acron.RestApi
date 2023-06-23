using Acron.RestApi.BaseObjects;
using Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers.ConfigurationProcessConnectionWrappers
{
   internal class UpdateExtVarWrapper : ConfigProcessConnectionWrapper
   {
      public UpdateExtVarWrapper(RestClient client) : base(client)
      {
         Input = null;
         _targetID = -1;
      }

      public override int? TargetID
      {
         get { return _targetID; }
         set
         {
            SetProperty(ref _targetID, value);
         }
      }

      public override string? InputBodyText
      {
         get
         {
            if (Input == null)
            {
               return null;
            }
            return JsonConvert.SerializeObject(Input, Formatting.Indented, ExcludeObsoletePropertiesResolver.NoObsolete);
         }
         set
         {
            try
            {
               var jsonstring = JsonConvert.DeserializeObject<List<UpdateExtVarObjectRequestResource>>(value);
               if (jsonstring is not null)
               {
                  Input = jsonstring;
               }
               OnPropertyChanged(nameof(Input));
               OnPropertyChanged(nameof(InputBodyText));
            }
            catch
            {
            }
         }
      }
      public List<UpdateExtVarObjectRequestResource>? Input { get; set; }



      public override async Task ExecuteMethod()
      {
         if (_myConfigurationRequest == null)
            return;
         (HasError, ErrorText, Response, Result) = await _myConfigurationRequest.UpdateExtVar(Input);
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
