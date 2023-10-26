using Acron.RestApi.DataContracts.Data.Request.ProcessData;
using Acron.RestApi.Interfaces.Data.Request.MachineLearning.SpikeDetection.ProcessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.MachineLearning.SpikeDetection.ProcessData
{
   [DataContract]
   public class ProcessDataSpikeDetectionRequestResource : GetProcessDataRequestResource, IProcessDataSpikeDetectionRequestResource
   {
      [DataMember]
      public bool ShowOnlyAnalysisResults { get; set; } = true;

      [DataMember]
      public double Confidence { get; set; } = 98.0;

      [DataMember]
      public int HistoryLength { get; set; } = -1;
   }
}
