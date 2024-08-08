using Acron.RestApi.Interfaces.Data.Request.StringCompData;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.StringCompData
{
   public  interface IGetGeneralCommentResult
   {
      [SwaggerSchema("Date of the requested comment value")]
      [SwaggerExampleValue("2024-04-01")]
      DateOnly Date { get; set; }

      [SwaggerSchema($"{nameof(Date)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.04.2024")]
      string Date_FORMATTED { get; set; }

      [SwaggerSchema("Type of comment")]
      [SwaggerExampleValue("AVCOMMENT_WEEK")]
      AVComKinds_GeneralComment Kind { get; set; }

      [SwaggerSchema("Text value of comment")]
      [SwaggerExampleValue("this is a comment")]
      string Comment { get; set; }

      [SwaggerSchema("Date and time of last edit")]
      [SwaggerExampleValue("2024-04-24T10:39:03")]
      DateTime EditDateTime { get; set; }

      [SwaggerSchema($"{nameof(EditDateTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("24.04.2024 12:39:03")]
      string EditDateTime_FORMATTED { get; set; }

      [SwaggerSchema("User name of comment creator")]
      [SwaggerExampleValue("AcronUser1")]
      string User {  get; set; }
   }
}
