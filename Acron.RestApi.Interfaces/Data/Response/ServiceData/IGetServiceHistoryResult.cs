using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
    public interface IGetServiceHistoryResult <T, U> where T : IServiceHistoryData<U> where U : IRepairData
   {
      [SwaggerSchema("Average duration of all objects")]
      [SwaggerExampleValue(423)]
      uint AverageDuration { get; set; }

      [SwaggerSchema("Sum of the duration of all objects")]
      [SwaggerExampleValue(423)]
      uint DurationSum { get; set; }

      [SwaggerSchema("Average cost of all objects")]
      [SwaggerExampleValue(7.6)]
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

      [SwaggerSchema("List of service history data objects")]
      [SwaggerExampleValue(typeof(List<IRepairData>))]
      List<T> Values { get; set; }
   }
}
