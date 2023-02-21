using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawData
{
   [DataContract]
   public class WriteHandValRawDataRequestResource : IWriteHandValRawDataRequestResource<WriteHandValRawDataPVDescription, WriteHandValRawDataProval>
   {
      public WriteHandValRawDataRequestResource() 
      {         
      }

      [DataMember]
      public DateTime DayTimeStamp { get; set; }

      [DataMember]
      public List<WriteHandValRawDataPVDescription> PVDescriptions { get; set; }
   }
}
