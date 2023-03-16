using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Interface for plant designer  /// </summary>
   public interface ICreatePlantObjectRequestResource : ICreateBaseObjectRequestResource
   {
      /// <summary> Plant version </summary>
      /// 
      [SwaggerSchema("Plant version")]
      [SwaggerExampleValue("9.4")]
      string PropVersion { get; }
   }

}