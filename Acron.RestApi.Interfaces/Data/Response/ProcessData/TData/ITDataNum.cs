namespace Acron.RestApi.Interfaces.Data.Response.ProcessData.TData
{
   public interface ITDataNum : ITDataBase
   {
      double Value { get; set; }
      string Value_FORMATTED { get; set; }
   }
}
