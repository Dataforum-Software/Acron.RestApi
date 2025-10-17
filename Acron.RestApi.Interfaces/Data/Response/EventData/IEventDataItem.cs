using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.EventData
{
    public interface IEventDataItem<U> where U : IEventDataCell
    {
      [SwaggerSchema("Column number of the item")]
      [SwaggerExampleValue(1)]
      int Column { get; set; }

      [SwaggerSchema("Type of data item")]
      [SwaggerExampleValue(0)]
      int Type { get; set; }

      [SwaggerSchema("Type of data item")]
      [SwaggerExampleValue(0)]
      int DataType { get; set; }

      [SwaggerSchema("Type of data item")]
      [SwaggerExampleValue(ProcessVariableValueTypes.VG_DDAT_DTIME)]
      ProcessVariableValueTypes ValueType { get; set; }

      [SwaggerSchema("Cell count of the item")]
      [SwaggerExampleValue(EventCellKeys.CELLKEY_START)]
      public long CellCount { get; set; }

      [SwaggerSchema("Column cell objects")]
      [SwaggerExampleValue(typeof(IEventDataCell))]
      List<U> ColumnCells { get; set; }

   }
}
