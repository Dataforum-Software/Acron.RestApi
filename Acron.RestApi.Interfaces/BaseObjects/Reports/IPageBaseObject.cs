using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for page objects (model, page and report-page)
   /// </summary>
   public interface IPageBaseObject : IBaseObject
   {
      /// <summary>
      /// ID of parent report or 0
      /// </summary>
      [SwaggerSchema("ID of parent report or 0")]
      [SwaggerExampleValue(0)]
      int PropReportId
      {
         get;
      }

      /// <summary>
      /// Description of page object
      /// </summary>
      [SwaggerSchema("Description of formular")]
      [SwaggerExampleValue("My new page")]
      string PropPageInfo
      {
         get; set;
      }

   }

   public static class PageBaseDefines
   {
      /// <summary>
      /// Available page model types
      /// </summary>
      public enum Type : int
      {
         /// <summary>Unbekannt </summary>
         ModelUnknown = 0,
         /// <summary>Prozessbericht, tabellarisch </summary>
         ModelProVert = 1,
         /// <summary>Tagesbericht, horizontal </summary>
         ModelDayHorz = 2,
         /// <summary>Tagesbericht, vertikal </summary>
         ModelDayVert = 3,
         /// <summary>Wochenbericht, horizontal </summary>
         ModelWeekHorz = 4,
         /// <summary>Wochenbericht, vertikal </summary>
         ModelWeekVert = 5,
         /// <summary>Monatsbericht, horizontal </summary>
         ModelMonHorz = 6,
         /// <summary>Monatsbericht, vertikal </summary>
         ModelMonVert = 7,
         /// <summary>Jahresbericht, horizontal </summary>
         ModelYearHorz = 8,
         /// <summary>Jahresbericht, vertikal, Basis Tag </summary>
         ModelYearVertDay = 9,
         /// <summary>Jahresbericht, vertikal, Basis Monat </summary>
         ModelYearVertMon = 10,
         /// <summary>Jahresbericht, vertikal, Basis Woche </summary>
         ModelYearVertWeek = 11,
         /// <summary>Jahresbericht, vertikal, Tage, monatsweise </summary>
         ModelYearVertMdays = 12,
         /// <summary>Variabler Zeitbericht, Basis Prozess </summary>
         ModelVarPro = 13,
         /// <summary>Variabler Zeitbericht, Basis Intervall </summary>
         ModelVarInter = 14,
         /// <summary>Variabler Zeitbericht, Basis Tag </summary>
         ModelVarDay = 15,
         /// <summary>Variabler Zeitbericht, Basis Woche </summary>
         ModelVarWeek = 16,
         /// <summary>Variabler Zeitbericht, Basis Monat </summary>
         ModelVarMon = 17,
         /// <summary>Wartungsanweisung </summary>
         ModelInstWart = 18,
         /// <summary>Historie </summary>
         ModelInstHist = 19,
         /// <summary>Zustandsbericht </summary>
         ModelInstZu = 20,
         /// <summary>Graph Bericht </summary>
         ModelGraph = 21,
         /// <summary>Störungsbericht </summary>
         ModelStoRep = 22,
         /// <summary>Störungsstatistik </summary>
         ModelStoStat = 23,
         /// <summary>Meldungsbericht </summary>
         ModelMldRep = 24,
         /// <summary>Meldungsstatistik </summary>
         ModelMldStat = 25,
         /// <summary>externe Variablen </summary>
         ModelConfVar = 26,
         /// <summary>Verfahrensgrößen </summary>
         ModelConfPv = 27,
         /// <summary>Instandhaltung	Aggregate </summary>
         ModelConfAgg = 28,
         /// <summary>Instandhaltung	Wartungen </summary>
         ModelConfServ = 29,
         /// <summary>Benutzerdefinierte Graphen-Vorlage  </summary>
         ModelGraphUser = 30,
         /// <summary>Ereignisberichte / Ereignisse </summary>
         ModelBatEvent = 31,
         /// <summary>Benutzerdefinierte Vorlage Zustandsbericht </summary>
         ModelProtRep = 32,
         /// <summary></summary>
         ModelProtRepDetail = 33,
         /// <summary></summary>
         ModelSoll = 34,
         /// <summary></summary>
         ModelInstZuUser = 35,
         /// <summary>Tagesereignisse </summary>
         ModelDayEvent = 36,
         /// <summary>Wartungsmaterialien </summary>
         ModelInstMaterial = 37,
         /// <summary>ACTOPICAL </summary>
         ModelTopical = 38,
         /// <summary>Störungs- und Meldungsbericht Tracker 5.7/158 </summary>
         ModelStoMldRep = 39,
         /// <summary>Meldungen und Störungen als Meldungen Tracker 5.7/256 </summary>
         ModelAllMldRep = 40,
         /// <summary>Schichtbericht Tracker 5.7/95 </summary>
         ModelShiftPro = 41,
         /// <summary>Schichtbericht Tracker 5.7/95 </summary>
         ModelShiftInter = 42,
         /// <summary>Ereignisberichte / Stoerungen+Meldungen </summary>
         ModelBatStoMld = 43,
         /// <summary>Wochenereignisse </summary>
         ModelWeekEvent = 44,
         /// <summary>Monatsereignisse </summary>
         ModelMonEvent = 45,
         /// <summary>Benutzerdefinierte Graphen-Vorlage (Datentabelle) </summary>
         ModelGrTabUser = 46,
         /// <summary>Reperaturanweisung </summary>
         ModelInstRepair = 47,
         /// <summary>Benutzerdefinierte Vorlage Aggregathistorie </summary>
         ModelInstHistUser = 48,
         // <summary>Registrierungsfax </summary>
         // ModelRegisterFax = 49, // deprecated
         /// <summary>Tagesbericht, horizontal, 1 h Intervalle </summary>
         ModelDayHorz24h = 50,
         /// <summary>Standardvorlage Graph Tabelle </summary>
         ModelGraphTable = 51,

         /// <summary>Benutzerdefinierte WA</summary>
         ModelInstWartUser = 52,
         /// <summary>Benutzerdefinierte Materialübersicht</summary>
         ModelInstMaterialUser = 53,
         /// <summary>Benutzerdefinierte RA</summary>
         ModelInstRepairUser = 54,

         /// <summary> Standardvorlage Betriebsdaten </summary>
         ModelOperatingDataReport = 55,

         /// <summary>Monatsbericht, Grenzwertabweichungen </summary>
         ModelMonSoll = 56,
         /// <summary>Wochenbericht, Grenzwertabweichungen </summary>
         ModelWeekSoll = 57,
         /// <summary>Jahresbericht, Grenzwertabweichungen </summary>
         ModelYearSoll = 58,

      }

      /// <summary>
      /// Available types for page objects
      /// </summary>
      public enum FormularType : int
      {
         /// <summary> Unbekannter Seitentyp </summary>
         Unknown = -1,

         /// <summary> Prozessbericht, vertikal </summary>
         Process = 0,
         /// <summary> Prozessbericht, online </summary>
         ProcessTopical = 1,

         /// <summary> Tagesbericht, vertikal </summary>
         DayVertical = 10,
         /// <summary> Tagesbericht, horizontal </summary>
         DayHorizontal = 11,
         /// <summary> Tagesbericht, Grenzwertverletzungen</summary>
         DaySoll = 12,
         /// <summary> Tagesbericht, Alarme </summary>
         DayAlert = 13,
         /// <summary> Tagesbericht, Ereignisse</summary>
         DayEvent = 14,

         /// <summary> Schichtbericht</summary>
         Shift = 20,

         /// <summary> Wochenbericht, vertikal</summary>
         WeekVertical = 30,
         /// <summary> Wochenbericht, horizontal</summary>
         WeekHorizontal = 31,
         /// <summary> Wochenbericht, Alarme </summary>
         WeekAlert = 32,
         /// <summary> Wochenbericht, Ereignisse</summary>
         WeekEvent = 33,
         /// <summary> Wochenbericht, Grenzwertabweichungen</summary>
         WeekSoll = 34,

         /// <summary> Monatsbericht, vertikal</summary>
         MonthVertical = 40,
         /// <summary> Monatsbericht, horizontal</summary>
         MonthHorizontal = 41,
         /// <summary> Monatsbericht, Alarme </summary>
         MonthAlert = 42,
         /// <summary> Monatsbericht, Ereignisse</summary>
         MonthEvent = 43,
         /// <summary> Monatsbericht, Grenzwertabweichungen</summary>
         MonthSoll = 44,

         /// <summary> Jahresbericht, vertikal</summary>
         YearVertical = 50,
         /// <summary> Jahresbericht, vertikal Tage/Monatsweise</summary>
         YearVerticalMDay = 51,
         /// <summary> Jahresbericht, horizontal</summary>
         YearHorizontal = 52,
         /// <summary> Jahresbericht, Alarme </summary>
         YearAlert = 53,
         /// <summary> Jahresbericht, Ereignisse</summary>
         YearEvent = 54,
         /// <summary> Jahresbericht, Grenzwertabweichungen</summary>
         YearSoll = 55,

         /// <summary> Variabler Zeitbericht, vertikal</summary>
         VarVertical = 60,
         /// <summary> Variabler Zeitbericht, Alarme </summary>
         VarAlert = 61,
         /// <summary> Variabler Zeitbericht, Ereignisse</summary>
         VarEvent = 64,

         /// <summary> Aggregatbezogener Bericht</summary>
         ServiceAggregate = 70,
         /// <summary> Wartungsbezogener Bericht</summary>
         ServiceService = 71,
         /// <summary> Instandhaltungsbericht - Wartungsanweisungen </summary>
         ServiceSvOrder = 72,
         /// <summary> Instandhaltungsbericht - Aggregathistorie </summary>
         ServiceAgHistory = 73,
         /// <summary> Instandhaltungsbericht - Zustandsbericht </summary>
         ServiceState = 74,
         /// <summary> Instandhaltungsbericht - Wartungsmaterialien </summary>
         ServiceSvMaterial = 75,
         /// <summary> Instandhaltungsbericht - Reparaturanweisungen </summary>
         ServiceAgOrder = 76,

         /// <summary> Ereignisbericht, Basis Ereignisse</summary>
         Event = 80,

         /// <summary> Graphbericht - Graph </summary>
         Graph = 90,
         /// <summary> Graphbericht - Graphdaten </summary>
         GraphData = 91,

         /// <summary> Konfigurationsbericht - Externe Variablen </summary>
         ConfigExtVar = 100,
         /// <summary> Konfigurationsbericht - Verfahrensgrößen </summary>
         ConfigProcessVar = 101,
         /// <summary> Konfigurationsbericht - Aggregate </summary>
         ConfigAggregate = 102,
         /// <summary> Konfigurationsbericht - Wartungen </summary>
         ConfigService = 103,

         /// <summary> Protokollbericht, allgemein </summary>
         ProtocolGeneral = 110,
         /// <summary> Protokollbericht, detailliert </summary>
         ProtocolDetailed = 111,

         /// <summary> Alarmbericht - Störungsstatistik </summary>
         AlertStoStatistic = 120,
         /// <summary> Alarmbericht - Meldungsstatistik </summary>
         AlertMldStatistic = 121,
         /// <summary> Alarmbericht - Störungen + Meldungen </summary>
         AlertStoMld = 122,

         // <summary> Formular Ausgabe Betriebsdaten </summary>
         OperatingData = 130,

         /// <summary> ACRON Registrierung </summary>
         //P_REGISTERFAX = 59,
      }

      /// <summary>
      /// Datenherkunft der Tabellendaten eines Formulars
      /// </summary>
      public enum DataSource : int
      {

         /// <summary>Unbekannt oder bei Graph automatisch</summary>
         Unknown = PlantDefines.DBNCompType.DBN_NONE,

         /// <summary>Intervall 1 Daten</summary>
         Interval1 = PlantDefines.DBNCompType.DBN_INT_1,
         /// <summary>Intervall 2 Daten</summary>
         Interval2 = PlantDefines.DBNCompType.DBN_INT_2,    // Intervall 2 Daten
         /// <summary>Intervall 3 Daten</summary>
         Interval3 = PlantDefines.DBNCompType.DBN_INT_3,    // Intervall 3 Daten
         /// <summary>Intervall 4 Daten</summary>
         Interval4 = PlantDefines.DBNCompType.DBN_INT_4,    // Intervall 4 Daten
         /// <summary>Intervall 5 Daten</summary>
         Interval5 = PlantDefines.DBNCompType.DBN_INT_5,    // Intervall 5 Daten
         /// <summary>Intervall 6 Daten</summary>
         Interval6 = PlantDefines.DBNCompType.DBN_INT_6,    // Intervall 6 Daten
         /// <summary>Intervall 7 Daten</summary>
         Interval7 = PlantDefines.DBNCompType.DBN_INT_7,    // Intervall 7 Daten
         /// <summary>Intervall 8 Daten</summary>
         Interval8 = PlantDefines.DBNCompType.DBN_INT_8,    // Intervall 8 Daten

         /// <summary>Tagesdaten aus Intervall 1</summary>
         Day1 = PlantDefines.DBNCompType.DBN_DAY_1,
         /// <summary>Tagesdaten aus Intervall 2</summary>
         Day2 = PlantDefines.DBNCompType.DBN_DAY_2,
         /// <summary>Tagesdaten aus Intervall 3, wird nicht verwendet</summary>
         Day3 = PlantDefines.DBNCompType.DBN_DAY_3,
         /// <summary>Tagesdaten aus Intervall 4, wird nicht verwendet</summary>
         Day4 = PlantDefines.DBNCompType.DBN_DAY_4,      // Tagesdaten aus Intervall 4, wird nicht verwendet
         /// <summary>Tagesdaten aus Intervall 5, wird nicht verwendet</summary>
         Day5 = PlantDefines.DBNCompType.DBN_DAY_5,      // Tagesdaten aus Intervall 5, wird nicht verwendet
         /// <summary>Tagesdaten aus Intervall 6, wird nicht verwendet</summary>
         Day6 = PlantDefines.DBNCompType.DBN_DAY_6,      // Tagesdaten aus Intervall 6, wird nicht verwendet
         /// <summary>Tagesdaten aus Intervall 7, wird nicht verwendet</summary>
         Day7 = PlantDefines.DBNCompType.DBN_DAY_7,      // Tagesdaten aus Intervall 7, wird nicht verwendet
         /// <summary>Tagesdaten aus Intervall 8, wird nicht verwendet</summary>
         Day8 = PlantDefines.DBNCompType.DBN_DAY_8,      // Tagesdaten aus Intervall 8, wird nicht verwendet

         /// <summary>Wochendaten</summary>
         Week = PlantDefines.DBNCompType.DBN_WEEK,    // Wochendaten
         /// <summary>Monatsdaten</summary>
         Month = PlantDefines.DBNCompType.DBN_MONTH,      // Monatsdaten
         /// <summary>Jahresdaten aus Monatswerten</summary>
         Year = PlantDefines.DBNCompType.DBN_YEAR_MONTH,

         /// <summary>Intervalldaten mit variabler Intervalbreite ohne resultierende Tagesdaten</summary>
         Variable = PlantDefines.DBNCompType.DBN_INT_VAR,

         /// <summary>Prozessedaten</summary>
         Process = PlantDefines.DBNCompType.DBN_PROCESS,

         /// <summary> Störungen </summary>
         Disturbance = 200,
         /// <summary> Meldungen </summary>
         Message = 201,
         /// <summary> Störungen + Meldungen </summary>
         DisturbanceAndMessage = 202,

         /// <summary> Ereignisse </summary>
         Event = 250,
      }

   }

}

