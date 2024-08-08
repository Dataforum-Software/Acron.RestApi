using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.LicenseOverview
{
   public interface IAcLicenceOverviewPlantsResponse
   {
      [SwaggerSchema("Unique plant name")]
      [SwaggerExampleValue("Plant1")]
      string PlantShortName { get; }

      [SwaggerSchema("Last refresh time of plant data")]
      [SwaggerExampleValue("2024-06-17T07:22:37+02:00")]
      DateTime LastRefreshTime { get; }

      [SwaggerSchema($"{nameof(LastRefreshTime)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string LastRefreshTime_FORMATTED { get; }

      [SwaggerSchema("Type of used licensing process")]
      [SwaggerExampleValue("Local")]
      LicenseLoginMode LoginMode { get; }

      [SwaggerSchema("Port of the plants DBServer")]
      [SwaggerExampleValue("3993")]
      uint Port { get; }

      [SwaggerSchema("ID of the plants terminal server")]
      [SwaggerExampleValue("15539326718939894481")]
      ulong ServerID { get; }

      [SwaggerSchema("Amount of used REST API clients")]
      [SwaggerExampleValue(7)]
      uint UsedClients { get; }

      [SwaggerSchema("Amount of reserved REST API clients")]
      [SwaggerExampleValue(5)]
      uint FixedRestApiClients { get; }

      [SwaggerSchema("Amount of used frontend clients")]
      [SwaggerExampleValue(5)]
      uint UsedFrontendClients { get; }

      [SwaggerSchema("Amount of used frontend clients on mirrored plant")]
      [SwaggerExampleValue(3)]
      uint UsedFrontendClientsOnMirror { get; }

      [SwaggerSchema("Amount of used process variables")]
      [SwaggerExampleValue(3)]
      uint UsedProcessVariables { get; }
   }

   public enum LicenseLoginMode : byte
   {
      Local = 1,  //Lizenz wird lokal bezogen
      DBServer = 2,  //Lizenz wird vom DBServer bezogen
      FirstLocalThenDBServer = 3,  //Lizenz wird versucht erst lokal zu beziehen, dann vom DBServer
   }

}
