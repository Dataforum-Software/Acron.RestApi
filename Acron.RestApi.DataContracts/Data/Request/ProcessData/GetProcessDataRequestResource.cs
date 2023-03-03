using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Request.ProcessData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Data.Request.ProcessData
{

   [DataContract]
   public class GetProcessDataRequestResource : IGetProcessDataRequestResource<GetProcessDataPVDescription>
   {
      [DataMember]
      [Required]
      [RequestTimeStampValidator]
      public DateTimeOffset FromTime { get; set; }
      public DateTime FromTime_UTC
      {
         get { return FromTime.UtcDateTime; }
      }

      [DataMember]
      [Required]
      [RequestTimeStampValidator]
      public DateTimeOffset ToTime { get; set; }
      public DateTime ToTime_UTC
      {
         get { return ToTime.UtcDateTime; }
      }

      /// <summary>
      /// Differenzzeit in Sekunden für Sonderfälle, sonst -1
      /// </summary>
      [DataMember]
      public int DiffTime { get; set; } = -1;

      /// <summary>
      /// Liste der PV ObjectIDs mit Optionen
      /// </summary>
      [DataMember]
      [Required]
      public List<GetProcessDataPVDescription> PVIDs { get; set; }
   }
}
