using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace Acron.RestApi.Interfaces.Data.Request.HandValRawData.WriteHandValRawData
{

   public interface IWriteHandValRawDataPVDescription<ProvalType> where ProvalType : IWriteHandValRawDataProval
   {

      [SwaggerSchema("Identification of Process Variable")]
      [SwaggerExampleValue(302000003)]
      public uint PVID { get; set; }

      [SwaggerSchema("List of process values")]
      [SwaggerExampleValue(typeof(IWriteHandValRawDataPVDescription<IWriteHandValRawDataProval>))]
      public List<ProvalType> Provals { get; set; }
   }
}
