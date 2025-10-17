using Acron.RestApi.Interfaces.Data.Response.EventData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.EventData
{
   [DataContract]
   public class EventDataCell : IEventDataCell
   {
      [DataMember]
      public string ValueString { get; set; }

      [DataMember]
      public bool IsMarkerSet { get; set; }

      [DataMember]
      public bool IsColorValid { get; set; }

      [DataMember]
      public uint Color { get; set; }

      [DataMember]
      public uint ColorReport { get; set; }
   }
}
