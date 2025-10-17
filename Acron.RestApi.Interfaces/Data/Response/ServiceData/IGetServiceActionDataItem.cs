using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ServiceData
{
   public interface IGetServiceActionDataItem
   {
      /// <summary>
      /// Objekt ID der zugehörigen Mahnahme
      /// </summary>
      [SwaggerSchema("Numeric ID of Service Action")]
      [SwaggerExampleValue(650000001)]
      public uint ServiceId { get; set; }

      [SwaggerSchema("Unique name of service")]
      [SwaggerExampleValue("gro_e_inspektion")]
      public string ServiceShortName { get; set; }

      /// <summary>
      /// Objekt-ID des übergeordneten Aggregats
      /// </summary>
      [SwaggerSchema("Numeric ID of parent Service Entity")]
      [SwaggerExampleValue(600200001)]
      public uint ParentId { get; set; }

      /// <summary>
      /// Wartung Aktiv?
      /// </summary>
      [SwaggerSchema("Is the Service Action active?")]
      [SwaggerExampleValue(true)]
      public bool IsActive { get; set; }

      /// <summary>
      /// Prozentuale Laufzeit bei vorheriger Wartung
      /// </summary>
      [SwaggerSchema("Percentage operational time by last execution")]
      [SwaggerExampleValue(80.0)]
      public double LPerc { get; set; }

      /// <summary>
      /// Schaltspiele/Tag bei vorheriger Wartung
      /// </summary>
      [SwaggerSchema("Average daily switching cycles by last execution")]
      [SwaggerExampleValue(23)]
      public double SPerc { get; set; }

      /// <summary>
      /// Zeitpunkt der letzten Durchführung
      /// </summary>
      [SwaggerSchema("Date of last execution")]
      [SwaggerExampleValue("2024-04-29")]
      public DateOnly LastServiceDate { get; set; }

      [SwaggerSchema($"{nameof(LastServiceDate)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("29.04.2024")]
      public string LastServiceDate_FORMATTED { get; set; }

      /// <summary>
      /// Zeitpunkt der nächsten Durchführung
      /// </summary>
      [SwaggerSchema("Date of next execution")]
      [SwaggerExampleValue("2024-05-29")]
      public DateOnly NextServiceDate { get; set; }

      [SwaggerSchema($"{nameof(NextServiceDate)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("29.05.2024")]
      public string NextServiceDate_FORMATTED { get; set; }

      /// <summary>
      /// Art der nächsten Durchführung (B = Betriebszeit, L = Laufzeit, S = Schaltspiele, 0)
      /// </summary>
      [SwaggerSchema("Type of next execution (B = elapsed time, L = operational time, S = switching cycles)")]
      [SwaggerExampleValue("L")]
      public char? NextServiceType { get; set; }

      /// <summary>
      /// Druckdatum der Wartungsanweisung
      /// </summary>
      [SwaggerSchema("Last printing time of maintenance instructions")]
      [SwaggerExampleValue("2024-03-29T15:30:00Z")]
      public DateTime PrintTime { get; set; }

      [SwaggerSchema($"{nameof(PrintTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("29.03.2024 15:30")]
      public string PrintTime_FORMATTED { get; set; }

      /// <summary>
      /// Betriebszeit seit letzter Wartzung in Sekunden
      /// </summary>
      [SwaggerSchema("Elapsed time in seconds since last execution")]
      [SwaggerExampleValue(2628000)]
      public uint BCount { get; set; }

      /// <summary>
      /// Laufzeit seit letzter Wartung in Sekunden
      /// </summary>
      [SwaggerSchema("Operational time in seconds since last execution")]
      [SwaggerExampleValue(1285830)]
      public uint LCount { get; set; }

      /// <summary>
      /// Schaltspiele seit letzter Wartung
      /// </summary>
      [SwaggerSchema("Switching cycles since last execution")]
      [SwaggerExampleValue(352)]
      public uint SCount { get; set; }

      /// <summary>
      /// Gesamtetriebszeit in Sekunden
      /// </summary>
      [SwaggerSchema("Total elapsed time in seconds")]
      [SwaggerExampleValue(26285760)]
      public uint BSum { get; set; }

      /// <summary>
      /// Gesamtlaufzeit in Sekunden
      /// </summary>
      [SwaggerSchema("Total operational time in seconds")]
      [SwaggerExampleValue(12985760)]
      public uint LSum { get; set; }

      /// <summary>
      /// Gesamtanzahl Schaltspiele
      /// </summary>
      [SwaggerSchema("Total switching cycles")]
      [SwaggerExampleValue(7854)]
      public uint SSum { get; set; }

      /// <summary>
      /// Wartungsintervall Betriebszeit in Sekunden
      /// </summary>
      [SwaggerSchema("Maintenance interval elapsed time in seconds")]
      [SwaggerExampleValue(2628000)]
      public uint BIntervall { get; set; }

      /// <summary>
      /// Wartungsintervall Laufzeit in Sekunden
      /// </summary>
      [SwaggerSchema("Maintenance interval operational time in seconds")]
      [SwaggerExampleValue(1285830)]
      public uint LIntervall { get; set; }

      /// <summary>
      /// Wartungsintervall Schaltspiele
      /// </summary>
      [SwaggerSchema("Maintenance interval switching cycles")]
      [SwaggerExampleValue(1500)]
      public uint SIntervall { get; set; }

      /// <summary>
      /// Dauer der letzten Wartung in Sekunden
      /// </summary>
      [SwaggerSchema("Duration of last execution in seconds")]
      [SwaggerExampleValue(86400)]
      public uint Duration { get; set; }

      /// <summary>
      /// Kosten der letzten Wartung
      /// </summary>
      [SwaggerSchema("Cost of last execution")]
      [SwaggerExampleValue(60.0)]
      public double Cost { get; set; }

      /// <summary>
      /// Typ der letzten Aktion ('A'ktivierung 'D'eaktivierung 'W'artung 'K'orektur oder '\0')
      /// </summary>
      [SwaggerSchema("Type of last execution ( A = Activation, D = Deactivation, W = Maintenance, K = Correction)")]
      [SwaggerExampleValue(60.0)]
      public char? LastType { get; set; }

      /// <summary>
      /// Benutzerbemerkungen
      /// </summary>
      [SwaggerSchema("Operator Comment")]
      [SwaggerExampleValue("test")]
      public string Comment1 { get; set; }

      [SwaggerSchema("Operator Comment")]
      [SwaggerExampleValue("test1")]
      public string Comment2 { get; set; }

      [SwaggerSchema("Operator Comment")]
      [SwaggerExampleValue("test23")]
      public string Comment3 { get; set; }

      /// <summary>
      /// Letzte Wartung durchgeführt von
      /// </summary>
      [SwaggerSchema("Operator of last execution")]
      [SwaggerExampleValue("acron")]
      public string ServUser { get; set; }

      /// <summary>
      /// Dringlichkeit
      /// </summary>
      [SwaggerSchema("Urgency of the service action")]
      [SwaggerExampleValue(URGENCY.TODAY)]
      public URGENCY Urgency { get; set; }

   }

   public enum URGENCY
   {
      UNKNOWN = -1,
      LATER = 0,
      INRANGE = 1,
      TODAY = 2,
      BURNING = 3,
   };
}
