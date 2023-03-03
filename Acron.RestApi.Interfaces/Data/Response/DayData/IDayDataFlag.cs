using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface IDayDataFlag
   {
      //Bit 0 gesetzt:  DDAT_ERSATZ   Ersatzwert eingestellt
      [SwaggerSchema("Daily value is a substitute value")]
      [SwaggerExampleValue(false)]
      bool DDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  DDAT_OVER      Manuell Überschriebener Wert
      [SwaggerSchema("Daily value was overridden manually")]
      [SwaggerExampleValue(false)]
      bool DDAT_OVER { get; set; }

      //Bit 2 gesetzt:  DDAT_LESS tatsächlicher Wert ist kleiner als angegebener Wert
      [SwaggerSchema("Only for manual values. Manual value provided is a \"less than\" expression. (e.g. \"< 15.0\")")]
      [SwaggerExampleValue(false)]
      bool DDAT_LESS { get; set; }

      //Bit 3 gesetzt:  DDAT_GREATER tatsächlicher Wert ist größer als angegebener Wert
      [SwaggerSchema("Only for manual values. Manual value provided is a \"greater than\" expression. (e.g. \"> 25.0\")")]
      [SwaggerExampleValue(false)]
      bool DDAT_GREATER { get; set; }

      //Bit 4 gesetzt:  DDAT_NOREL Wert ist nicht freigegeben
      [SwaggerSchema("Approval management is active and process value was not approved")]
      [SwaggerExampleValue(false)]
      bool DDAT_NOREL { get; set; }

      //Bit 5 gesetzt:  DDAT_MISSING Wert ist nicht vorhanden
      [SwaggerSchema("Daily value does not exist")]
      [SwaggerExampleValue(false)]
      bool DDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  DDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      [SwaggerSchema("Daily value falls short of lower limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool DDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  DDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      [SwaggerSchema("Daily value exceeds upper limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool DDAT_OVER_LIMIT { get; set; }

   }
}
