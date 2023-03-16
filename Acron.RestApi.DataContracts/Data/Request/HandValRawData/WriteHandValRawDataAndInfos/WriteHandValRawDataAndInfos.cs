using Acron.RestApi.DataContracts.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   [DataContract]
   public class WriteHandValRawDataAndInfos : IWriteHandValRawDataAndInfos<WriteHandValRawDataAndInfoFlag>
   {
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
      [JsonConverter(typeof(StringEnumConverter))]
      public WriteHandValRawDataAndInfoTypes ProvalType { get; private set; }

      [DataMember]
      public short MilliSeconds { get { return (short)TimeStamp.Millisecond; } }

      private double _value = GlobalDataDef.NO_VALID;
      [DataMember]
      public double Value 
      {
         get { return _value; }
         set { _value = value; ProvalType = WriteHandValRawDataAndInfoTypes.Numeric; }
      }

      private string _stringValue = string.Empty;
      [DataMember]
      public string StringValue 
      {
         get { return _stringValue; }
         set { _stringValue = value; ProvalType = WriteHandValRawDataAndInfoTypes.Text; }
      }

      [DataMember]
      public WriteHandValRawDataAndInfoFlag ProInfoFlag { get; set; }

      [DataMember]
      public string Key { get; set; }
   }
}
