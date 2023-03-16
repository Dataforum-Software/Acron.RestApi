using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses
{
   /// <summary>
   /// Interface for groups of external variables
   /// </summary>
   public interface IUpdateExtVarGroupObjectRequestResource : IUpdateGroupBaseObjectRequestResource
   {
      void SetProviderId(int providerId);

      /// <summary> Base object ID of superior provider </summary>
      [SwaggerSchema("Base object id of superior provider")]
      [SwaggerExampleValue("102000002")]
      int PropIdProvider
      {
         get;
      }
   }
}