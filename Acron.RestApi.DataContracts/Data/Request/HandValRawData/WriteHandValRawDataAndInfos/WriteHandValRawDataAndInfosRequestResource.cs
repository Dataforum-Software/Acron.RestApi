using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   [DataContract]
   public class WriteHandValRawDataAndInfosRequestResource : IWriteHandValRawDataAndInfosRequestResource<WriteHandValRawDataAndInfosPVDescription, WriteHandValRawDataAndInfos, WriteHandValRawDataAndInfoFlag>
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
      public List<WriteHandValRawDataAndInfosPVDescription> PVDescriptions { get; set; }
   }
}
