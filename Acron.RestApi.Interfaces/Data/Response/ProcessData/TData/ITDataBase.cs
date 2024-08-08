using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataBase<ValueDataBitArrayType,StringValueDataBitArrayType> where ValueDataBitArrayType : ITDataBitArrayNum
                                                                                  where StringValueDataBitArrayType : ITDataBitArrayString
   {
      [SwaggerSchema("Data type (Numeric / Text)")]
      [SwaggerExampleValue(DataTypes.Numeric)]
      public DataTypes DataType { get; set; }

      [SwaggerSchema("Time stamp of this process value")]
      [SwaggerExampleValue("2022-10-10T21:44:59")]
      public DateTime TimeStamp { get; set; }

      [SwaggerSchema($"{nameof(TimeStamp)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("10.10.2022 21:44:59")]
      public string TimeStamp_FORMATTED { get; set; }


      #region if DataType == DataTypes.Numeric
      [SwaggerSchema("Numeric value")]
      [SwaggerExampleValue(10.0)]
      public double Value { get; set; }

      [SwaggerSchema("Numeric value formatted or value key")]
      [SwaggerExampleValue("10,0")]
      public string Value_FORMATTED { get; set; }

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue(typeof(ITDataBitArrayNum))]
      public ValueDataBitArrayType ValueDataBitArray { get; set; }
      #endregion if DataType == DataTypes.Numeric



      #region if DataType == DataTypes.String
      [SwaggerSchema("Text value")]
      [SwaggerExampleValue("Rainy")]
      public string StringValue { get; set; }

      [SwaggerSchema("Extended properties of this value")]
      [SwaggerExampleValue(typeof(ITDataBitArrayString))]
      public StringValueDataBitArrayType StringValueDataBitArray { get; set; }
      #endregion if DataType == DataTypes.String
   }

   public enum DataTypes
   {
      [SwaggerEnumInfo("Value is a numeric value")]
      Numeric,

      [SwaggerEnumInfo("Value is a alphanumeric value")]
      String,
   }

   public enum DBP_ValueTypes
   {
      [SwaggerEnumInfo("Value is a minimum value")]
      DBP_CYCLIC_MIN = 0,      // Der Wert ist ein Minimum

      [SwaggerEnumInfo("Value is a maximum value")]
      DBP_CYCLIC_MAX = 1,      // Der Wert ist ein Maximum

      [SwaggerEnumInfo("Value is a mean value")]
      DBP_CYCLIC_MEAN = 2,     // Der Wert ist ein Mittelwert

      [SwaggerEnumInfo("Value is a actual event value")]
      DBP_DEVENT_ACT = 3      // Der Wert ist ein Momentanwert
   }

}
