using Acron.RestApi.Interfaces.Data.Response.EventData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.EventData
{
   [DataContract]
   public class EventCell : IEventCell
   {
      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventCellKeys EventCellKey { get; set; }

      [DataMember]
      public ushort Row { get; set; }

      [DataMember]
      public ushort Column { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventCellTypes CellType { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ID_GEN_TYPE IdGenType { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ProcessVariableValueTypes PvValueType { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventCellFlags CellFlag { get; set; }

      [DataMember]
      public string Contents { get; set; }
   }
}
