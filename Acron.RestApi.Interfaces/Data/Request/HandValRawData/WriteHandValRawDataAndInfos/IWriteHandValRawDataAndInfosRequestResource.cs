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
      public DateTime DayTimeStamp { get; set; }
      public List<PVDescriptionType> PVDescriptions { get; set; }
   }
}
