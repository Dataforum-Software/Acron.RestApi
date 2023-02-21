using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteHandValCommentsRequestResouce<T> where T : IWriteHandValCommentsPVDescription
   {      
      public AVComKinds AVComKind { get; set; } //short  Bemerkungtyp
      public DateTime TimeStamp { get; set; } //Zeitstempel des Tages-, Woche-, Monats oder  Jahr      
      public List<T> PVDescriptions { get; set; } //Kommentar
   }

   public enum AVComKinds : short
   {
      AVCOMMENT_UNKNOWN = 0,    // return value for unknown base. NO DATA-BASE!
      AVCOMMENT_DAY = 1,    // comment for a day
      AVCOMMENT_WEEK = 2,    // comment for a week
      AVCOMMENT_MON = 3,    // comment for a month
      AVCOMMENT_YEAR = 5,    // comment for a year
      AVCOMMENT_PVDAY = 6,    // daily-comment for a PV (also PV-handvalues)
      AVCOMMENT_PVWEEK = 7,    // weekly-comment for a PV
      AVCOMMENT_PVMON = 8,    // monthly-comment for a PV
      AVCOMMENT_PVYEAR = 9,    // yearly-comment for a PV
      AVCOMMENT_AGDAY = 10,    // comment for a AG-handvalue on one day
      AVCOMMENT_RTDAY = 11,    // comment for a Runtime-handvalue on one day
      AVCOMMENT_SSDAY = 12,    // comment for a Switch-handvalue on one day
      AVCOMMENT_PVWEEKVAL = 14,
      AVCOMMENT_PVMONVAL = 15,
      AVCOMMENT_PVYEARVAL = 16,
   }

}
