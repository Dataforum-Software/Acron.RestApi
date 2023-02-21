using Acron.RestApi.Interfaces.Data.Request.DayData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.DayData
{
   [DataContract]
   public class GetDayDataPVDescription : IGetDayDataPVDescription<DayWhat>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public DayWhat DayWhat { get; set; }
   }
}
