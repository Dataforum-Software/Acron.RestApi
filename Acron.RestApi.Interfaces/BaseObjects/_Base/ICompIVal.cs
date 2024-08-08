using Swashbuckle.AspNetCore.Annotations;
using System;

namespace Acron.RestApi.Interfaces.BaseObjects
{
   /// <summary>
   /// Interface for compression interval  /// </summary>
   public interface ICompIval
   {
      /// <summary>Name of interval (optional)</summary>
      [SwaggerSchema("Name of interval (optional)")]
      [SwaggerExampleValue("my interval name")]
      public string Name { get; }

      /// <summary>Interval width (seconds)</summary>
      [SwaggerSchema("Interval width (seconds)")]
      [SwaggerExampleValue("3600")]
      public int Width { get;}

      /// <summary>Interval width (hours)</summary>
      [SwaggerSchema("Interval width (hours)")]
      [SwaggerExampleValue("2")]
      public int WidthPartHours { get; }

      /// <summary>Interval width (minutes)</summary>
      [SwaggerSchema("Interval width (minutes)")]
      [SwaggerExampleValue("30")]
      public int WidthPartMinutes {  get; }

      /// <summary>Count of process variables using this interval</summary>
      [SwaggerSchema("Count of process variables using this interval")]
      [SwaggerExampleValue("27")]
      public int PvCount {  get; }

   }

}