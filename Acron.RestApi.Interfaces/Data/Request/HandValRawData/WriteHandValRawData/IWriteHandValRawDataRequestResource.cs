using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData
{
   public interface IWriteHandValRawDataRequestResource<PVDescriptionType,ProvalType> where PVDescriptionType : IWriteHandValRawDataPVDescription<ProvalType>
                                                                                      where ProvalType : IWriteHandValRawDataProval
   {
      [SwaggerSchema("Daily time stamp")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTimeOffset DayTimeStamp { get; set; }

      public DateTime DayTimeStamp_UTC { get; }

      [SwaggerSchema("List of process variable descriptions")]
      [SwaggerExampleValue(typeof(IWriteHandValRawDataRequestResource<IWriteHandValRawDataPVDescription<IWriteHandValRawDataProval>, IWriteHandValRawDataProval>))]
      public List<PVDescriptionType> PVDescriptions { get; set; }
   }
}
