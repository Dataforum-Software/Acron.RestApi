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
   public class AcLicenceOverviewPlantProcess : IAcLicenceOverviewPlantProcess
   {
      [DataMember]
      public string Adress { get; set; }

      [DataMember]
      public string ClientName { get; set; }

      [DataMember]
      [FormatDateTime(nameof(ProcessSessionStartTimeStamp_FORMATTED))]
      public DateTime ProcessSessionStartTimeStamp { get; set; }

      [DataMember]
      public string ProcessSessionStartTimeStamp_FORMATTED { get; set; }

      [DataMember]
      public uint TerminalServerSessionID { get; set; }


   }
}
