using Acron.RestApi.BaseObjects;
using Acron.RestApi.Client.Client.Defines;
using Acron.RestApi.Client.Client.Request.Base;
using Acron.RestApi.Client.Client.Request.ConfigurationRequests;
using Acron.RestApi.Client.Frontend.Models.CommandWrappers;
using Acron.RestApi.DataContracts.Response;
using Acron.RestApi.Interfaces.BaseObjects;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Acron.RestApi.Client.Frontend.Models
{
   internal class DefaultValuesWrapper : ConfigGeneralWrapper, IGenericMethodWrapper
   {
      #region ctor
      public DefaultValuesWrapper() : base()
      {
         _testType = typeof(object);
      }

      public DefaultValuesWrapper(ConfigurationGeneralRequests request) : base(request)
      {
         _myConfigurationRequest = request;
         _testType = typeof(RestApiBaseObject);
      }
      #endregion

      #region Properties

      private Type _testType;
      public Type TestType
      {
         get { return _testType; }
         set
         {
            SetProperty(ref _testType, value);
         }
      }
      #endregion
      #region Methods


      private async Task<(bool HasError, string ErrorText, ApiControllerResponseBase Response, dynamic Result)> SwitchDefaults()
      {
         if (_myConfigurationRequest == null || TestType == null)
            throw new InvalidOperationException("No Config");
         switch (TestType.Name)
         {
            case nameof(RestApiBaseObject):
               return await _myConfigurationRequest.DefaultValues<RestApiBaseObject>();
            case nameof(RestApiDefaultGroupObject):
               return await _myConfigurationRequest.DefaultValues<RestApiDefaultGroupObject>();
            case nameof(RestApiPlantObject):
               return await _myConfigurationRequest.DefaultValues<RestApiPlantObject>();
            case nameof(RestApiAlertGroupObject):
               return await _myConfigurationRequest.DefaultValues<RestApiAlertGroupObject>();
            case nameof(RestApiAlertObject):
               return await _myConfigurationRequest.DefaultValues<RestApiAlertObject>();
            case nameof(RestApiConnectionGroupObject):
               return await _myConfigurationRequest.DefaultValues<RestApiConnectionGroupObject>();
            case nameof(RestApiConnectionObject):
               return await _myConfigurationRequest.DefaultValues<RestApiConnectionObject>();
            case nameof(RestApiExtVarGroupObject):
               return await _myConfigurationRequest.DefaultValues<RestApiExtVarGroupObject>();
            case nameof(RestApiExtVarObject):
               return await _myConfigurationRequest.DefaultValues<RestApiExtVarObject>();
            case nameof(RestApiProviderDriverObject):
               return await _myConfigurationRequest.DefaultValues<RestApiProviderDriverObject>();
            case nameof(RestApiProviderObject):
               return await _myConfigurationRequest.DefaultValues<RestApiProviderObject>();
            case nameof(RestApiBaseUnitObject):
               return await _myConfigurationRequest.DefaultValues<RestApiBaseUnitObject>();
            case nameof(RestApiUnitObject):
               return await _myConfigurationRequest.DefaultValues<RestApiUnitObject>();
            case nameof(RestApiPvAutoObject):
               return await _myConfigurationRequest.DefaultValues<RestApiPvAutoObject>();
            case nameof(RestApiPvCalcObject):
               return await _myConfigurationRequest.DefaultValues<RestApiPvCalcObject>();
            case nameof(RestApiPvCalcReferenceObject):
               return await _myConfigurationRequest.DefaultValues<RestApiPvCalcReferenceObject>();
            case nameof(RestApiPvExternalObject):
               return await _myConfigurationRequest.DefaultValues<RestApiPvExternalObject>();
            case nameof(RestApiPvManualObject):
               return await _myConfigurationRequest.DefaultValues<RestApiPvManualObject>();
            case nameof(RestApiPvVarGroupObject):
               return await _myConfigurationRequest.DefaultValues<RestApiPvVarGroupObject>();
            default:
               throw new NotImplementedException();
         }
      }

      public override async Task ExecuteMethod()
      {
         if (_myConfigurationRequest == null)
            return;
         (HasError, ErrorText, Response, Result) = await SwitchDefaults();
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
