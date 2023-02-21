using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Request
{
   public interface IGetAllRequestResource
   {
      [SwaggerSchema("Retrieve only a small subset of identifying properties")]
      [SwaggerExampleValue(false)]
      bool SmallObjects { get; }
   }

   public interface IGetAllRequestResource__L9_0__9_1__9_2__9_3
   {
      [SwaggerSchema("Retrieve only a small subset of identifying properties")]
      [SwaggerExampleValue(false)]
      bool SmallObjects { get; }

      [SwaggerSchema("Display locked alerts normally hidden from plant configuration")]
      [SwaggerExampleValue(false)]
      bool ShowLockedAlerts { get; }
   }
}
