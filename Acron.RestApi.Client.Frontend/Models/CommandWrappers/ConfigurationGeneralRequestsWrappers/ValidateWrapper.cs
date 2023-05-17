using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Models
{ 
    class ValidateWrapper : ConfigGeneralWrapper
   {
      #region ctor
      public ValidateWrapper() : base()
      {
      }

      public ValidateWrapper(ConfigurationGeneralRequests re) : base(re)
      {
         _myConfigurationRequest = re;
      }

      #endregion

      #region Methods
      public override async Task ExecuteMethod()
      {
         if (_myConfigurationRequest == null)
            return;
         (HasError, ErrorText, Response, Result) = await _myConfigurationRequest.Validate();
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
