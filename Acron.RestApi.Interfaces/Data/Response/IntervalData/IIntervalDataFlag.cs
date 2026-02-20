using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.IntervalData
{
   public interface IIntervalDataFlag
   {
      //Bit 0 gesetzt:  IDAT_ERSATZ   Ersatzwert eingestellt
      [SwaggerSchema("Interval value is a substitute value")]
      [SwaggerExampleValue(false)]
      bool IDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  IDAT_OVER      Manuell Überschriebener Wert
      [SwaggerSchema("Interval value was overridden manually")]
      [SwaggerExampleValue(false)]
      bool IDAT_OVER { get; set; }

      //Bit 2 gesetzt:  IDAT_LESS tatsächlicher Wert ist kleiner als angegebener Wert
      [SwaggerSchema("Only for manual values. Manual value provided is a \"less than\" expression. (e.g. \"< 15.0\")")]
      [SwaggerExampleValue(false)]
      bool IDAT_LESS { get; set; }

      //Bit 3 gesetzt:  IDAT_GREATER tatsächlicher Wert ist größer als angegebener Wert
      [SwaggerSchema("Only for manual values. Manual value provided is a \"greater than\" expression. (e.g. \"> 25.0\")")]
      [SwaggerExampleValue(false)]
      bool IDAT_GREATER { get; set; }

      //Bit 4 gesetzt:  IDAT_MISSING Wert ist nicht vorhanden
      [SwaggerSchema("Interval value does not exist")]
      [SwaggerExampleValue(false)]
      bool IDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  IDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      [SwaggerSchema("Interval value falls short of lower limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool IDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  IDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      [SwaggerSchema("Interval value exceeds upper limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool IDAT_OVER_LIMIT { get; set; }

      [SwaggerSchema("Interval value is the minimum value in the data set")]
      [SwaggerExampleValue(true)]
      bool IDAT_MINIMUM { get; set; }

      [SwaggerSchema("Interval value is the maximum value in the data set")]
      [SwaggerExampleValue(true)]
      bool IDAT_MAXIMUM { get; set; }

   }
}
