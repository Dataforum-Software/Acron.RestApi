using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.StringCompData
{
   public interface IGetStringCompDataResultItem
   {
      uint PVID { get; set; }
      public List<string> Values { get; set; }
   }
}
