using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Base interface for units
   /// </summary>
   public interface ICreateUnitBaseRequestResource : ICreateGroupBaseObjectRequestResource
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