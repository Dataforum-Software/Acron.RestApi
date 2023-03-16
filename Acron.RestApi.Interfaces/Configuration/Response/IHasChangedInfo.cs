using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface IHasChangedInfo
   {
      [SwaggerSchema($"Indicates whether the current user has unsaved changes to the plant configuration")]
      [SwaggerExampleValue(false)]
      bool HasChanged { get; set; }
   }
}