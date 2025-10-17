using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.MachineLearning.SpikeDetection.ProcessData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.MachineLearning.SpikeDetection.ProcessData
{
   [DataContract]
   public class ProcessDataSpikeDetectionResult : IProcessDataSpikeDetectionResult
   {
      [DataMember]
      /// <summary>
      /// ObjectID. Müssen wir noch in den 'neue Welt'-Nummernkreis heben. Daher public set
      /// </summary>
      public uint PVID { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      [FormatDateTime(nameof(TimeStamp_FORMATTED))]
      public DateTime TimeStamp_UTC { get; set; }

      [DataMember]
      public string TimeStamp_FORMATTED { get; set; }

      [DataMember]
      [DefaultValue(null)]
      [FormatDoubleMarker(nameof(Value_FORMATTED), ValueFormatType.Process)]
      public double Value { get; set; }

      [DataMember]
      [DefaultValue(null)]
      public string Value_FORMATTED { get; set; }

      [DataMember]
      [DefaultValue(null)]
      public bool Alert { get; set; }

      [DataMember]
      [DefaultValue(null)]
      public double Quality { get; set; }
   }
}
