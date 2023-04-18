using Acron.RestApi.Client.Frontend.XamlConverters;
using Acron.RestApi.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines.ConfigDefines;

namespace Acron.RestApi.Client.Frontend.Models.CommandWrappers
{
   /// <summary>
   /// Implement this Interface for Command wrapping, Check GetIntervalDataWrapper for Implementation details
   /// </summary>
   internal interface IWrapper
   {
      #region Properties
      public string Name { get; init; }

      public string Url { get; init; }

      public Methods HttpMethod { get; }

      public string InputBodyText { get; set; }

      public ApiControllerResponseBase? Response { get; set; }

      public List<KeyValuePair<string, string>> Headers { get; }

      public ObservableCollection<DataItem>? CustomHeaders { get; set; }

      public string ErrorText { get; set; }

      public dynamic? Result { get; set; }

      public string ResponseBodyText { get; set; }

      public HttpStatusCode StatusCode { get; set; }

      public bool HasError { get; set; }

      public string StatusCodeString { get; }

      public ObservableCollection<VisualisationHelper>? VisualizedCollection { get; }

      public bool DateVisible { get; }

      public bool TimeVisible { get; }

      public ApiActionResult? ApiResponse { get; set; }

      #endregion

      public Task ExecuteMethod();
   }
}