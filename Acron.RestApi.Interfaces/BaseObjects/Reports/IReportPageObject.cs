using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics;
using static Acron.RestApi.Interfaces.BaseObjects.PageBaseDefines;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for page objects (model, page and report-page)
   /// </summary>
   public interface IReportPageObject : IPageBaseObject
   {

      /// <summary>
      /// Type of page
      /// </summary>
      [SwaggerSchema("Type of page")]
      [SwaggerExampleValue(FormularType.DayVertical)]
      FormularType PropFormularType
      {
         get;
      }

      /// <summary>
      /// Data source of table data
      /// </summary>
      [SwaggerSchema("Data source of table data")]
      [SwaggerExampleValue(DataSource.Day1)]
      public DataSource PropFormularSource
      {
         get; set;
      }

   }

}

