namespace Acron.RestApi.Interfaces.BaseObjects
{

   public static class EventDefines
   {
      public enum EventDataFilter : int
      {
         /// <summary> All event data </summary>
         AllEvents = 0,
         /// <summary> Only closed event datasets </summary>
         OnlyClosed = 1,
         /// <summary> Only open event datasets </summary>
         OnlyOpen = 2,
         /// <summary> Only event datasets starting in time range </summary>
         OnlyStarting = 3,
         /// <summary> Only event datasets ending in timerange </summary>
         OnlyEnding = 4,
      }

      /// <summary>
      /// Sortorder of event datasets
      /// </summary>
      public enum EventDataSortOrder : int
      {
         /// <summary> Do NOT sort any way </summary>
         None = -1,

         /// <summary> As configured in DSG, chronological aufsteigend </summary>
         DesignerAZ = 0,
         /// <summary> As configured in DSG, chronological absteigend </summary>
         DesignerZA = 1,
         /// <summary> Chronological aufsteigend </summary>
         GeneralAZ = 2,
         /// <summary> Chronological absteigend </summary>
         GeneralZA = 3,
      }

   }

}