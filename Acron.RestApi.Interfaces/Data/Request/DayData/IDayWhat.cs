using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Request.DayData
{
   public interface IDayWhat
   {
      //0
      //Daten Typ im Ergebnis: time_t
      //Bit nicht setzen, hat nur in der alten Welt Bedeutung
      //bool DDAT_TIME { get; set; }


      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue("true")]
      bool DDAT_FLAG { get; set; }

      [SwaggerSchema("Daily value")]
      [SwaggerExampleValue("true")]
      bool DDAT_DVAL { get; set; }


      [SwaggerSchema("Daily value of process value")]
      [SwaggerExampleValue("true")]
      bool DDAT_DVALAVG { get; set; }


      [SwaggerSchema("Time of daily value")]
      [SwaggerExampleValue("true")]
      bool DDAT_DVALTM { get; set; }


      [SwaggerSchema("Sum of process values")]
      [SwaggerExampleValue("true")]
      bool DDAT_PSUM { get; set; }


      [SwaggerSchema("Minimum process value")]
      [SwaggerExampleValue("true")]
      bool DDAT_PMIN { get; set; }


      [SwaggerSchema("Time of minimum process value")]
      [SwaggerExampleValue("true")]
      bool DDAT_PMINTM { get; set; }


      [SwaggerSchema("Maximum process value")]
      [SwaggerExampleValue("true")]
      bool DDAT_PMAX { get; set; }


      [SwaggerSchema("Time of maximum process value")]
      [SwaggerExampleValue("true")]
      bool DDAT_PMAXTM { get; set; }


      [SwaggerSchema("Number of range limit shortfalls - process values")]
      [SwaggerExampleValue("true")]
      bool DDAT_PMINLIM { get; set; }


      [SwaggerSchema("Number of range limit exceedings - process values")]
      [SwaggerExampleValue("true")]
      bool DDAT_PMAXLIM { get; set; }


      [SwaggerSchema("Number of process values")]
      [SwaggerExampleValue("true")]
      bool DDAT_PCOUNT { get; set; }


      [SwaggerSchema("Sum of interval values")]
      [SwaggerExampleValue("true")]
      bool DDAT_ISUM { get; set; }


      [SwaggerSchema("Standard deviation of process values")]
      [SwaggerExampleValue("true")]
      bool DDAT_ISIGMA { get; set; }


      [SwaggerSchema("Percentile value 15% of process values")]
      [SwaggerExampleValue("true")]
      bool DDAT_IPERC15 { get; set; }


      [SwaggerSchema("Percentile value 85% of process values")]
      [SwaggerExampleValue("true")]
      bool DDAT_IPERC85 { get; set; }


      [SwaggerSchema("Minimum interval value")]
      [SwaggerExampleValue("true")]
      bool DDAT_IMIN { get; set; }


      [SwaggerSchema("Time of minimum interval value")]
      [SwaggerExampleValue("true")]
      bool DDAT_IMINTM { get; set; }


      [SwaggerSchema("Maximum interval value")]
      [SwaggerExampleValue("true")]
      bool DDAT_IMAX { get; set; }


      [SwaggerSchema("Time of maximum interval value")]
      [SwaggerExampleValue("true")]
      bool DDAT_IMAXTM { get; set; }


      [SwaggerSchema("Number of range limit shortfalls - interval values")]
      [SwaggerExampleValue("true")]
      bool DDAT_IMINLIM { get; set; }


      [SwaggerSchema("Number of range limit exceedings - interval values")]
      [SwaggerExampleValue("true")]
      bool DDAT_IMAXLIM { get; set; }


      [SwaggerSchema("Number of interval values")]
      [SwaggerExampleValue("true")]
      bool DDAT_ICOUNT { get; set; }
   }
}
