using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteHandValCommentsRequestResouce<T> where T : IWriteHandValCommentsPVDescription
   {
      [SwaggerSchema("Different comment type")]
      [SwaggerExampleValue(AVComKinds.AVCOMMENT_UNKNOWN)]
      public AVComKinds AVComKind { get; set; } //short  Bemerkungtyp

      [SwaggerSchema("Time stamp for manual values of process variables")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset TimeStamp { get; set; } //Zeitstempel des Tages-, Woche-, Monats oder  Jahr

      public DateTime TimeStamp_UTC { get; }

      [SwaggerSchema("List of process variable description")]
      [SwaggerExampleValue(typeof(IWriteHandValCommentsRequestResouce<IWriteHandValCommentsPVDescription>))]
      public List<T> PVDescriptions { get; set; } //Kommentar
   }


   [SwaggerSchema("Comment types")]
   public enum AVComKinds : short
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

      [SwaggerEnumInfo("Daily comment for a process- or manual variable")]
      AVCOMMENT_PVDAY = 6,    // daily-comment for a PV (also PV-handvalues)

      [SwaggerEnumInfo("Weekly comment for process variable")]
      AVCOMMENT_PVWEEK = 7,    // weekly-comment for a PV

      [SwaggerEnumInfo("Monthly comment for process variable")]
      AVCOMMENT_PVMON = 8,    // monthly-comment for a PV

      [SwaggerEnumInfo("Yearly comment for process variable")]
      AVCOMMENT_PVYEAR = 9,    // yearly-comment for a PV

      [SwaggerEnumInfo("Comment for a service entity manual variable")]
      AVCOMMENT_AGDAY = 10,    // comment for a AG-handvalue on one day

      [SwaggerEnumInfo("Comment for a operation time manual variable")]
      AVCOMMENT_RTDAY = 11,    // comment for a Runtime-handvalue on one day

      [SwaggerEnumInfo("Comment for a switching cycles manual variable")]
      AVCOMMENT_SSDAY = 12,    // comment for a Switch-handvalue on one day

      [SwaggerEnumInfo("Weekly value for a process variable of type text")]
      AVCOMMENT_PVWEEKVAL = 14, // weekly-value for a text pv

      [SwaggerEnumInfo("Monthly value for a process variable of type text")]
      AVCOMMENT_PVMONVAL = 15, // monthly-value for a text pv

      [SwaggerEnumInfo("Yearly value for a process variable of type text")]
      AVCOMMENT_PVYEARVAL = 16, // yearly-value for a text pv
   }

}
