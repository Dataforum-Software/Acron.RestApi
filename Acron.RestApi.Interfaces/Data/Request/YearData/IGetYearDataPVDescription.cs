namespace Acron.RestApi.Interfaces.Data.Request.YearData
{
   public interface IGetYearDataPVDescription<T> where T : IYearWhat
   {
      uint PVID { get; set; }
      T YearWhat { get; set; }
   }
}
