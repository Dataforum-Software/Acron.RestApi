using Swashbuckle.AspNetCore.Annotations;
using static Acron.RestApi.Interfaces.BaseObjects.AlertDefines;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for input masks for process variables
   /// </summary>
   public interface IPvMaskObject : IBaseObject
   {
      /// <summary> Type of mask </summary>
      [SwaggerSchema("Type of mask")]
      [SwaggerExampleValue(PvMaskDefines.MaskType.RowWithOneDay)]
      PvMaskDefines.MaskType PropMaskType { get; set; }
   }


   public static class PvMaskDefines
   {
      /// <summary>
      /// Type of pv masks
      /// </summary>
      public enum MaskType : int
      {
         /// <summary>Process variables as columns, daily</summary>
         ColumnWithOneDay = 0,
         /// <summary>Process variables as columns, month</summary>
         ColumnWithDaysOfOneMonth = 1,
         /// <summary>Process variables as rows, daily</summary>
         RowWithOneDay = 2,
         /// <summary>Process variables as rows, month</summary>
         RowWithDaysOfOneMonth = 3,
      }

   }
}
