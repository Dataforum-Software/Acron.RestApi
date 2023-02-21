using System;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData
{
   public interface IGetHandValRawDataValue
    {
        public DateTime TimeStamp { get; set; }
        public HandValRawDataProvalTypes ProvalType { get; set; }
        public short MilliSec { get; set; }
        public double NumValue { get; set; }
        public string TextValue { get; set; }

        public string AlphaNumericValue { get; set; }
        public IGetHandValRawDataFlag ValuesFlag { get; set; }
        public DateTime InputTimeHandVal { get; set; }
        public string InputUserHandVal { get; set; }
        public string OptionalInputKey { get; set; }
    }

    public enum HandValRawDataProvalTypes : short
    {
        Numeric = 0,
        Text = 1,
    }

}
