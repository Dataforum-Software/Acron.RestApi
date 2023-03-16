using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   /// <summary>
   /// Base interface for units
   /// </summary>
   public interface IUpdateUnitBaseRequestResource : IUpdateGroupBaseObjectRequestResource
   {
      /// <summary>
      /// Beschreibung der Einheit
      /// </summary>
      /// 
      [SwaggerSchema("Description of unit ")]
      [SwaggerExampleValue("")]
      public string PropDescription { get; set; }
   }
}