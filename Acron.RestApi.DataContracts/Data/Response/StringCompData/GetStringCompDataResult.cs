using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.StringCompData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.StringCompData
{
   public class GetStringCompDataResult : IGetStringCompDataResult<GetStringCompDataResultItem>
   {
      [FormatDateTimeList(nameof(TimeStamps_FORMATTED), DateTimeFormatType.Default)]
      public List<DateTime> TimeStamps { get; set; }

      public List<string> TimeStamps_FORMATTED { get; set; }

      public List<GetStringCompDataResultItem> Values { get; set; }
   }
}
