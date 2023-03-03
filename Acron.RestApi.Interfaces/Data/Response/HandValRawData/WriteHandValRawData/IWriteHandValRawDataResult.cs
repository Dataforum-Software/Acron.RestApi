using Acron.RestApi.Interfaces.Data.Response.DayData;
using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValRawData
{
   public interface IWriteHandValRawDataResult
   {
      [SwaggerSchema($"Return code of operation. " +
         $"A result of {nameof(WriteHandValRawDataResults.MV_VGHANDBUSY)} signifies, that the Database Engine is not running" +
         $"and the Database Server has exceeded its data buffer.")]
      [SwaggerExampleValue(WriteHandValRawDataResults.OK)]
      WriteHandValRawDataResults Result { get; set; }
   }

   public enum WriteHandValRawDataResults
   {
      [SwaggerEnumInfo("A general error of unspecified nature occured")]
      GENERAL_ERROR = -2,

      [SwaggerEnumInfo("The Database Engine is not running and the Database Server has exceeded its data buffer")]
      MV_VGHANDBUSY = -1,

      [SwaggerEnumInfo("Operation was sucessful")]
      OK = 0,

      [SwaggerEnumInfo("Operation returned undefined result")]
      UNKNOWN = int.MaxValue,
   }

}
