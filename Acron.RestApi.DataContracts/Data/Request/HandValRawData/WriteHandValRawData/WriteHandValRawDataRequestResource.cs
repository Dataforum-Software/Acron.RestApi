using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawData
{
   [DataContract]
   public class WriteHandValRawDataRequestResource : IWriteHandValRawDataRequestResource<WriteHandValRawDataPVDescription, WriteHandValRawDataProval>
   {
      [DataMember]
      public DateTimeOffset DayTimeStamp { get; set; }
      public DateTime DayTimeStamp_UTC 
      {
         get
         {
            return DayTimeStamp.UtcDateTime;
         }
      }

      [DataMember]
      [ObjectId]
      public List<WriteHandValRawDataPVDescription> PVDescriptions { get; set; }
   }
}
