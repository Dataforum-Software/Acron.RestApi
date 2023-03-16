using Acron.RestApi.Interfaces.Data.Response.IntervalData;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataResult<GetHandValRawDataType, GetHandValRawDataDayValueType, GetHandValRawDataValueType, GetHandValRawDataFlagType>
                                          where GetHandValRawDataType : IGetHandValRawData<GetHandValRawDataDayValueType, GetHandValRawDataValueType, GetHandValRawDataFlagType>
                                          where GetHandValRawDataDayValueType : IGetHandValRawDataDayValue<GetHandValRawDataValueType, GetHandValRawDataFlagType>
                                          where GetHandValRawDataValueType : IGetHandValRawDataValue<GetHandValRawDataFlagType>
                                          where GetHandValRawDataFlagType : IGetHandValRawDataFlag
   {
      [SwaggerSchema("Result contains values")]
      [SwaggerExampleValue(true)]
      bool HasData { get; }

      [SwaggerSchema("Number of manual variables in result")]
      [SwaggerExampleValue(15)]
      int PVCount { get; }

      [SwaggerSchema("List of manual variables")]
      [SwaggerExampleValue(typeof(List<IGetHandValRawData<IGetHandValRawDataDayValue<IGetHandValRawDataValue<IGetHandValRawDataFlag>, IGetHandValRawDataFlag>, IGetHandValRawDataValue<IGetHandValRawDataFlag>, IGetHandValRawDataFlag>>))]
      List<GetHandValRawDataType> PVList { get; set; }
    }
}
