using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.YearData
{
   public interface IYearDataFlag
   {
      //Bit 0 gesetzt:  YDAT_ERSATZ   Ersatzwert eingestellt
      [SwaggerSchema("Yearly value is a substitute value")]
      [SwaggerExampleValue(false)]
      public bool YDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  YDAT_NOREL   Wert nicht freigegeben
      [SwaggerSchema("Approval management is active and process value was not approved")]
      [SwaggerExampleValue(false)]
      public bool YDAT_NOREL { get; set; }

      //Bit 2 gesetzt:  YDAT_MISSING   Wert nicht vorhanden
      [SwaggerSchema("Yearly value does not exist")]
      [SwaggerExampleValue(false)]
      public bool YDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  YDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      [SwaggerSchema("Yearly value falls short of lower limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool YDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  YDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      [SwaggerSchema("Daily value exceeds upper limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool YDAT_OVER_LIMIT { get; set; }

   }
}
