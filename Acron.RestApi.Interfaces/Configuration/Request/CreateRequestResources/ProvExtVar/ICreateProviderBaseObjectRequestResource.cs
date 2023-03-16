using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses
{
   /// <summary>
   /// Base interface for provider()
   /// </summary>
   public interface ICreateProviderBaseObjectRequestResource : ICreateGroupBaseObjectRequestResource
   {
      /// <summary>
      /// Provider ID; Range 1..99
      /// </summary>
      /// <remarks>
      /// !!! Not to be confused with the provider's ACRON base object ID. !!!
      /// </remarks>
      /// 
      [SwaggerSchema(" Id provider")]
      [SwaggerExampleValue("1")]
      int PropProviderId
      {
         get; set;
      }
   }
}