using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IWriteProcessDataDescription
   {
      [SwaggerSchema("Numeric ID of external Variable")]
      [SwaggerExampleValue(104000003)]
      public uint ExtVarID { get; set; }

      [SwaggerSchema("Time stamp for value")]
      [SwaggerExampleValue("2020-08-15T01:00:00Z")]
      public DateTimeOffset TimeStamp { get; set; }

      [SwaggerSchema("Data type of value (numeric / alphanumeric)")]
      [SwaggerExampleValue(DataValueTypes.IS_NUM)]
      public DataValueTypes DataValueType { get; set; }

      [SwaggerSchema("Value of external variable at specific point in time")]
      [SwaggerExampleValue(22.5)]
      public object Value { get; set; }

      [SwaggerSchema("Replace value for this time stamp, if it already exists")]
      [SwaggerExampleValue(true)]
      public bool OverWrite { get; set; }

      [SwaggerSchema("Quality of value (e.g. missing value)")]
      [SwaggerExampleValue(DBP_Quality.DBP_QUALITY_NORMAL)]
      public DBP_Quality Quality { get; set; }

      [SwaggerSchema("Type of value (e.g. minimum, mean, current value)")]
      [SwaggerExampleValue(DBP_ValueTypes.DBP_DEVENT_ACT)]
      public DBP_ValueTypes ValueType { get; set; }


      public enum DBP_Quality
      {
         [SwaggerEnumInfo("Normal Value")]
         DBP_QUALITY_NORMAL = 0,

         [SwaggerEnumInfo("Value for this time stamp is missing")]
         DBP_QUALITY_NOVALUE = 1,

         [SwaggerEnumInfo("Value was replaced automatically")]
         DBP_QUALITY_OVERWRITE_AUTO = 2,

         [SwaggerEnumInfo("Value was replaced manually")]
         DBP_QUALITY_OVERWRITE_MAN = 3
      }

      public enum DataValueTypes : byte
      {
         [SwaggerEnumInfo("Value is a numeric value")]
         IS_NUM = 0x0,

         [SwaggerEnumInfo("Value is a alphanumeric value")]
         IS_STRING = 0x2,
         //IS_WRITE_TIME = 0x4,
         //IS_DELETE_TIME = 0x8,
         //IS_DELETE_TIME_ONE = 0x10,
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

}
