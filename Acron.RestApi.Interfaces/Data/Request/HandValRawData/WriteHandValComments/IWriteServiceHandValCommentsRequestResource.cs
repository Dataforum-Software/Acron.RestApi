using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteServiceHandValCommentsRequestResource<T> where T : IWriteServiceHandValCommentsEntityDescription
   {
      [SwaggerSchema("Different comment type")]
      [SwaggerExampleValue(ServiceCommentKind.SSDAY)]
      public ServiceCommentKind CommentKind { get; set; } //short  Bemerkungtyp

      [SwaggerSchema("Time stamp for comment")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset TimeStamp { get; set; } //Zeitstempel des Tages-, Woche-, Monats oder  Jahr

      public DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("List of service entity description")]
      [SwaggerExampleValue(typeof(IWriteServiceHandValCommentsEntityDescription))]
      public List<T> EntityDescriptions { get; set; } //Kommentar
   }

   [SwaggerSchema("Service entity comment")]
   [JsonConverter(typeof(StringEnumConverter))]
   public enum ServiceCommentKind : short
   {
      [SwaggerEnumInfo("Comment for a manual service variable that records operation time")]
      RTDAY = AVComKinds.AVCOMMENT_RTDAY,

      [SwaggerEnumInfo("Comment for manual service variable taht records switching cycles")]
      SSDAY = AVComKinds.AVCOMMENT_SSDAY,
   }
}
