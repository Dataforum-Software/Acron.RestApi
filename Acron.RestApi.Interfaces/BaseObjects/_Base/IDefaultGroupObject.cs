using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for main groups (sections of the configuration)
   /// </summary>
   public interface IDefaultGroupObject : IGroupBaseObject
   {
      /// <summary>
      /// Type of default group
      /// </summary>
      /// <remarks>Every type denotes one section of the configuration.
      /// This default group is the uppermost parent base object of all base objects in this section.</remarks>
      /// 

      [SwaggerSchema("Type of default group")]
      [SwaggerExampleValue("DefaultProcessVariables")]
      DefaultGroupDefines.GroupType PropGroupType
      {
         get;
      }

   }

   public static class DefaultGroupDefines
   {
      #region Default Group

      public enum GroupType : int
      {
         [SwaggerEnumInfo("Undefined")]
         DefaultUnknown = 0,

         /// <summary> User administration </summary>
         [SwaggerEnumInfo("User administration")]
         DefaultUserManagement = 1,

         /// <summary> Process connection </summary>
         [SwaggerEnumInfo("Process connection")]
         DefaultProcessConnection = 2,

         /// <summary> Alerts </summary>
         [SwaggerEnumInfo("Alerts")]
         DefaultAlerts = 3,

         /// <summary> Process variables </summary>
         [SwaggerEnumInfo("Process variables")]
         DefaultProcessVariables = 4,

         /// <summary> Events </summary>
         [SwaggerEnumInfo("Events")]
         DefaultEvents = 5,

         /// <summary> Service </summary>
         [SwaggerEnumInfo("Service")]
         DefaultService = 6,

         /// <summary> Key figure templates </summary>
         //DefaultModels = 7,

         /// <summary> Reports </summary>
         [SwaggerEnumInfo("Reports")]
         DefaultReports = 8,

         /// <summary> Report diagrams </summary>
         ///DefaultReportGraphs = 9,        

         /// <summary> Report, export and import jobs </summary>
         [SwaggerEnumInfo("Report, export and import jobs")]
         DefaultJobs = 10,

         /// <summary> Input masks </summary>
         [SwaggerEnumInfo("Input masks")]
         DefaultReporterMasks = 12,

         /// <summary> Language files </summary>
         [SwaggerEnumInfo("Language files")]
         DefaultTranslator = 13,

         /// <summary> Diagrams (all Types) </summary>
         [SwaggerEnumInfo("Diagrams")]
         DefaultGraphs = 14,

         /// <summary> Connections </summary>
         [SwaggerEnumInfo("Conections")]
         DefaultConnection = 15,

         /// <summary> Units </summary>
         [SwaggerEnumInfo("Units")]
         DefaultUnit = 16,

         /// <summary> Key figures (ReferenceNumber) </summary>
         [SwaggerEnumInfo("Key figure templates")]
         DefaultReferenceNumber = 17,

         /// <summary> Alert window (all Types) </summary>
         DefaultAlertTables = 18,

         /// <summary> Remote notification </summary>
         [SwaggerEnumInfo("Remote notification")]
         DefaultRemoteAlarm = 19,
      }

      #endregion Default Group

   }
}
