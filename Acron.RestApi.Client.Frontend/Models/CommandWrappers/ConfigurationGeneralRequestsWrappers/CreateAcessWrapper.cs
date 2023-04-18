using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.Client.Frontend.XamlConverters;
using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.DataContracts.Response;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Models
{
    internal class CreateAccessWrapper:ConfigGeneralWrapper
   {
      #region ctor
      public CreateAccessWrapper():base()
      {
      }

      public CreateAccessWrapper(ConfigurationGeneralRequests re):base(re)
      {
         _myConfigurationRequest= re;
      }
      #endregion

      #region Methods
      public override async Task ExecuteMethod()
      {
         if(_myConfigurationRequest == null)
            return;
         (HasError, ErrorText, Response, Result) = await _myConfigurationRequest.CreateAccess();
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
