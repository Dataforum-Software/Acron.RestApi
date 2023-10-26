using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.MachineLearning.SpikeDetection.ProcessData
{
   public interface IProcessDataSpikeDetectionRequestResource
   {
      [SwaggerSchema("Sensitivity of the model to value spikes.<br/>Lower values lead to smaller spikes being detected, but raise the chance for false positives.")]
      [SwaggerExampleValue(98.0)]
      double Confidence { get; set; }

      [SwaggerSchema("Size of the sliding window of process values the model takes into account at a time.<br/>Lower values lead to the model \"forgetting\" previous spikes faster.")]
      [SwaggerExampleValue(2)]
      int HistoryLength { get; set; }

      [SwaggerSchema("Only show results for process values that are suspected to be outliers.")]
      [SwaggerExampleValue(true)]
      bool ShowOnlyAnalysisResults { get; set; }
   }
}
