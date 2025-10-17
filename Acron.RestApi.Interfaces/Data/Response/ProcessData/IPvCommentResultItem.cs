using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawDataComments;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface IPvCommentResultItem
   {
      [SwaggerSchema("Id of a process variable")]
      [SwaggerExampleValue(302000001)]
      uint PVId { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("a1")]
      public string ShortName { get; set; }

      [SwaggerSchema("List of timestamps at which the comments where created")]
      [SwaggerExampleValue(new string[] { "2020-08-16T00:00:00Z", "2020-08-19T00:00:00Z", "2020-1-24T00:00:00Z" })]
      List<DateTime> TimeValues { get; set; }

      [SwaggerSchema($"{nameof(TimeValues)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "01.01.1970 00:00:00", "01.01.1970 00:00:00", "01.01.1970 00:00:00" })]
      List<string> TimeValues_FORMATTED { get; set; }

      [SwaggerSchema("List of comment types")]
      [SwaggerExampleValue(new CDAT_Kind[] { CDAT_Kind.CDAT_REMSS, CDAT_Kind.CDAT_REMRT, CDAT_Kind.CDAT_REMTM })]
      List<CDAT_Kind> KindValues { get; set; }

      [SwaggerSchema("List of comment string values")]
      [SwaggerExampleValue(new string[] { "comment1", "comment2", "comment3" })]
      List<string> CommentValues { get; set; }

      [SwaggerSchema("List of timestamps at which the comments where edited")]
      [SwaggerExampleValue(new string[] { "2020-08-16T00:00:00Z", "2020-08-19T00:00:00Z", "2020-1-24T00:00:00Z" })]
      List<DateTime> TimeEditValues { get; set; }

      [SwaggerSchema($"{nameof(TimeEditValues)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "01.01.1970 00:00:00", "01.01.1970 00:00:00", "01.01.1970 00:00:00" })]
      List<string> TimeEditValues_FORMATTED { get; set; }

      [SwaggerSchema("List of user which edited or created the corresponding comment")]
      [SwaggerExampleValue(new string[] { "Heinz", "Günther", "Uwe" })]
      List<string> UserValues { get; set; }




   }
}
