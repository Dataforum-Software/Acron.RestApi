using System;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData
{
   public interface IWriteHandValRawDataRequestResource<PVDescriptionType,ProvalType> where PVDescriptionType : IWriteHandValRawDataPVDescription<ProvalType>
                                                                                      where ProvalType : IWriteHandValRawDataProval
   {
      public DateTime DayTimeStamp { get; set; }
      public List<PVDescriptionType> PVDescriptions { get; set; }
   }
}
