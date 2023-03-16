using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   [DataContract]
   public class TDataBase : ITDataBase<TDataBitArrayNum, TDataBitArrayString>
   {
      [DataMember]
      [JsonProperty(Order = 1)]
      [JsonConverter(typeof(StringEnumConverter))]
      [DefaultValue(-1)]
      public DataTypes DataType { get; set; }

      [DataMember]
      [JsonProperty(Order = 2)]
      [FormatDateTime(nameof(TimeStamp_FORMATTED), DateTimeFormatType.Process)]
      public DateTime TimeStamp { get; set; }      

      [DataMember]
      [JsonProperty(Order = 3)]
      public string TimeStamp_FORMATTED { get; set; }


      #region if DataType == DataTypes.Numeric
      [DataMember]
      [JsonProperty(Order = 4)]
      [FormatDoubleMarker(nameof(Value_FORMATTED), ValueFormatType.Process)]
      public double Value { get; set; }

      [DataMember]
      [JsonProperty(Order = 5)]
      public string Value_FORMATTED { get; set; }

      [DataMember]
      [JsonProperty(Order = 6)]
      public TDataBitArrayNum ValueDataBitArray { get; set; }
      #endregion if DataType == DataTypes.Numeric



      #region if DataType == DataTypes.String
      [DataMember]
      [JsonProperty(Order = 7)]
      public string StringValue { get; set; }

      [DataMember]
      [JsonProperty(Order = 8)]
      public TDataBitArrayString StringValueDataBitArray { get; set; }
      #endregion if DataType == DataTypes.String

   }
}
