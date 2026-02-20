using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData.GetHandValRawDataCommentsResult
{
   public interface IHandValRawDataComment
   {
      [SwaggerSchema("IDs of the process variables of which comment data is requsted")]
      [SwaggerExampleValue("[302000005, 302000007, 302000012]")]
      uint PVId { get; set; }

      [SwaggerSchema("List of time stamps")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\"]")]
      List<DateTime> TimeValues { get; set; }

      [SwaggerSchema($"{nameof(TimeValues)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\"]")]
      List<string> TimeValues_FORMATTED { get; set; }

      [SwaggerSchema("List of comment types")]
      [SwaggerExampleValue("[\"CDAT_REMVG\",\"CDAT_REMRT\",\"CDAT_REMSS\"]")]
      List<CDAT_Kind> KindValues { get; set; }

      [SwaggerSchema("List of comment texts")]
      [SwaggerExampleValue("[\"Comment text1\",\"Comment text2\",\"CommentText\"]")]
      List<string> CommentValues { get; set; }

      [SwaggerSchema("List with edit timestamps")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\"]")]
      List<DateTime> TimeEditValues { get; set; }

      [SwaggerSchema($"{nameof(TimeEditValues)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\"]")]
      List<string> TimeEditValues_FORMATTED { get; set; }

      [SwaggerSchema("List of user names of the editor of every comment")]
      [SwaggerExampleValue("[\"Klaus\",\"Uwe\",\"Horst\"]")]
      List<string> UserValues { get; set; }
   }
}
