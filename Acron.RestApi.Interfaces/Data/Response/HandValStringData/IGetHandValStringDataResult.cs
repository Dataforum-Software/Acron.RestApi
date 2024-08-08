using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.DayData;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData.GetHandVarRawDataCommentsResult;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.HandValStringData
{
   public interface IGetHandValStringDataResult<T> where T : IGetHandValStringDataResultItem
   {
      [SwaggerSchema("Result contains values")]
      [SwaggerExampleValue("true")]
      bool HasData { get; }

      [SwaggerSchema("Number of process variables in result")]
      [SwaggerExampleValue(15)]
      int PVCount { get; }

      [SwaggerSchema("Number of time stamps per process variable")]
      [SwaggerExampleValue(12)]
      int TimeStampsCount { get; set; }

      [SwaggerSchema("Start date")]
      [SwaggerExampleValue("2020-08-15")]
      DateOnly FromDate { get; set; }

      [SwaggerSchema("End date")]
      [SwaggerExampleValue("2020-08-16")]
      DateOnly ToDate { get; set; }

      [SwaggerSchema("Date time stamp for each value")]
      [SwaggerExampleValue(new string[]{ "1970-01-01T00:00:00Z", "1970-01-01T00:00:00Z", "1970-01-01T00:00:00Z"})]
      List<DateOnly> TimeStampDays { get; set; }

      [SwaggerSchema($"{nameof(TimeStampDays)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[]{ "01.01.1970 00:00:00", "01.01.1970 00:00:00", "01.01.1970 00:00:00"})]
      List<string> TimeStamps_FORMATTED { get; set; }

      [SwaggerSchema("")]
      [SwaggerExampleValue(typeof(IGetHandValStringDataResultItem))]
      List<T> CommentData { get; set; }
   }
}
