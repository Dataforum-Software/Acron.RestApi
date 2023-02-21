using Acron.RestApi.DataContracts.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData;
using System;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawData
{
   public class WriteHandValRawDataProval : IWriteHandValRawDataProval
   {
      public DateTime TimeStamp { get; set; }
      public HandValRawDataProvalTypes ProvalType { get; private set; }
      public short MilliSeconds { get; set; }
      private double _value = GlobalDataDef.NO_VALID;
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
