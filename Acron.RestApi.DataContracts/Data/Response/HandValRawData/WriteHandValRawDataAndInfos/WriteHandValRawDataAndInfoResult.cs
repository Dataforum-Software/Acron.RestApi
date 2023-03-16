using Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.WriteHandValRawDataAndInfos
{
   public class WriteHandValRawDataAndInfoResult : IWriteHandValRawDataAndInfoResult
   {
      public WriteHandValRawDataAndInfoResponse Result { get; set; }
   }
}
