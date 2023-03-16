using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
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
    internal class ObjectInfoWrapper : ConfigWrapper
   {
      #region ctor
      public ObjectInfoWrapper() : base()
      {
         Input = new ObjectInfoRequestResource();
      }

      public ObjectInfoWrapper(ConfigurationGeneralRequests request) : base(request)
      {
         _myConfigurationRequest = request;
         Input = new ObjectInfoRequestResource();
      }

      #endregion

      #region Properties

      public override List<KeyValuePair<string,string>> Headers
      {
         get
         {
            var list = base.Headers;
            list.Add(new("Content-Type", "application/json"));
            return list;
         }
      }
      public ObjectInfoRequestResource Input { get; set; }


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
               var jsonstring = JsonConvert.DeserializeObject<ObjectInfoRequestResource>(value);
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
         (bool HasError, ErrorText, Response, Result) = await _myConfigurationRequest.ObjectInfo(Input);
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

      #endregion
   }
}
