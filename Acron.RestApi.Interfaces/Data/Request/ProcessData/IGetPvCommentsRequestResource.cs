using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IGetPvCommentsRequestResource
   {
      [SwaggerSchema("Type of requested comment")]
      [SwaggerExampleValue(PvCommentsKind.PVYEAR)]
      PvCommentsKind Kind { get; set; }

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

   [SwaggerSchema("Comment type for a comment that is specific to a process variable.")]
   public enum PvCommentsKind : short
   {
      [SwaggerEnumInfo("Daily comment for a process- or manual variable")]
      PVDAY = AVComKinds.AVCOMMENT_PVDAY,

      [SwaggerEnumInfo("Weekly comment for process variable")]
      PVWEEK = AVComKinds.AVCOMMENT_PVWEEK,

      [SwaggerEnumInfo("Monthly comment for process variable")]
      PVMON = AVComKinds.AVCOMMENT_PVMON,

      [SwaggerEnumInfo("Yearly comment for process variable")]
      PVYEAR = AVComKinds.AVCOMMENT_PVYEARVAL,
   }
}
