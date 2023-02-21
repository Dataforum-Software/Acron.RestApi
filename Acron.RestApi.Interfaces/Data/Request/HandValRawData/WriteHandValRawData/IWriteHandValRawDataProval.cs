using System;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData
{
   public interface IWriteHandValRawDataProval
   {
      public DateTime TimeStamp { get; set; }
      public HandValRawDataProvalTypes ProvalType { get; }
      public short MilliSeconds { get; set; }
      public double Value { get; set; } //Wenn ProvalType = Numeric
      public string StringValue { get; set; } //Wenn ProvalType = Text
   }

   public enum HandValRawDataProvalTypes : short
   {
      Numeric = 0,
      Text = 1,
   }
}
