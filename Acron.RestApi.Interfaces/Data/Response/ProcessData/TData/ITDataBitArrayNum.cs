using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataBitArrayNum : ITDataBitArrayBase
   {

      /// <summary>
      /// Unterer Grenzbereich des Prozesswertes unterschritten
      /// </summary>

      [SwaggerSchema("Process value falls short of lower value range limit")]
      [SwaggerExampleValue(true)]
      public bool UnderLimit { get; set; }

      /// <summary>
      /// Oberer Grenzbereich des Prozesswertes überschritten
      /// </summary>

      [SwaggerSchema("process value exceeds upper value range limit")]
      [SwaggerExampleValue(true)]
      public bool OverLimit { get; set; }
   }
}
