using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   // <summary>
   /// Interface for key figures
   /// </summary>
   public interface ICreatePvCalcReferenceObjectRequestResource : ICreatePvCalcObjectRequestResource
   {
      /// <summary> ID of the assigned key figure template </summary>
      [SwaggerSchema("Id of the assigned key figure template")]
      int PropIdReferenceNumberTemplate { get; }
   }
}