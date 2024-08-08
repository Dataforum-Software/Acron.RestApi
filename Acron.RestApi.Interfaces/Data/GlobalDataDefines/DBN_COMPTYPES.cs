namespace Acron.RestApi.Interfaces.Data.GlobalDataDefines
{
   enum DBN_CompTypes : int
   {
      [SwaggerEnumInfo("Undefined")]
      DBN_NONE = 0,        // Unbekannt oder bei Graph automatisch

      [SwaggerEnumInfo("Main interval")]
      DBN_INT_1 = 1,        // Intervall 1 Daten

      [SwaggerEnumInfo("Secondary interval")]
      DBN_INT_2 = 2,        // Intervall 2 Daten

      [SwaggerEnumInfo("Custom Interval 1")]
      DBN_INT_3 = 3,        // Intervall 3 Daten

      [SwaggerEnumInfo("Custom Interval 2")]
      DBN_INT_4 = 4,        // Intervall 4 Daten

      [SwaggerEnumInfo("Custom Interval 3")]
      DBN_INT_5 = 5,        // Intervall 5 Daten

      [SwaggerEnumInfo("Custom Interval 4")]
      DBN_INT_6 = 6,        // Intervall 6 Daten

      [SwaggerEnumInfo("Custom Interval 5")]
      DBN_INT_7 = 7,        // Intervall 7 Daten

      [SwaggerEnumInfo("Custom Interval 6")]
      DBN_INT_8 = 8,        // Intervall 8 Daten

      [SwaggerEnumInfo("Daily values from main interval")]
      DBN_DAY_1 = 9,        // Tagesdaten aus Intervall 1

      [SwaggerEnumInfo("Daily values from secondary interval")]
      DBN_DAY_2 = 10,        // Tagesdaten aus Intervall 2

      [SwaggerEnumInfo("deprecated")]
      DBN_DAY_3 = 11,        // Tagesdaten aus Intervall 3, wird nicht verwendet

      [SwaggerEnumInfo("deprecated")]
      DBN_DAY_4 = 12,        // Tagesdaten aus Intervall 4, wird nicht verwendet

      [SwaggerEnumInfo("deprecated")]
      DBN_DAY_5 = 13,        // Tagesdaten aus Intervall 5, wird nicht verwendet

      [SwaggerEnumInfo("deprecated")]
      DBN_DAY_6 = 14,        // Tagesdaten aus Intervall 6, wird nicht verwendet

      [SwaggerEnumInfo("deprecated")]
      DBN_DAY_7 = 15,        // Tagesdaten aus Intervall 7, wird nicht verwendet

      [SwaggerEnumInfo("deprecated")]
      DBN_DAY_8 = 16,        // Tagesdaten aus Intervall 8, wird nicht verwendet

      [SwaggerEnumInfo("Weekly values")]
      DBN_WEEK = 17,        // Wochendaten

      [SwaggerEnumInfo("Monthly values")]
      DBN_MONTH = 18,        // Monatsdaten

      [SwaggerEnumInfo("Yearly values from weekly interval")]
      DBN_YEAR_WEEK = 19,        // Jahresdaten aus Wochenwerten

      [SwaggerEnumInfo("Yearly values from monthly interval")]
      DBN_YEAR_MONTH = 20,        // Jahresdaten aus Monatswerten

      [SwaggerEnumInfo("Dynamic compression type, calculated at runtime")]
      DBN_TEMP = 21,

      // Weitere Typen für die Datenbeschaffung, die für die normale Kompression uninteressant sind

      DBN_INT_VAR_DAY = 22, //Intervalldaten mit variabler Intervalbreite
      DBN_INT_VAR = 23, //Intervalldaten mit variabler Intervalbreite ohne resultierende Tagesdaten

      [SwaggerEnumInfo("Process values")]
      DBN_PROCESS = 24, //Processdaten

      [SwaggerEnumInfo("Include whole time frame, even if first or last value(s) are empty")]
      DBN_PROCESS_INCLUDE_FIRST_LAST = 25, //Processdaten mit erstem und letztem aus dem Zeitbereich

      [SwaggerEnumInfo("Process values - no empty values")]
      DBN_PROCESS_WITHOUT_NOVALID = 26, //Processdaten ohne NOVALID-Werte

      [SwaggerEnumInfo("Extended attributes of manual variables")]
      DBN_VALINFO = 27,

      [SwaggerEnumInfo("Raw process values")]
      DBN_PROCESS_RAWDATA = 28,        // Prozess-Rohwerte

      [SwaggerEnumInfo("Hand Values")]
      DAT_HAND = 50,                         // Handwerte

      [SwaggerEnumInfo("Hand Values for Service Entities")]
      DAT_AGHANDVAL = 51,                    // Aggregat-Handwerte

      [SwaggerEnumInfo("Comments")]
      DAT_COMMENT = 52,                      // Kommentardaten
   }
}
