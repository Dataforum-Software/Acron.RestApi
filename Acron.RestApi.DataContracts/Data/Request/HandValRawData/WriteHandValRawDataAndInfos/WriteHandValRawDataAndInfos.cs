using Acron.RestApi.DataContracts.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawDataAndInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValRawDataAndInfos
{
   public class WriteHandValRawDataAndInfos : IWriteHandValRawDataAndInfos<WriteHandValRawDataAndInfoFlag>
   {
      public DateTime TimeStamp { get; set; }
      public WriteHandValRawDataAndInfoTypes ProvalType { get; private set; }
      public short MilliSeconds { get; set; }

      private double _value = GlobalDataDef.NO_VALID;
      public double Value 
      {
         get { return _value; }
         set { _value = value; ProvalType = WriteHandValRawDataAndInfoTypes.Numeric; }
      }

      private string _stringValue = string.Empty;
      public string StringValue 
      {
         get { return _stringValue; }
         set { _stringValue = value; ProvalType = WriteHandValRawDataAndInfoTypes.Text; }
      }

      public WriteHandValRawDataAndInfoFlag ProInfoFlag { get; set; }
      public string Key { get; set; }
   }
}
