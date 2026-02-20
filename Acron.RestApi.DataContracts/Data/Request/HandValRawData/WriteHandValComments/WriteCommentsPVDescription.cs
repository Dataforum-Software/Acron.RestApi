using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValComments;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValComments
{
   [DataContract]
   public class WriteCommentsPVDescription : IWriteCommentsPVDescription
   {
      [DataMember]
      public uint PVID { get; set; }

      [DataMember]
      public string Comment { get; set; }
   }
}
