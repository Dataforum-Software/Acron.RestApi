using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.IntervalData
{
   public interface IGetCompressionForIntervalOfCustomIntervalDataRequestResource<T, U> where T : IGetIntervalDataPVDescription<U> where U : IIntervalWhat
   {
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15")]
      DateTime FromTime { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-16")]
      DateTime ToTime { get; set; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IGetIntervalDataPVDescription<IIntervalWhat>))]
      List<T> PVDescriptions { get; set; }

      [SwaggerSchema("Interval data from weekly or monthly intervals")]
      [SwaggerExampleValue(CustomIntervalTypes.DBN_INT_VAR)]
      CustomIntervalTypes CustomIntervalType { get; set; }

      [SwaggerSchema($"Interval width in seconds. Has to be lower than the difference between {nameof(ToTime)} and {nameof(FromTime)}")]
      [SwaggerExampleValue(5000)]
      uint Interval { get; set; }

      [SwaggerSchema("Guid of formerly requested result")]
      [SwaggerExampleValue("d9262d90-5feb-4d55-b9b8-2b12093abd25")]
      Guid ResultID { get; set; }

      [SwaggerSchema($"If this property is true, the operation with the given {nameof(ResultID)} will be canceled")]
      [SwaggerExampleValue(false)]
      bool CancelOperation { get; set; }
   }

   public enum CustomIntervalTypes : short
   {
      [SwaggerEnumInfo("Interval length is determined by the value of Interval.")]
      DBN_INT_VAR = DBN_CompTypes.DBN_INT_VAR,    //Variable interval

      [SwaggerEnumInfo("Interval length is determined by the value of Interval.")]
      DBN_INT_VAR_DAY = DBN_CompTypes.DBN_INT_VAR_DAY,    //Variable interval day
   }
}

