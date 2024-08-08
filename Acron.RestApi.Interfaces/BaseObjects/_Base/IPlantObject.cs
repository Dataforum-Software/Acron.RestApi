using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for plant designer  /// </summary>
   public interface IPlantObject : IBaseObject
   {
      /// <summary> Alert state </summary>
      /// <remarks> Default value == AlertDefines.Disturbance</remarks>
      // AlertDefines.AlertState PropState { get; set; }

      /// <summary> Plant version </summary>
      [SwaggerSchema("Plant version")]
      [SwaggerExampleValue("9.4")]
      string PropVersion  { get; }

      /// <summary> Data offset hours </summary>
      [SwaggerSchema("Data offset hours")]
      [SwaggerExampleValue("0")]
      uint PropOffsetHours { get; }

      /// <summary> Data offset days </summary>
      [SwaggerSchema("Data offset days")]
      [SwaggerExampleValue("0")]
      uint PropOffsetDays { get; }

      /// <summary> Data offset months </summary>
      [SwaggerSchema("Data offset months")]
      [SwaggerExampleValue("0")]
      uint PropOffsetMonths { get; }


      /// <summary> Compression interval 1 or null</summary>
      [SwaggerSchema("Compression interval 1 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal1 { get; }

      /// <summary> Compression interval 2 or null</summary>
      [SwaggerSchema("Compression interval 2 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal2 { get; }

      /// <summary> Compression interval 3 or null</summary>
      [SwaggerSchema("Compression interval 3 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal3 { get; }

      /// <summary> Compression interval 4 or null</summary>
      [SwaggerSchema("Compression interval 4 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal4 { get; }

      /// <summary> Compression interval 5 or null</summary>
      [SwaggerSchema("Compression interval 5 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal5 { get; }

      /// <summary> Compression interval 6 or null</summary>
      [SwaggerSchema("Compression interval 6 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal6 { get; }

      /// <summary> Compression interval 7 or null</summary>
      [SwaggerSchema("Compression interval 7 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal7 { get; }

      /// <summary> Compression interval 8 or null</summary>
      [SwaggerSchema("Compression interval 8 or null")]
      [SwaggerExampleValue(typeof(ICompIval))]
      ICompIval PropCompIVal8 { get; }
   }

   public static class PlantDefines
   {
      // Compression type
      public enum DBNCompType : int
      {
         DBN_NONE = 0,     // Unbekannt oder bei Graph automatisch
         DBN_INT_1 = 1,    // Intervall 1 Daten
         DBN_INT_2 = 2,    // Intervall 2 Daten
         DBN_INT_3 = 3,    // Intervall 3 Daten
         DBN_INT_4 = 4,    // Intervall 4 Daten
         DBN_INT_5 = 5,    // Intervall 5 Daten
         DBN_INT_6 = 6,    // Intervall 6 Daten
         DBN_INT_7 = 7,    // Intervall 7 Daten
         DBN_INT_8 = 8,    // Intervall 8 Daten

         DBN_DAY_1 = 9,    // Tagesdaten aus Intervall 1
         DBN_DAY_2 = 10,      // Tagesdaten aus Intervall 2
         DBN_DAY_3 = 11,      // Tagesdaten aus Intervall 3, wird nicht verwendet
         DBN_DAY_4 = 12,      // Tagesdaten aus Intervall 4, wird nicht verwendet
         DBN_DAY_5 = 13,      // Tagesdaten aus Intervall 5, wird nicht verwendet
         DBN_DAY_6 = 14,      // Tagesdaten aus Intervall 6, wird nicht verwendet
         DBN_DAY_7 = 15,      // Tagesdaten aus Intervall 7, wird nicht verwendet
         DBN_DAY_8 = 16,      // Tagesdaten aus Intervall 8, wird nicht verwendet

         DBN_WEEK = 17,    // Wochendaten
         DBN_MONTH = 18,      // Monatsdaten
         DBN_YEAR_WEEK = 19,     // Jahresdaten aus Wochenwerten
         DBN_YEAR_MONTH = 20,    // Jahresdaten aus Monatswerten
         DBN_TEMP = 21,

         // Weitere Typen für die Datenbeschaffung, die für die normale Kompression uninteressant sind

         DBN_INT_VAR_DAY = 22, //Intervalldaten mit variabler Intervalbreite
         DBN_INT_VAR = 23, //Intervalldaten mit variabler Intervalbreite ohne resultierende Tagesdaten

         DBN_PROCESS = 24, //Processdaten
         DBN_PROCESS_INCLUDE_FIRST_LAST = 25, //Processdaten mit erstem und letztem aus dem Zeitbereich
         DBN_PROCESS_WITHOUT_NOVALID = 26, //Processdaten ohne NOVALID-Werte

         DBN_VALINFO = 27
      };

   }
}
