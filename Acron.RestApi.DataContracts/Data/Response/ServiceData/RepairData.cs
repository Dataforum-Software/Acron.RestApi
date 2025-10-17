using System;
using Acron.RestApi.Interfaces.Data.Response.ServiceData;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acron.RestApi.Interfaces.Data.Request.ServiceData;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Acron.RestApi.DataContracts.Data.Attributes;

namespace Acron.RestApi.DataContracts.Data.Response.ServiceData
{
   [DataContract]
   public class RepairData : IRepairData
   {
      [DataMember]
      public string ServiceName { get; set; }

      [DataMember]
      public string ServiceId { get; set; }

      [DataMember]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public ServiceHistoryFlags ServiceHistoryFlag { get; set; }

      [DataMember]
      public int RepairType { get; set; }

      [DataMember]
      public int Type { get; set; }

      [DataMember]
      [FormatDateTime(nameof(Time_FORMATTED), DateTimeFormatType.Default)]
      public DateTime Time { get; set; }

      [DataMember]
      public string Time_FORMATTED { get; set; }

      [DataMember]
      public uint OperationTime { get; set; }

      [DataMember]
      public uint RunTime { get; set; }

      [DataMember]
      public uint SwitchingCyclesTime { get; set; }

      [DataMember]
      public uint OperationTimeSum { get; set; }

      [DataMember]
      public uint RunTimeSum { get; set; }

      [DataMember]
      public uint SwitchingCyclesTimeSum { get; set; }

      [DataMember]
      public uint OperationTimeInterval { get; set; }

      [DataMember]
      public uint RunTimeInterval { get; set; }

      [DataMember]
      public uint SwitchingCyclesTimeInterval { get; set; }

      [DataMember]
      [FormatDateTime(nameof(PrintTime_FORMATTED), DateTimeFormatType.Default)]
      public DateTime PrintTime { get; set; }

      [DataMember]
      public string PrintTime_FORMATTED { get; set; }

      [DataMember]
      public string User { get; set; }

      [DataMember]
      public string Comment1 { get; set; }

      [DataMember]
      public string Comment2 { get; set; }

      [DataMember]
      public string Comment3 { get; set; }

      [DataMember]
      public string Document1 { get; set; }

      [DataMember]
      public string Document2 { get; set; }

      [DataMember]
      public string Document3 { get; set; }

      [DataMember]
      public uint MaintenanceDuration { get; set; }

      [DataMember]
      public double Cost { get; set; }

      [DataMember]
      public string Cost_FORMATTED { get; set; }
   }
}
