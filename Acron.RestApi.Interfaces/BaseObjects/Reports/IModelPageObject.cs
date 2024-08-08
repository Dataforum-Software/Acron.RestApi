using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for page model objects
   /// </summary>
   public interface IModelPageObject : IPageBaseObject
   {
      /// <summary>
      /// Type of model
      /// </summary>
      [SwaggerSchema("Type of model")]
      [SwaggerExampleValue(PageBaseDefines.Type.ModelProVert)]
      PageBaseDefines.Type PropType
      {
         get;
      }

      /// <summary>
      /// Number of model
      /// </summary>
      [SwaggerSchema("Number of model")]
      [SwaggerExampleValue(1)]
      int PropNumber
      {
         get; set;
      }

   }

}

