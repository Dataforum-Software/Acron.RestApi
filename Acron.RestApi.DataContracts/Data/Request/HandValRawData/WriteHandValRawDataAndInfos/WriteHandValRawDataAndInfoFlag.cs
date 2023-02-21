using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public class WriteHandValRawDataAndInfoFlag : IWriteHandValRawDataAndInfoFlag
   {
      public bool HDAT_GREATER { get; set; }
      public bool HDAT_LESS { get; set; }
      public bool HDAT_KEYVALID { get; set; }
   }
}
