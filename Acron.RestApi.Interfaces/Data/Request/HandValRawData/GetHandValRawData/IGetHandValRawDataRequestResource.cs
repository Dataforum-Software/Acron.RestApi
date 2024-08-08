using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataRequestResource
    {
      [SwaggerSchema("Start time stamp")]
      [SwaggerExampleValue("2020-08-15T12:00:00Z")]
      DateTimeOffset FromTime { get; set; }

      DateTime FromTime_UTC { get; }

      [SwaggerSchema("End time stamp")]
      [SwaggerExampleValue("2020-08-15T16:00:00Z")]
      DateTimeOffset ToTime { get; set; }

      DateTime ToTime_UTC { get; }

      [SwaggerSchema("Read the type of the manual variables")]
      [SwaggerExampleValue(HANDVALREADTYPES.READ_ALL_PERDAYS)]
      HANDVALREADTYPES HandValReadType { get; set; }

      [SwaggerSchema("List of process variables")]
      [SwaggerExampleValue(new int[] { 302000003, 302000001, 302000002 })]
      List<int> PVs { get; set; }
    }

   [SwaggerSchema("Read types of manual value")]
   public enum HANDVALREADTYPES : short
    {
      [SwaggerEnumInfo("All daily values in interval")]
      READ_ALL_PERDAYS = 0,     //alle Werte im Zeitbereich werden gelesen, pro Tag

      [SwaggerEnumInfo("Each first value per month in interval")]
      READ_ONE_PERMONTH = 1,    //nur der erste Wert pro Monat wird gelesen

      [SwaggerEnumInfo("Each first value per year in interval")]
      READ_ONE_PERYEAR = 2,    //nur der erste Wert pro Jahr wird gelesen
    }

}
