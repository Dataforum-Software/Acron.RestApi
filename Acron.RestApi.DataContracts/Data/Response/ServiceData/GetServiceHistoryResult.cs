using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ServiceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ServiceData
{
   [DataContract]
   public class GetServiceHistoryResult : IGetServiceHistoryResult<ServiceHistoryData, RepairData>
   {
      [DataMember]
      public uint AverageDuration { get; set; }

      [DataMember]
      public uint DurationSum { get; set; }

      [DataMember]
      [FormatDouble(nameof(AverageCost_FORMATTED), ValueFormatType.Currency)]
      public double AverageCost { get; set; }

      [DataMember]
      public string AverageCost_FORMATTED { get; set; }

      [DataMember]
      [FormatDouble(nameof(CostSum_FORMATTED), ValueFormatType.Currency)]
      public double CostSum { get; set; }

      [DataMember]
      public string CostSum_FORMATTED { get; set; }

      [DataMember]
      public List<ServiceHistoryData> Values { get; set; }
   }
}
