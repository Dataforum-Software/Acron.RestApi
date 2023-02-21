using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ProcessData.TData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;
using static Acron.RestApi.Interfaces.Data.Response.ProcessData.TData.ITDataBase;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData.TData
{
   [DataContract]
   public abstract class TDataBase : ITDataBase
   {
      protected TDataBase(DataTypes pDataType)
      {
         DataType = pDataType;
      }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public DataTypes DataType { get; set; }

      [DataMember]
      [FormatDateTime(nameof(TimeStamp_FORMATTED), nameof(TimeStamp_TIMEZONE), DateTimeFormatType.Process)]
      public DateTime TimeStamp { get; set; }

      //ToDo Swagger
      [DataMember]
      public string TimeStamp_FORMATTED { get; set; }

      //ToDo Swagger
      [DataMember]
      public DateTime TimeStamp_TIMEZONE { get; set; }

      [DataMember]
      public ITDataBitArrayBase DataBitArray { get; set; }
   }
}
