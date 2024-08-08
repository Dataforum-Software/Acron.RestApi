using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Common.Response.LicenseOverview;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Acron.RestApi.Interfaces.Common.Response.LicenseOverview.IAcLicenceOverviewPlantsResponse;

namespace Acron.RestApi.DataContracts.Common.Response.LicenseOverview
{
   [DataContract]
   public class AcLicenceOverviewPlantsResponse : IAcLicenceOverviewPlantsResponse
   {
      [DataMember]
      public string PlantShortName { get; set; }

      [DataMember]
      [DefaultValue("01.01.1970 00:00:00")]
      [FormatDateTime(nameof(LastRefreshTime_FORMATTED))]
      public DateTime LastRefreshTime { get; set; }

      [DataMember]
      public string LastRefreshTime_FORMATTED { get; set; }

      [DataMember]
      [DefaultValue("string")]
      [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
      public LicenseLoginMode LoginMode { get; set; }

      [DataMember]
      public uint Port { get; set; }

      [DataMember]
      public ulong ServerID { get; set; }

      [DataMember]
      public uint UsedClients { get; set; }

      [DataMember]
      public uint FixedRestApiClients { get; set; }

      [DataMember]
      public uint UsedFrontendClients { get; set; }

      [DataMember]
      public uint UsedFrontendClientsOnMirror { get; set; }

      [DataMember]
      public uint UsedProcessVariables { get; set; }


   }
}
