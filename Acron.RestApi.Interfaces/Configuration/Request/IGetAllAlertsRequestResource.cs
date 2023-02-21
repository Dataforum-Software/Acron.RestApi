using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IGetAllAlertsRequestResource : IGetAllRequestResource
   {
      [SwaggerSchema("Display locked alerts normally hidden from plant configuration")]
      [SwaggerExampleValue(false)]
      bool ShowLockedAlerts { get; }
   }
}
