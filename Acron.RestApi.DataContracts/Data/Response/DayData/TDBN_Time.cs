using Acron.RestApi.Interfaces.Data.Response.DayData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.DayData
{
   public class TDBN_Time : ITDBN_Time
   {
      public uint Time_T { get; set; }
      public string Time_T_FORMATTED { get; set; }

      public uint Milliseconds { get; set; }
      public string Milliseconds_FORMATTED { get; set; }
   }
}
