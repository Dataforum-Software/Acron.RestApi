namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValRawData
{
   public interface IWriteHandValRawDataResult
   {
      WriteHandValRawDataResults Result { get; set; }
   }

   public enum WriteHandValRawDataResults
   {
      GENERAL_ERROR = -2,
      MV_VGHANDBUSY = -1,
      OK = 0,
      UNKNOWN = int.MaxValue,
   }

}
