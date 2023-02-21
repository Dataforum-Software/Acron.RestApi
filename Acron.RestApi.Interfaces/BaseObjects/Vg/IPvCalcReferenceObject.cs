using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   // <summary>
   /// Interface for key figures
   /// </summary>
   public interface IPvCalcReferenceObject : IPvCalcObject
   {
      /// <summary> ID of the assigned key figure template </summary>
      [SwaggerSchema("Id of the assigned key figure template")]
      int PropIdReferenceNumberTemplate { get; }
   }
}