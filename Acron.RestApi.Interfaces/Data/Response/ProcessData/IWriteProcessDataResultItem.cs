using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface IWriteProcessDataResultItem
   {
      public DateOnly Day { get; set; }
      public WriteProcessDataErrors Result { get; set; }
   }

   public enum WriteProcessDataErrors : short
   {
      OK = 0,
      GeneralError = -1,
      Unknown = short.MinValue,
   }

}
