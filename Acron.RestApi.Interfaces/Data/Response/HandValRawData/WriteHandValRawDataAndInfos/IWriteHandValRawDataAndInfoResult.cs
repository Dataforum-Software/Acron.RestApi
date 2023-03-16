using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValRawDataAndInfos
{
   public interface IWriteHandValRawDataAndInfoResult
   {
      [SwaggerSchema($"Return code of operation. " +
   $"A result of {nameof(WriteHandValRawDataAndInfoResponse.MV_VGHANDBUSY)} signifies, that the Database Engine is not running" +
   $"and the Database Server has exceeded its data buffer.")]
      [SwaggerExampleValue(WriteHandValRawDataAndInfoResponse.OK)]
      WriteHandValRawDataAndInfoResponse Result { get; set; }

   }

   public enum WriteHandValRawDataAndInfoResponse
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
