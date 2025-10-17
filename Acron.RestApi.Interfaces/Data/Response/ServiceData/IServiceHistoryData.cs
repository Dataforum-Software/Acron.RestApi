using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
    public interface IServiceHistoryData<U> where U : IRepairData
   {
      [SwaggerSchema("Id of the corresponding aggregate")]
      [SwaggerExampleValue(423)]
      uint AggregateID { get; set; }

      [SwaggerSchema("Average duration of all objects of this aggregate")]
      [SwaggerExampleValue(423)]
      uint AverageDuration { get; set; }


      [SwaggerSchema("Sum of the duration of all objects of this aggregate")]
      [SwaggerExampleValue(423)]
      uint DurationSum { get; set; }

      [SwaggerSchema("Average cost of all objects of this aggregate")]
      [SwaggerExampleValue(7.4)]
      double AverageCost { get; set; }

      [SwaggerSchema($"{nameof(AverageCost)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("7,6")]
      string AverageCost_FORMATTED { get; set; }

      [SwaggerSchema("Sum of the cost of all objects")]
      [SwaggerExampleValue(645.2)]
      double CostSum { get; set; }

      [SwaggerSchema($"{nameof(CostSum)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("645,2")]
      string CostSum_FORMATTED { get; set; }

      [SwaggerSchema("List of all related repair data objects")]
      [SwaggerExampleValue(typeof(IRepairData))]
      List<U> Values { get; set; }
   }
}
