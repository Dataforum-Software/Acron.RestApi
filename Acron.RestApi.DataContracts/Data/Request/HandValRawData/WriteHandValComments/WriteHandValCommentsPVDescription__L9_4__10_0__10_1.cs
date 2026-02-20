using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   [DataContract]
   public class WriteHandValCommentsPVDescription__L9_4__10_0__10_1 : IWriteHandValCommentsPVDescription__L9_4__10_0__10_1
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string Comment { get; set; }
   }
}
