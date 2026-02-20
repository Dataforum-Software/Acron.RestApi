using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataFlag
   {
      //Bit 0 gesetzt:  HDAT_GREATER
      [SwaggerSchema("Manual value provided is a \"greater than\" expression. (e.g. \"> 25.0\")")]
      [SwaggerExampleValue(false)]
      public bool HDAT_GREATER { get; set; }

      //Bit 1 gesetzt:  HDAT_LESS
      [SwaggerSchema("Manual value provided is a \"less than\" expression. (e.g. \"< 15.0\")")]
      [SwaggerExampleValue(false)]
      public bool HDAT_LESS { get; set; }

      //Bit 2 gesetzt:  HDAT_KEYVALID
      [SwaggerSchema($"Contents of {nameof(IGetHandValRawDataValue<IGetHandValRawDataFlag>.OptionalInputKey)} are valid")]
      [SwaggerExampleValue(false)]
      public bool HDAT_KEYVALID { get; set; }

      //Bit 6 gesetzt:  YDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      [SwaggerSchema("Manual value falls short of lower limit for this manual variable")]
      [SwaggerExampleValue(false)]
      public bool HDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  YDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      [SwaggerSchema("Manual value exceeds upper limit for this manual variable")]
      [SwaggerExampleValue(false)]
      public bool HDAT_OVER_LIMIT { get; set; }
   }
}
