using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.EventData
{
    public interface IEventCell
    {
      [SwaggerSchema("Key of the cell")]
      [SwaggerExampleValue(EventCellKeys.CELLKEY_START)]
      EventCellKeys EventCellKey { get; set; }

      [SwaggerSchema("Row of the cell")]
      [SwaggerExampleValue(1)]
      ushort Row { get; set; }

      [SwaggerSchema("Column of the cell")]
      [SwaggerExampleValue(2)]
      ushort Column { get; set; }

      [SwaggerSchema("Type of the cell")]
      [SwaggerExampleValue(EventCellTypes.CELL_TIME)]
      EventCellTypes CellType { get; set; }

      [SwaggerSchema("Source of the events id")]
      [SwaggerExampleValue(ID_GEN_TYPE.ID_BHAND)]
      ID_GEN_TYPE IdGenType { get; set; }

      [SwaggerSchema("Process variable value type of the cell")]
      [SwaggerExampleValue(ProcessVariableValueTypes.VG_IDAT_PMIN)]
      ProcessVariableValueTypes PvValueType { get; set; }

      [SwaggerSchema("Cell flag")]
      [SwaggerExampleValue(EventCellFlags.CELL_REPLACED)]
      EventCellFlags CellFlag { get; set; }

      [SwaggerSchema("Contents of the cell")]
      [SwaggerExampleValue("This is content.")]
      string Contents { get; set; }





   }
}
