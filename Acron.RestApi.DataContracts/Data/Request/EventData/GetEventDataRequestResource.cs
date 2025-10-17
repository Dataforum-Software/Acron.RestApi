using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.EventData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.EventData
{
   [DataContract]
   public class GetEventDataRequestResource : IGetEventDataRequestResource<EventSelectionParameters>
   {
      [DataMember]
      [ObjectId]
      public List<EventSelectionParameters> EventSelectionParameters { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventSortOrder EventsOrder { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public EventSortOrder StepsOrder { get; set; }
   }
}
