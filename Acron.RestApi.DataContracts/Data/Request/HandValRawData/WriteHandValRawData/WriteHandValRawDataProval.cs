using Acron.RestApi.DataContracts.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawData
{
   [DataContract]
   public class WriteHandValRawDataProval : IWriteHandValRawDataProval
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

      public HandValRawDataProvalTypes ProvalType { get; private set; }

      [DataMember]
      public short MilliSeconds { get; set; }

      private double _value = GlobalDataDef.NO_VALID;

      [DataMember]
      public double Value 
      {
         get { return _value; }
         set 
         { 
            _value = value;
            ProvalType = HandValRawDataProvalTypes.Numeric;
         }
      }

      private string _stringValue = string.Empty;

      [DataMember]
      public string StringValue 
      {
         get { return _stringValue; }
         set 
         { 
            _stringValue = value;
            ProvalType = HandValRawDataProvalTypes.Text;
         }
      }
   }
}
