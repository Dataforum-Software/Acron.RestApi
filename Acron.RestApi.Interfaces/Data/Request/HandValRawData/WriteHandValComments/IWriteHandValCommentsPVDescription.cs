namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments
{
   public interface IWriteHandValCommentsPVDescription
   {
      public uint PVID { get; set; }
      //public T CDAT { get; set; } / In CDat sind der User und die TimeStamp der Erfassung. Dies wird von der RestAPI / DBServer versorgt
      public string Comment { get; set; }
   }
}
