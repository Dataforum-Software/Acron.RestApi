using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData
{

   public interface IWriteHandValRawDataPVDescription<ProvalType> where ProvalType : IWriteHandValRawDataProval
   {
      public uint PVID { get; set; }
      public List<ProvalType> Provals { get; set; }
   }
}
