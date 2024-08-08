using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Common.Response.LicenseOverview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.LicenseOverview
{
   [DataContract]
   public class AcLicenceOverviewPlantProcessesResponse : IAcLicenceOverviewPlantProcessesResponse<AcLicenceOverviewPlantProcess>
   {
      [DataMember]
      public List<AcLicenceOverviewPlantProcess> Processes { get; set; }

      [DataMember]
      [FormatDateTime(nameof(ProcessesListRefreshTimeStamp_FORMATTED))]
      public DateTime ProcessesListRefreshTimeStamp { get; set; }

      [DataMember]
      public string ProcessesListRefreshTimeStamp_FORMATTED { get; set; }
   }
}
