using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataRequestResource
    {
        DateTime FromTime { get; set; }
        DateTime ToTime { get; set; }
        HANDVALREADTYPES HandValReadType { get; set; }
        List<int> PVs { get; set; }
    }

    public enum HANDVALREADTYPES : short
    {
        READ_ALL_PERDAYS = 0,     //alle Werte im Zeitbereich werden gelesen, pro Tag
        READ_ONE_PERMONTH = 1,    //nur der erste Wert pro Monat wird gelesen
        READ_ONE_PERYEAR = 2,    //nur der erste Wert pro Jahr wird gelesen
    }

}
