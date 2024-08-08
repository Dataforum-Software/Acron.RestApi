using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Common.Response.LicenseOverview
{
   public interface IAcLicenceOverviewPlantProcessesResponse<T> where T : IAcLicenceOverviewPlantProcess
   {
      [SwaggerSchema("List of plant process results")]
      [SwaggerExampleValue(typeof(IAcLicenceOverviewPlantProcess))]
      List<T> Processes { get; }

      [SwaggerSchema("Last time the processes list was refreshed")]
      [SwaggerExampleValue("2024-06-17T08:31:19+02:00")]
      DateTime ProcessesListRefreshTimeStamp { get; }

      [SwaggerSchema($"{nameof(ProcessesListRefreshTimeStamp)} formatted according to 'Culture' Header")]
      [SwaggerExampleValue("2024-06-17T07:22:37")]
      string ProcessesListRefreshTimeStamp_FORMATTED { get; }
   }
}
