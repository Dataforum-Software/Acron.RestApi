using Acron.RestApi.Interfaces.Data.Request.IntervalData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.IntervalData
{
   [DataContract]
   public class GetIntervalDataPVDescription : IGetIntervalDataPVDescription<IntervalWhat>
   {
      [DataMember]
      public uint PVID {get; set;}

      [DataMember]
      public IntervalWhat IntervalWhat { get; set; }
   }
}
