using Acron.RestApi.Interfaces.Configuration.Request;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class SaveRequestResource : ISaveRequestResource
   {
      [DataMember]
      public DateTimeOffset? RecalculateFrom { get; set; }

      public DateTime? RecalculateFrom_UTC
      {
         get
         {
            return RecalculateFrom?.UtcDateTime;
         }
      }

      [DataMember]
      public bool UsePlannedRecalc { get; set; }
   }
}