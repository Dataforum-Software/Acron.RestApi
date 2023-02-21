using Acron.RestApi.Interfaces.BaseObjects;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IDefaultValuesRequestResource
   {
      [SwaggerSchema("Object type to retrieve")]
      [SwaggerExampleValue(1055)]
      BaseObjectDefines.RestObjectTypeCode? RestApiTypeCode { get; }
   }
}
