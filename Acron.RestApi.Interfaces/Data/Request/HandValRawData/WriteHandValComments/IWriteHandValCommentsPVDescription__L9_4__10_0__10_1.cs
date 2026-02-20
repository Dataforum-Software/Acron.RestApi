using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteHandValCommentsPVDescription__L9_4__10_0__10_1
   {
      [SwaggerSchema("Numeric ID of process variable")]
      [SwaggerExampleValue(302000003)]
      public uint PVID { get; set; }
      //public T CDAT { get; set; } / In CDat sind der User und die TimeStamp der Erfassung. Dies wird von der RestAPI / DBServer versorgt

      [SwaggerSchema("Comment")]
      [SwaggerExampleValue("")]
      public string Comment { get; set; }
   }
}
