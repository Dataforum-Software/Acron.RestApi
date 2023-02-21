using Acron.RestApi.Interfaces.Configuration.Request;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class GetAllRequestResource : IGetAllRequestResource
   {
      [DataMember]
      public bool SmallObjects { get; set; } = false;
   }

   [DataContract]
   public class GetAllRequestResource__L9_0__9_1__9_2__9_3 : IGetAllRequestResource__L9_0__9_1__9_2__9_3
   {
      [DataMember]
      public bool SmallObjects { get; set; } = false;

      [DataMember]
      public bool ShowLockedAlerts { get; set; } = false;
   }
}
