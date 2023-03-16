using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.DataContracts.Configuration.Response;
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
    internal class ReleaseAccessWrapper : ConfigWrapper
   {
      #region ctor
      public ReleaseAccessWrapper() : base() { }

      public ReleaseAccessWrapper(ConfigurationGeneralRequests request) : base(request)
      {
         _myConfigurationRequest = request;
      }
      #endregion

      #region Methods

      public override async Task ExecuteMethod()
      {
         if (_myConfigurationRequest == null)
            return;
         (bool HasError, ErrorText, Response, Result) = await _myConfigurationRequest.ReleaseAccess();
         if (HasError && Response is null)
         {
            Debug.WriteLine(ErrorText);
            MessageBox.Show(ErrorText,"Error");
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
