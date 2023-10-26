using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for groups of external variables
   /// </summary>
   public interface IExtVarGroupObject : IRealGroupObject
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