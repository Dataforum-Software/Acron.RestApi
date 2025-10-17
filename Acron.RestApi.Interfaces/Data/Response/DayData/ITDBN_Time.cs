using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.DayData
{
   public interface ITDBN_Time
   {
      uint Time_T { get; set; }
      string Time_T_FORMATTED { get; set; }

      uint Milliseconds { get; set; }
      string Milliseconds_FORMATTED { get; set; }
   }
}
