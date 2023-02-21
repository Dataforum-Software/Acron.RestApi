using Acron.RestApi.Interfaces.Configuration.Request;
using System;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class SaveRequestResource : ISaveRequestResource
   {
      [DataMember]
      public DateTime? RecalculateFrom { get; set; }
   }
}