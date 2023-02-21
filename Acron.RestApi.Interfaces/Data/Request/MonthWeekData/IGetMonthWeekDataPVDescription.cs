namespace Acron.RestApi.Interfaces.Data.Request.MonthWeekData
{
   public interface IGetMonthWeekDataPVDescription<T> where T : IMonthWeekWhat
   {
      uint PVID { get; set; }
      T MonthWeekWhat { get; set; }
   }
}
