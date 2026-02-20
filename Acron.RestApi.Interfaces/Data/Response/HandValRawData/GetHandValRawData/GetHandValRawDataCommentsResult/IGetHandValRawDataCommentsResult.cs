using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData.GetHandValRawDataCommentsResult;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData.GetHandVarRawDataCommentsResult
{
   public interface IGetHandValRawDataCommentsResult<T> where T : IHandValRawDataComment
   {
      [SwaggerSchema("Compression type of data")]
      [SwaggerExampleValue("DAT_COMMENT")]
      CompTypes Kind { get; set; }

      [SwaggerSchema("Begin of time interval")]
      [SwaggerExampleValue("2024-03-31T22:00:00Z")]
      DateTime FromTime { get; set; }

      [SwaggerSchema($"{nameof(FromTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("01.04.2024")]
      string FromTime_FORMATTED { get; set; }

      [SwaggerSchema("End of time interval")]
      [SwaggerExampleValue("2024-06-24T22:00:00Z")]
      DateTime ToTime { get; set; }

      [SwaggerSchema($"{nameof(ToTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("25.06.2024")]
      string ToTime_FORMATTED { get; set; }

      [SwaggerSchema("Total amount of comment data entries")]
      [SwaggerExampleValue(46)]
      uint ElementCount { get; set; }

      [SwaggerSchema("List of time stamps")]
      [SwaggerExampleValue("[\"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\", \"1970-01-01T00:00:00Z\"]")]
      List<DateTime> TimeValues { get; set; }

      [SwaggerSchema($"{nameof(TimeValues)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("[\"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\", \"01.01.1970 00:00:00\"]")]
      List<string> TimeValues_FORMATTED { get; set;}

      [SwaggerSchema("List of comment data values")]
      [SwaggerExampleValue(typeof(IHandValRawDataComment))]
      List<T> CommentData { get; set; }


   }

   public enum CompTypes : short
   {
      DBN_HAND = DBN_CompTypes.DAT_HAND,

      DBN_AGHANDVAL = DBN_CompTypes.DAT_AGHANDVAL,

      DBN_COMMENT = DBN_CompTypes.DAT_COMMENT,
   }

}
