using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for report groups
   /// </summary>
   public interface IReportGroupObject : IRealGroupObject
   {
      /// <summary>
      /// Type of report group - custom or predefined by ACRON
      /// </summary>
      /// 
      [SwaggerSchema("Type of report group")]
      [SwaggerExampleValue(ReportGroupDefines.GroupType.Standard)]
      ReportGroupDefines.GroupType PropGroupType { get; }
   }

   public static class ReportGroupDefines
   {
      public enum GroupType : int
      {
         /// <summary> User created group below an default group </summary>
         [SwaggerEnumInfo("User created group below an default group")]
         Standard = 0,
         /// <summary> User created group, region diagrams </summary>
         [SwaggerEnumInfo("User created group, region diagrams")]
         StandardGraph = 1,
         /// <summary> User created group, region service </summary>
         [SwaggerEnumInfo("User created group, region service")]
         StandardService = 2,

         /// <summary> Default group for process reports </summary>
         [SwaggerEnumInfo("Default group for process reports")]
         DefaultReportProcess = 10,
         /// <summary> Default group for day reports </summary>
         [SwaggerEnumInfo("Default group for day reports")]
         DefaultReportDay = 11,
         /// <summary> Default group for week reports </summary>
         [SwaggerEnumInfo("Default group for week reports")]
         DefaultReportWeek = 12,
         /// <summary> Default group for month reports </summary>
         [SwaggerEnumInfo("Default group for month reports")]
         DefaultReportMonth = 13,
         /// <summary> Default group for year reports </summary>
         [SwaggerEnumInfo("Default group for year reports")]
         DefaultReportYear = 14,
         /// <summary> Default group for variable reports </summary>
         [SwaggerEnumInfo("Default group for variable reports")]
         DefaultReportVariableTime = 15,
         /// <summary> Default group for shift reports </summary>
         [SwaggerEnumInfo("Default group for shift reports")]
         DefaultReportShift = 16,
         /// <summary> Default group for models </summary>
         [SwaggerEnumInfo("Default group for models")]
         DefaultModel = 17,
         /// <summary> Default group for event reports </summary>
         [SwaggerEnumInfo("Default group for event reports")]
         DefaultReportEvent = 18,

         /// <summary> Default group for service reports </summary>
         [SwaggerEnumInfo("Default group for service reports")]
         DefaultReportService = 19,
         /// <summary> Default group for diagram reports </summary>
         [SwaggerEnumInfo("Default group for diagram reports")]
         DefaultReportGraph = 20,
         /// <summary> Default group for alert reports </summary>
         [SwaggerEnumInfo("Default group for alert reports")]
         DefaultReportAlert = 21,
         /// <summary> Default group for configurstion reports </summary>
         [SwaggerEnumInfo("Default group for configurstion reports")]
         DefaultReportConfig = 22,
         /// <summary> Default group for protocol reports </summary>
         [SwaggerEnumInfo("Default group for protocol reports")]
         DefaultReportProtocol = 23,
      }

   }
}
