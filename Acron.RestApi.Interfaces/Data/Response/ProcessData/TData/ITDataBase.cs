using System;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataBase
   {
      DataTypes DataType { get; set; }
      DateTime TimeStamp { get; set; }

      //ToDo Swagger
      string TimeStamp_FORMATTED { get; set; }

      //ToDo Swagger
      DateTime TimeStamp_TIMEZONE { get; set; }
      ITDataBitArrayBase DataBitArray { get; set; }


      public enum DataTypes
      {
         Numeric,
         String,
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
