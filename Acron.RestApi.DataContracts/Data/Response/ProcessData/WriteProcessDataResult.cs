using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{
   public class WriteProcessDataResult : IWriteProcessDataResult<WriteProcessDataResultItem>
   {
      public List<WriteProcessDataResultItem> ResultItems { get; set; } = new List<WriteProcessDataResultItem>();
   }
}
