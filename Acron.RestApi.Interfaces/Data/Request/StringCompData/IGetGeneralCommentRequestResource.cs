using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
      [SwaggerExampleValue(GeneralCommentKind.MON)]
      GeneralCommentKind Kind { get; set; }

      [SwaggerSchema("Date of the requested comment value")]
      [SwaggerExampleValue("2024-04-01")]
      DateOnly Date { get; set; }
   }

   [SwaggerSchema("Comment types for general comments specific to a timeframe")]
   public enum GeneralCommentKind : short
   {
      [SwaggerEnumInfo("Daily general comment")]
      DAY = AVComKinds.AVCOMMENT_DAY,

      [SwaggerEnumInfo("Weekly general comment")]
      WEEK =  AVComKinds.AVCOMMENT_WEEK,

      [SwaggerEnumInfo("Monthly general comment")]
      MON = AVComKinds.AVCOMMENT_MON,

      [SwaggerEnumInfo("Yearly general comment")]
      YEAR = AVComKinds.AVCOMMENT_YEAR,
   }
}
