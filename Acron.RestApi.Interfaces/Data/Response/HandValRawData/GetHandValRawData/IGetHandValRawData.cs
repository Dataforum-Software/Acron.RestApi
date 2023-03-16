using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawData<GetHandValRawDataDayValueType, GetHandValRawDataValueType, GetHandValRawDataFlagType>
                                          where GetHandValRawDataDayValueType : IGetHandValRawDataDayValue<GetHandValRawDataValueType, GetHandValRawDataFlagType>
                                          where GetHandValRawDataValueType : IGetHandValRawDataValue<GetHandValRawDataFlagType>
                                          where GetHandValRawDataFlagType : IGetHandValRawDataFlag
   {
      [SwaggerSchema("Numeric ID of process value")]
      [SwaggerExampleValue(302000003)]
      public uint PVID { get; set; }

      [SwaggerSchema($"Number of values in {nameof(DayList)}")]
      [SwaggerExampleValue(30)]
      public int DaysCount { get; }


      [SwaggerSchema($"Collection of {nameof(IGetHandValRawDataDayValue<IGetHandValRawDataValue<IGetHandValRawDataFlag>, IGetHandValRawDataFlag>)} objects, one per process variable")]
      [SwaggerExampleValue(typeof(IGetHandValRawDataDayValue<IGetHandValRawDataValue<IGetHandValRawDataFlag>, IGetHandValRawDataFlag>))]
      public List<GetHandValRawDataDayValueType> DayList { get; set; }
    }
}
