using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Request.ProcessData
{
   public interface IWriteProcessDataDescription
   {
      public uint ExtVarID { get; set; }
      public DateTimeOffset TimeStamp { get; set; }
      public DataValueTypes DataValueType { get; set; }
      public object Value { get; set; }

      public bool OverWrite { get; set; }
      public DBP_Quality Quality { get; set; }
      public DBP_ValueTypes ValueType { get; set; }


      public enum DBP_Quality
      {
         DBP_QUALITY_NORMAL = 0,
         DBP_QUALITY_NOVALUE = 1,
         DBP_QUALITY_OVERWRITE_AUTO = 2,
         DBP_QUALITY_OVERWRITE_MAN = 3
      }

      public enum DataValueTypes : byte
      {
         IS_NUM = 0x0,
         IS_STRING = 0x2,
         //IS_WRITE_TIME = 0x4,
         //IS_DELETE_TIME = 0x8,
         //IS_DELETE_TIME_ONE = 0x10,
      }

      public enum DBP_ValueTypes
      {
         DBP_CYCLIC_MIN = 0,      // Der Wert ist ein Minimum
         DBP_CYCLIC_MAX = 1,      // Der Wert ist ein Maximum
         DBP_CYCLIC_MEAN = 2,     // Der Wert ist ein Mittelwert
         DBP_DEVENT_ACT = 3      // Der Wert ist ein Momentanwert
      }
   }

}
