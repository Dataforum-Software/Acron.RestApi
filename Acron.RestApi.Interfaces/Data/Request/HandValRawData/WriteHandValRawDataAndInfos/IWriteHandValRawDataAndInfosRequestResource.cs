using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public interface IWriteHandValRawDataAndInfosRequestResource<PVDescriptionType, ValuesType, FlagType>
                                                                     where PVDescriptionType : IWriteHandValRawDataAndInfosPVDescription<ValuesType, FlagType>
                                                                     where ValuesType : IWriteHandValRawDataAndInfos<FlagType>
                                                                     where FlagType : IWriteHandValRawDataAndInfoFlag
   {
      //TagesZeitStempel

      [SwaggerSchema("Daily time stamp")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset DayTimeStamp { get; set; }

      public DateTime DayTimeStamp_UTC { get; }

      [SwaggerSchema("List of descriptions for requested process variables")]
      [SwaggerExampleValue(typeof(IWriteHandValRawDataAndInfosRequestResource<IWriteHandValRawDataAndInfosPVDescription<IWriteHandValRawDataAndInfos<IWriteHandValRawDataAndInfoFlag>, IWriteHandValRawDataAndInfoFlag>, IWriteHandValRawDataAndInfos<IWriteHandValRawDataAndInfoFlag>, IWriteHandValRawDataAndInfoFlag>))]
      public List<PVDescriptionType> PVDescriptions { get; set; }
   }
}
