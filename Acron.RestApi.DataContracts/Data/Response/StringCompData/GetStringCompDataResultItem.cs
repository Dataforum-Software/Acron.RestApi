using Acron.RestApi.Interfaces.Data.Response.StringCompData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.StringCompData
{
   public class GetStringCompDataResultItem : IGetStringCompDataResultItem
   {
      public uint PVID { get; set; }
      public List<string> Values { get; set; }
   }
}
