using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteHandValCommentsRequestResouce<T> where T : IWriteCommentsPVDescription
   {
      [SwaggerSchema("Different comment type")]
      [SwaggerExampleValue(AVComKinds.AVCOMMENT_UNKNOWN)]
      public CommentKind CommentKind { get; set; } //short  Bemerkungtyp

      [SwaggerSchema("Time stamp for manual values of process variables")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset TimeStamp { get; set; } //Zeitstempel des Tages-, Woche-, Monats oder  Jahr

      public DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("List of process variable description")]
      [SwaggerExampleValue(typeof(IWriteCommentsPVDescription))]
      public List<T> PVDescriptions { get; set; } //Kommentar
   }

   [SwaggerSchema("Comment types")]
   [JsonConverter(typeof(StringEnumConverter))]
   public enum CommentKind : short
   {
      [SwaggerEnumInfo("Undefined")]
      AVCOMMENT_UNKNOWN = 0,    // return value for unknown base. NO DATA-BASE!

      [SwaggerEnumInfo("Daily comment")]
      AVCOMMENT_DAY = 1,    // comment for a day

      [SwaggerEnumInfo("Weekly comment")]
      AVCOMMENT_WEEK = 2,    // comment for a week

      [SwaggerEnumInfo("Monthly comment")]
      AVCOMMENT_MON = 3,    // comment for a month

      [SwaggerEnumInfo("Yearly comment")]
      AVCOMMENT_YEAR = 5,    // comment for a year


   }

}
