using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValInfos
{
   public class WriteHandValRawDataInfo : IWriteHandValRawDataInfo<WriteHandValRawDataInfoFlag>
   {
      public uint PVID { get; set; }

      [DataMember]
      public DateTimeOffset TimeStamp { get; set; }
      public DateTime TimeStamp_UTC 
      {
         get
         {
            return TimeStamp.UtcDateTime;
         }
      }

      public ushort MilliSeconds { get { return (ushort)TimeStamp.Millisecond; } }
      public WriteHandValRawDataInfoFlag ProInfoFlag { get; set; }
      public string Key { get; set; }      
   }
}
