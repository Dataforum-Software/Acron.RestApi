using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{

   [DataContract]    
   public class GetProcessDataRequestResource : IGetProcessDataRequestResource<GetProcessDataPVDescription>
   {
      [DataMember]
      [FormatDateTimeUTCRequest(nameof(FromTime_UTC))]
      public DateTime FromTime { get; set; }
      public DateTime FromTime_UTC { get; set; }

      [DataMember]
      [FormatDateTimeUTCRequest(nameof(ToTime_UTC))]
      public DateTime ToTime { get; set; }
      public DateTime ToTime_UTC { get; set; }

      /// <summary>
      /// Differenzzeit in Sekunden für Sonderfälle, sonst -1
      /// </summary>
      [DataMember]
      public int DiffTime { get; set; } = -1;

      /// <summary>
      /// Liste der PV ObjectIDs mit Optionen
      /// </summary>
      [DataMember]
      public List<GetProcessDataPVDescription> PVIDs { get; set; }
   }
}
