using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.StringCompData
{
   public interface IGetGeneralCommentRequestResource
   {
      [SwaggerSchema("Type of comment")]
      [SwaggerExampleValue("AVCOMMENT_WEEK")]
      AVComKinds_GeneralComment Kind { get; set; }

      [SwaggerSchema("Date of the requested comment value")]
      [SwaggerExampleValue("2024-04-01")]
      DateOnly Date {  get; set; }
   }

   public enum AVComKinds_GeneralComment : short
   {
      [SwaggerEnumInfo("Daily general comment")]
      AVCOMMENT_DAY = 1,

      [SwaggerEnumInfo("Weekly general comment")]
      AVCOMMENT_WEEK = 2,

      [SwaggerEnumInfo("Monthly general comment")]
      AVCOMMENT_MON = 3,

      [SwaggerEnumInfo("Yearly general comment")]
      AVCOMMENT_YEAR = 5,
   }
}
