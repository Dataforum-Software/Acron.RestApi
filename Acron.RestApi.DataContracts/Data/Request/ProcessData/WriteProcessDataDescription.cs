using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{
   [DataContract]
   public class WriteProcessDataDescription : IWriteProcessDataDescription
   {
      [DataMember]
      [Required]
      public uint ExtVarID { get; set; }

      [DataMember]
      [Required]
      [RequestTimeStampValidator]
      public DateTimeOffset TimeStamp { get; set; }
      public DateTimeOffset TimeStamp_UTC
      {
         get { return TimeStamp.UtcDateTime; }
      }

      [DataMember]
      [Required]
      [JsonConverter(typeof(StringEnumConverter))]
      public IWriteProcessDataDescription.DataValueTypes DataValueType { get; set; }

      [DataMember]
      [Required]
      public object Value { get; set; }

      [DataMember]
      public bool OverWrite { get; set; } = false;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public IWriteProcessDataDescription.DBP_Quality Quality { get; set; } = IWriteProcessDataDescription.DBP_Quality.DBP_QUALITY_NORMAL;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public IWriteProcessDataDescription.DBP_ValueTypes ValueType { get; set; } = IWriteProcessDataDescription.DBP_ValueTypes.DBP_DEVENT_ACT;
   }
}
