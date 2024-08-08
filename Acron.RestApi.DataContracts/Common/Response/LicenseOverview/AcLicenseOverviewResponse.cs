using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Common.Response.LicenseOverview;
using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Response.LicenseOverview
{
   [DataContract]
   public class AcLicenseOverviewResponse : IAcLicenseOverviewResponse
   {
      [DataMember]
      [FormatDateTime(nameof(LastLicenseReadTimeStamp_FORMATTED))]
      public DateTime LastLicenseReadTimeStamp { get; set; }

      [DataMember]
      public string LastLicenseReadTimeStamp_FORMATTED { get; set; }

      [DataMember]
      [FormatDateTime(nameof(LastLicenseWorkloadTimeStamp_FORMATTED))]
      public DateTime LastLicenseWorkloadTimeStamp { get; set; }

      [DataMember]
      public string LastLicenseWorkloadTimeStamp_FORMATTED { get; set; }

      [DataMember]
      public string LicenseType { get; set; }

      [DataMember]
      public uint LicenseNumber { get; set; }

      [DataMember]
      public string LicensedVersion { get; set; }

      [DataMember]
      public uint LicensedClients { get; set; }

      [DataMember]
      public uint UsedClients { get; set; }

      [DataMember]
      public uint FixedRestAPIClients { get; set; }

      [DataMember]
      public string LicensedProcessVariables { get; set; }

      [DataMember]
      public uint UsedProcessvariables { get; set; }

      [DataMember]
      public bool ServiceAndAlertLicensed { get; set; }

      [DataMember]
      public bool MirrorLicensed { get; set; }

      [DataMember]
      [FormatDateTime(nameof(ExpirationDate_FORMATTED), DateTimeFormatType.Day1)]
      public DateTime ExpirationDate { get; set; }

      [DataMember]
      public string ExpirationDate_FORMATTED { get; set; }
   }
}
