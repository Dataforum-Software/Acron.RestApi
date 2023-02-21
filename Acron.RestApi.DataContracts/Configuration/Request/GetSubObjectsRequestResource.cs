using Acron.RestApi.Interfaces.Configuration.Request;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class GetSubObjectsRequestResource : IGetSubObjectsRequestResource
   {
      [DataMember]
      [Required]
      public int? BaseObjectID { get; set; }

      [DataMember]
      [Required]
      public bool? WithFolder { get; set; }

      [DataMember]
      public bool SmallObjects { get; set; } = false;

      [DataMember]
      public bool OnlyDirectChilds { get; set; } = false;
   }
}