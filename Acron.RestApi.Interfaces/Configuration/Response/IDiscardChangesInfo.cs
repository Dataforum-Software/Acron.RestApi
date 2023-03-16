using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.Response
{
   public interface IDiscardChangesInfo
   {
      [SwaggerSchema($"Indicates whether all unsaved changes of the current to the plant configuration user were discarded successfully")]
      [SwaggerExampleValue(false)]
      bool ChangesDiscarded { get; set; }
   }
}