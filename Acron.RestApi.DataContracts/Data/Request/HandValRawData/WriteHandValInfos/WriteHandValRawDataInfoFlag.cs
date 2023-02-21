using Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValInfos;

namespace Acron.RestApi.DataContracts.Data.Request.HandValRawData.WriteHandValInfos
{
   public class WriteHandValRawDataInfoFlag : IWriteHandValRawDataInfoFlag
   {
      public bool HDAT_GREATER { get; set; }
      public bool HDAT_LESS { get; set; }
      public bool HDAT_KEYVALID { get; set; }
   }
}
