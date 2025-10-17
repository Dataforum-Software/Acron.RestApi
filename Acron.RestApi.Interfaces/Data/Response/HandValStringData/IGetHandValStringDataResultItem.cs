using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.HandValStringData
{
   public interface IGetHandValStringDataResultItem
   {
      [SwaggerSchema("Numeric ID of process variable")]
      [SwaggerExampleValue(302000001)]
      int PVId { get; set; }

      [SwaggerSchema("Unique identification of process variable")]
      [SwaggerExampleValue("gro_e_inspektion")]
      string ShortName { get; set; }

      [SwaggerSchema("Value kind of each value")]
      [SwaggerExampleValue(CDAT_Kind.CDAT_REMVG)]
      List<CDAT_Kind> KindValues { get; set; }

      [SwaggerSchema("String values of process variable")]
      [SwaggerExampleValue(new string[] { "Wetterbericht" })]
      List<string> StringValues { get; set; }

      [SwaggerSchema("Editing time of each value")]
      [SwaggerExampleValue(new string[] { "2023-12-10T13:49:51Z" })]
      List<DateTime> TimeStampsEdit { get; set; }

      [SwaggerSchema($"{nameof(TimeStampsEdit)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue(new string[] { "10.12.2023 13:49:51" })]
      List<string> TimeStampsEdit_FORMATTED { get; set; }

      [SwaggerSchema("User name of the acron user that entered each value")]
      [SwaggerExampleValue(new string[] { "acron" })]
      List<string> UserValues { get; set; }
   }
}
