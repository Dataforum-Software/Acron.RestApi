using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.MonthWeekData
{
   public interface IMonthWeekDataFlag
   {
      //Bit 0 gesetzt:  MDAT_ERSATZ   Ersatzwert eingestellt
      [SwaggerSchema("Monthly/Weekly value is a substitute value")]
      [SwaggerExampleValue(false)]
      public bool MDAT_REPLACEMENT { get; set; }

      //Bit 1 gesetzt:  MDAT_NOREL   Wert nicht freigegeben
      [SwaggerSchema("Approval management is active and monthly value was not approved")]
      [SwaggerExampleValue(false)]
      public bool MDAT_NOREL { get; set; }

      //Bit 2 gesetzt:  MDAT_MISSING   Wert nicht vorhanden
      [SwaggerSchema("Monthly/Weekly value does not exist")]
      [SwaggerExampleValue(false)]
      public bool MDAT_MISSING { get; set; }

      //Bit 6 gesetzt:  MDAT_UNDER_LIMIT Wert unterschreitet Grenzwertbereich
      [SwaggerSchema("Monthly/Weekly value falls short of lower limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool MDAT_UNDER_LIMIT { get; set; }

      //Bit 7 gesetzt:  MDAT_OVER_LIMIT Wert überschreitet Grenzwertbereich
      [SwaggerSchema("Monthly/Weekly value exceeds upper limit for this process variable")]
      [SwaggerExampleValue(false)]
      bool MDAT_OVER_LIMIT { get; set; }
   }
}
