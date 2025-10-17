using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.EventData
{
   public interface IGetEventDataRequestResource<T> where T : IEventSelectionParameters
   {
      List<T> EventSelectionParameters { get; set; }

      EventSortOrder EventsOrder { get; set; }

      EventSortOrder StepsOrder { get; set; }
   }

   public enum EventSortOrder
   {
      NONE = -1,  // KEINE Sortierung durchführen
      CFG_OLDNEW = 0,  // Ereignisse / Schritte nach Konfiguration / aufsteigend
      CFG_NEWOLD = 1,  // Ereignisse / Schritte nach Konfiguration / absteigend
      OLDNEW = 2, // Ereignisse + Schritte chronologisch / aufsteigend (Option 'Chronologisch' aktiv V7.3 - V8.4)
      NEWOLD = 3, // Ereignisse + Schritte chronologisch / absteigend

   };

   public enum EventFilters
   {
      ALL = 0,  //kein Filter
      CLOSED = 1,  //nur abgeschlossene Ereignisse
      OPEN = 2, //nur offene Ereignisse
      STARTING = 3,   //Die Startzeit des Events muß im Zeitbereich liegen
      ENDING = 4,  //Die Stoppzeit des Events muß im Zeitbereich liegen
   };

   [Flags]
   public enum ReadOptions
   {
      NONE = 0x0,      // Keine Optionen gesetzt
      READ_CELL = 0x1,      // Zellen mit einlesen
      READ_SUB = 0x2,    // Unterereignisse mit einlesen
      READ_CELL_SUB = 0x3,
      AUTODEL = 0x8, //Gelöschte Ereignisse mit einlesen
      READ_CELL_AUTODEL = 0x9,
      READ_SUB_AUTODEL = 0x10,
      READ_CELL_SUB_AUTODEL = 0x11,
   };

}
