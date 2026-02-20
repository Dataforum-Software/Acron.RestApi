using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.DayData
{
   public interface IGetCompressionForIntervalOfDayDataRequestResource<T, U> where T : IGetDayDataPVDescription<U> where U : IDayWhat
   {
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15")]
      DateOnly FromDate { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-16")]
      DateOnly ToDate { get; set; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetDayDataPVDescription<IDayWhat>))]
      List<T> PVDescriptions { get; set; }

      [SwaggerSchema("Guid of formerly requested result")]
      [SwaggerExampleValue("d9262d90-5feb-4d55-b9b8-2b12093abd25")]
      Guid ResultID { get; set; }

      [SwaggerSchema($"If this property is true, the operation with the given {nameof(ResultID)} will be canceled")]
      [SwaggerExampleValue(false)]
      bool CancelOperation { get; set; }
   }
}
