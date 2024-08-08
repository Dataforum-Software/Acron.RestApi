using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for report objects
   /// </summary>
   public interface IReportObject : IBaseObject
   {
      /// <summary> Report kind </summary>
      [SwaggerSchema("Report kind")]
      [SwaggerExampleValue(ReportDefines.ReportKind.FRM_DAY)]
      ReportDefines.ReportKind PropReportKind { get; }

      /// <summary> Need interval width </summary>
      [SwaggerSchema("Need interval width")]
      [SwaggerExampleValue("false")]
      bool PropNeedIntervalWidth { get; }
   }


   public static class ReportDefines
   {

      /// <summary> Kind of acron report </summary>
      public enum ReportKind : int
      {
         /// <summary> Unknown report type </summary>
         FRM_UNKNOWN = -1,
         /// <summary> Process report </summary>
         FRM_PRO = 0,
         /// <summary> Day report </summary>
         FRM_DAY = 1,
         /// <summary> Week report </summary>
         FRM_WEEK = 2,
         /// <summary> Month report </summary>
         FRM_MON = 3,
         /// <summary> Year report </summary>
         FRM_YEAR = 4,
         /// <summary> Time report with variable data base </summary>
         FRM_VAR = 5,
         /// <summary> Protocol report </summary>
         FRM_PROT = 8,
         /// <summary> Shift report </summary>
         FRM_SHIFT = 9,
         /// <summary> Event report </summary>
         FRM_EVENT = 10,
      }

   }

}
