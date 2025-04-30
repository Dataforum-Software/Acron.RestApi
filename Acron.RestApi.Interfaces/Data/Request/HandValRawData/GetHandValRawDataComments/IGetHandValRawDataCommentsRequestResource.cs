using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawDataComments
{
   public interface IGetHandValRawDataCommentsRequestResource
   {
      [SwaggerSchema("Type of requested comment")]
      [SwaggerExampleValue(AVComKinds_HandVal.AVCOMMENT_PVDAY)]
      AVComKinds_HandVal Kind { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T00:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-16T00:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      [SwaggerSchema("List of process variable ids")]
      [SwaggerExampleValue("[302000001,302000005,302000013,302000015,302000016,302000029]")]
      IEnumerable<uint> PVIds { get; set; }
   }

   public enum AVComKinds_HandVal : short
   {
      [SwaggerEnumInfo("Daily comment for a process- or manual variable")]
      AVCOMMENT_PVDAY = 6,

      [SwaggerEnumInfo("Weekly value for a process variable of type text")]
      AVCOMMENT_PVWEEKVAL = 14,

      [SwaggerEnumInfo("Monthly value for a process variable of type text")]
      AVCOMMENT_PVMONVAL = 15,

      [SwaggerEnumInfo("Yearly value for a process variable of type text")]
      AVCOMMENT_PVYEARVAL = 16,
   }

}
