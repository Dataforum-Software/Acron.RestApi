using System;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos
{
   public interface IWriteHandValRawDataInfo<T> where T : IWriteHandValRawDataInfoFlag
   {
      uint PVID { get; set; }
      DateTime TimeStamp { get; set; } //Zeitstempel der Zusatzinfo. Muss zur TimeStamp des Handwertes passen
      ushort MilliSeconds { get; }
      T ProInfoFlag { get; set; }
      //DateTime Edit_TimeStamp { get; set; } //Eingabezeit /Wird von der RestAPI/DBServer versorgt
      //string User { get; set; } //Eingabeuser 29 Unicode Zeichen /Wird von der RestAPI/DBServer versorgt
      string Key { get; set; }  //Optionaler Schlüssel 9 Unicode Zeichen
   }
}
