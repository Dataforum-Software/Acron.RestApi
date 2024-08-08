using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for alert groups
   /// </summary>
   public interface IEventGroupObject : IRealGroupObject
   {
      /// <summary>
      /// Id of event report of this group
      /// </summary>
      [SwaggerSchema("Id of event report of this group")]
      [SwaggerExampleValue(0)]
      int PropReportId { get; set; }
   }
}
