using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments;
using Acron.RestApi.Interfaces.Data.Request.HandValStringData;
using Acron.RestApi.Interfaces.Data.Request.WriteHandValStringData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.WriteHandValStringData
{
   [DataContract]
   public class WriteHandValStringDataRequestResource : IWriteHandValStringDataRequestResource<WriteCommentsPVDescription>
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public HandValStringDataKind DataKind { get; set; }

      [DataMember]
      public DateTimeOffset TimeStamp { get; set; }

      public DateTime TimeStamp_UTC
      {
         get
         {
            return TimeStamp.UtcDateTime;
         }
      }

      [DataMember]
      [ObjectId]
      public List<WriteCommentsPVDescription> PVDescriptions { get; set; }
   }
}
