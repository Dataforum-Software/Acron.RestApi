using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.LicenseOverview
{
   public interface IAcLicenseOverviewResponse
   {
      [SwaggerSchema("Last time the license was read")]
      [SwaggerExampleValue("2024-06-17T08:31:19+02:00")]
      DateTime LastLicenseReadTimeStamp { get; }

      [SwaggerSchema($"{nameof(LastLicenseReadTimeStamp)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string LastLicenseReadTimeStamp_FORMATTED { get; }

      [SwaggerSchema("Last time a workload on a plant licensed by this license occurred      ,")]
      [SwaggerExampleValue("2024-06-17T08:31:19+02:00")]
      DateTime LastLicenseWorkloadTimeStamp { get; }

      [SwaggerSchema($"{nameof(LastLicenseWorkloadTimeStamp)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string LastLicenseWorkloadTimeStamp_FORMATTED { get; }

      [SwaggerSchema("Last time the license was read")]
      [SwaggerExampleValue("2024-06-17T08:31:19+02:00")]
      string LicenseType { get; }

      [SwaggerSchema("Unique license number")]
      [SwaggerExampleValue(53146)]
      uint LicenseNumber { get; }

      [SwaggerSchema("Amount of licensed clients")]
      [SwaggerExampleValue(6)]
      uint LicensedClients { get; }

      [SwaggerSchema("Amount of used clients")]
      [SwaggerExampleValue(4)]
      uint UsedClients { get; }

      [SwaggerSchema("Amount of reserved REST API clients")]
      [SwaggerExampleValue(5)]
      uint FixedRestAPIClients { get; }

      [SwaggerSchema("Amount of licensed process variables")]
      [SwaggerExampleValue(3)]
      string LicensedProcessVariables { get; }

      [SwaggerSchema("Amount of used process variables")]
      [SwaggerExampleValue(3)]
      uint UsedProcessvariables { get; }

      [SwaggerSchema("Licensed acron version")]
      [SwaggerExampleValue(10.1)]
      string LicensedVersion { get; }

      [SwaggerSchema("Flag which represents whether the service and alert modules are licensed")]
      [SwaggerExampleValue(true)]
      bool ServiceAndAlertLicensed { get; }

      [SwaggerSchema("Flag which represents whether the mirror module is licensed")]
      [SwaggerExampleValue(true)]
      bool MirrorLicensed { get; }

      [SwaggerSchema("Flag which represents whether the mirror module is licensed")]
      [SwaggerExampleValue(true)]
      DateTime ExpirationDate { get; }

      [SwaggerSchema($"{nameof(ExpirationDate)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string ExpirationDate_FORMATTED { get; }

   }
}
