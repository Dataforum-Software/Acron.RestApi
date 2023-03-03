using Swashbuckle.AspNetCore.Annotations;
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
      [SwaggerSchema("Identification of Process Variable")]
      [SwaggerExampleValue(302000003)]
      public uint PVID { get; set; }

      [SwaggerSchema("List of process variable values")]
      [SwaggerExampleValue(typeof(IWriteHandValRawDataAndInfosPVDescription<IWriteHandValRawDataAndInfos<IWriteHandValRawDataAndInfoFlag>, IWriteHandValRawDataAndInfoFlag>))]
      public List<ValuesType> Values { get; set; }
   }
}
