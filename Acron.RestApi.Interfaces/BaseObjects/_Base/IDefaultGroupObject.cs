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
         DefaultUnknown = 0,
         /// <summary> User administration </summary>
         DefaultUserManagement = 1,
         /// <summary> Process connection </summary>
         DefaultProcessConnection = 2,
         /// <summary> Alerts </summary>
         DefaultAlerts = 3,
         /// <summary> Process variables </summary>
         DefaultProcessVariables = 4,
         /// <summary> Events </summary>
         DefaultEvents = 5,
         /// <summary> Service </summary>
         DefaultService = 6,
         /// <summary> Key figure templates </summary>
         //DefaultModels = 7,
         /// <summary> Reports </summary>
         DefaultReports = 8,
         /// <summary> Report diagrams </summary>
         ///DefaultReportGraphs = 9,                    
         /// <summary> Report, export and import jobs </summary>
         DefaultJobs = 10,
         /// <summary> Input masks </summary>
         DefaultReporterMasks = 12,
         /// <summary> Language files </summary>
         DefaultTranslator = 13,
         /// <summary> Diagrams (all Types) </summary>
         DefaultGraphs = 14,
         /// <summary> Connections </summary>
         DefaultConnection = 15,
         /// <summary> Units </summary>
         DefaultUnit = 16,
         /// <summary> Key figures (ReferenceNumber) </summary>
         DefaultReferenceNumber = 17,
         /// <summary> Alert window (all Types) </summary>
         DefaultAlertTables = 18,
         /// <summary> Remote notification </summary>
         DefaultRemoteAlarm = 19,
      }

      #endregion Default Group

   }
}
