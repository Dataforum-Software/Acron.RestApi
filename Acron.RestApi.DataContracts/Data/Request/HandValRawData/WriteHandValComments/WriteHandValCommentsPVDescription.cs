using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   public class WriteHandValCommentsPVDescription : IWriteHandValCommentsPVDescription
   {
      public uint PVID { get; set; }
      //public WriteHandValCommentsCDAT CDAT { get; set; } / In CDat sind der User und die TimeStamp der Erfassung. Dies wird von der RestAPI / DBServer versorgt
      public string Comment { get; set; }
   }
}
