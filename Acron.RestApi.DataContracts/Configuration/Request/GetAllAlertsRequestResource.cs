using Acron.RestApi.Interfaces.Configuration.Request;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class GetAllAlertsRequestResource : GetAllRequestResource, IGetAllAlertsRequestResource
   {
      [DataMember]
      public bool ShowLockedAlerts { get; set; } = false;
   }
}
