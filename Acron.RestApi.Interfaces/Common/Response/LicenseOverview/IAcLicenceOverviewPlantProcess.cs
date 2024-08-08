using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Acron.RestApi.Interfaces.BaseObjects.BaseObjectDefines;

namespace Acron.RestApi.Interfaces.Common.Response.LicenseOverview
{
   public interface IAcLicenceOverviewPlantProcess
   {
      [SwaggerSchema("FQDN and IP adress of the process")]
      [SwaggerExampleValue("MyPC 127.0.0.1")]
      string Adress { get; }

      [SwaggerSchema("Name of the process")]
      [SwaggerExampleValue("Visu on MyPC")]
      string ClientName { get; }

      [SwaggerSchema("Start time of the process")]
      [SwaggerExampleValue("2024-06-17T07:22:37+02:00")]
      DateTime ProcessSessionStartTimeStamp { get; }

      [SwaggerSchema($"{nameof(ProcessSessionStartTimeStamp)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string ProcessSessionStartTimeStamp_FORMATTED { get; }

      [SwaggerSchema("ID of the terminal server which the process is connected to")]
      [SwaggerExampleValue("15539326718939894481")]
      uint TerminalServerSessionID { get; }
   }
}
