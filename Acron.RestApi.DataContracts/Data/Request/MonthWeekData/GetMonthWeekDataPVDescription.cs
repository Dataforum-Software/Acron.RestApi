using Acron.RestApi.Interfaces.Data.Request.MonthWeekData;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.MonthWeekData
{
   [DataContract]
   public class GetMonthWeekDataPVDescription : IGetMonthWeekDataPVDescription<MonthWeekWhat>
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public MonthWeekWhat MonthWeekWhat { get; set; }
   }
}
