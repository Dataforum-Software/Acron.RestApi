namespace Acron.RestApi.Interfaces.Data.Request.IntervalData
{
   public interface IGetIntervalDataPVDescription<T> where T : IIntervalWhat
   {
      uint PVID { get; set; }
      T IntervalWhat { get; set; }
   }
}
