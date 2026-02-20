using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteCommentsPVDescription
   {
      [SwaggerSchema("Numeric ID of process variable")]
      [SwaggerExampleValue(302000003)]
      public uint PVID { get; set; }

      [SwaggerSchema("Comment")]
      [SwaggerExampleValue("New Comment")]
      public string Comment { get; set; }
   }
}
