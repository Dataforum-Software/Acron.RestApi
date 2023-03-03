using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{

   public static class EventDefines
   {
      public enum EventDataFilter : int
      {
         /// <summary> All event data </summary>
         [SwaggerEnumInfo("All event data")]
         AllEvents = 0,

         /// <summary> Only closed event datasets </summary>
         [SwaggerEnumInfo("Only closed event data sets")]
         OnlyClosed = 1,

         /// <summary> Only open event datasets </summary>
         [SwaggerEnumInfo("Only open event data sets")]
         OnlyOpen = 2,

         /// <summary> Only event datasets starting in time range </summary>
         [SwaggerEnumInfo("Only event data sets starting in time range")]
         OnlyStarting = 3,

         /// <summary> Only event datasets ending in timerange </summary>
         [SwaggerEnumInfo("Only event data sets ending in time range")]
         OnlyEnding = 4,
      }

      /// <summary>
      /// Sortorder of event datasets
      /// </summary>
      [SwaggerSchema("Sort order of event data sets")]
      public enum EventDataSortOrder : int
      {
         /// <summary> Do NOT sort any way </summary>
         [SwaggerEnumInfo("Sorting of evets disabled")]
         None = -1,

         /// <summary> As configured in DSG, chronological aufsteigend </summary>
         [SwaggerEnumInfo("Events are sorted as configured in ACRON Designer, alphabetically ascending")]
         DesignerAZ = 0,
         /// <summary> As configured in DSG, chronological absteigend </summary>
         [SwaggerEnumInfo("Events are sorted as configured in ACRON Designer, alphabetically descending")]
         DesignerZA = 1,
         /// <summary> Chronological aufsteigend </summary>
         [SwaggerEnumInfo("Events are sorted alphabetically ascending")]
         GeneralAZ = 2,
         /// <summary> Chronological absteigend </summary>
         [SwaggerEnumInfo("Events are sorted alphabetically descending")]
         GeneralZA = 3,
      }

   }

}