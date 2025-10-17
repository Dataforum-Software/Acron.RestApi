using Acron.RestApi.Interfaces.Data.Response.EventData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.EventData
{
   public class EventDataItem : IEventDataItem<EventDataCell>
   {
      public int Column { get; set; }
      public int Type { get; set; }
      public int DataType { get; set; }
      public ProcessVariableValueTypes ValueType { get; set; }
      public long CellCount { get; set; }
      public List<EventDataCell> ColumnCells { get; set; }
   }
}
