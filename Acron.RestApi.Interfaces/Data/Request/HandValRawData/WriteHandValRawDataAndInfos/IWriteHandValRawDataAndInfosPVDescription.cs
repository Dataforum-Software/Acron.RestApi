using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public interface IWriteHandValRawDataAndInfosPVDescription<ValuesType, FlagType> where ValuesType : IWriteHandValRawDataAndInfos<FlagType>
                                                                                    where FlagType : IWriteHandValRawDataAndInfoFlag
   {
      public uint PVID { get; set; }
      public List<ValuesType> Values { get; set; }
   }
}
