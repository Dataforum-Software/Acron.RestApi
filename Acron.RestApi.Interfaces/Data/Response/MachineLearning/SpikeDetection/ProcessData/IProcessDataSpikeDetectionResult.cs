using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.MachineLearning.SpikeDetection.ProcessData
{
   public interface IProcessDataSpikeDetectionResult
   {
      [SwaggerSchema("Numeric ID of the process variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("a1")]
      public string ShortName { get; set; }

      [SwaggerSchema("Time stamp of this process value")]
      [SwaggerExampleValue("2020-08-15T12:00:00Z")]
      DateTime TimeStamp_UTC { get; }

      [SwaggerSchema($"{nameof(TimeStamp_UTC)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("15.08.2020 12:00:00")]
      string TimeStamp_FORMATTED { get; }

      [SwaggerSchema("Value of process variable")]
      [SwaggerExampleValue(2432.5)]
      double Value { get; }

      [SwaggerSchema($"{nameof(Value)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2.432,5")]
      string Value_FORMATTED { get; }

      [SwaggerSchema($"Current process value is suspected to be a spike")]
      [SwaggerExampleValue("2.432,5")]
      bool Alert { get; }

      [SwaggerSchema($"Probability value, the closer this value is to zero, the more likely this process value is a spike")]
      [SwaggerExampleValue(0.01)]
      double Quality { get; }

   }
}
