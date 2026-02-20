using Acron.RestApi.Interfaces.Data.Request.DayData;
using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Acron.RestApi.Interfaces.Data.Request.ProcessData.IGetProcessDataPVDescription;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IGetProcessDataPVDescriptionForTemporaryCompression<T> where T : IDayWhat
   {
      [SwaggerSchema("Numeric ID of Process Variable")]
      [SwaggerExampleValue(302000003)]
      uint PVID { get; set; }

      [SwaggerSchema("Requested type of values")]
      [SwaggerExampleValue(DataValueTypes.Values)]
      DataValueTypes ValueTypes { get; set; }

      [SwaggerSchema("Requested processing of values")]
      [SwaggerExampleValue(DBP_ReadTypes.DBP_WITHOUT_NOVALID)]
      DBP_ReadTypes DBP_ReadType { get; set; }

      [SwaggerSchema("Set of flags to select which properties to include in result")]
      [SwaggerExampleValue(typeof(IDayWhat))]
      T DayWhat { get; set; }




   }
}
