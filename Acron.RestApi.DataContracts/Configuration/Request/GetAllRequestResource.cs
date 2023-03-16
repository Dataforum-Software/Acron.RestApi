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
}
