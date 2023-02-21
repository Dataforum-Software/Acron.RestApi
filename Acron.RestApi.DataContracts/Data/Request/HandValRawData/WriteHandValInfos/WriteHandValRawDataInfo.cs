using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos;
using System;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValInfos
{
   public class WriteHandValRawDataInfo : IWriteHandValRawDataInfo<WriteHandValRawDataInfoFlag>
   {
      public uint PVID { get; set; }
      public DateTime TimeStamp { get; set; }
      public ushort MilliSeconds { get { return (ushort)TimeStamp.Millisecond; } }
      public WriteHandValRawDataInfoFlag ProInfoFlag { get; set; }
      //public DateTime Edit_TimeStamp { get; set; } /Wird von der RestAPI/DBServer versorgt
      //public string User { get; set; } /Wird von der RestAPI/DBServer versorgt
      public string Key { get; set; }      
   }
}
