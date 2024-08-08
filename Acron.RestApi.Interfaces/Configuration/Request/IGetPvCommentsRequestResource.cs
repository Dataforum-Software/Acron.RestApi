using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IGetPvCommentsRequestResource
   {
      [SwaggerSchema("Type of requested comment")]
      [SwaggerExampleValue(AVComKinds_Pv.AVCOMMENT_PVYEAR)]
      AVComKinds_Pv Kind { get; set; }

      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T00:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-16T00:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      [SwaggerSchema("List of process variable ids")]
      [SwaggerExampleValue("[302000001,302000005,302000013,302000015,302000016,302000029]")]
      IEnumerable<uint> PVIDs { get; set; }
   }

   public enum AVComKinds_Pv : short
   {
      [SwaggerEnumInfo("Daily comment for a process- or manual variable")]
      AVCOMMENT_PVDAY = 6,    // daily-comment for a PV (also PV-handvalues)

      [SwaggerEnumInfo("Weekly comment for process variable")]
      AVCOMMENT_PVWEEK = 7,    // weekly-comment for a PV

      [SwaggerEnumInfo("Monthly comment for process variable")]
      AVCOMMENT_PVMON = 8,    // monthly-comment for a PV

      [SwaggerEnumInfo("Yearly comment for process variable")]
      AVCOMMENT_PVYEAR = 9,    // yearly-comment for a PV
   }
}
