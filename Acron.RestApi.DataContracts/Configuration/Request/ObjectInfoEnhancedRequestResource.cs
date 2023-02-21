using Acron.RestApi.Interfaces.Configuration.Request;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class ObjectInfoEnhancedRequestResource : IObjectInfoEnhancedRequestResource
   {
      [DataMember]
      [Required]
      public int? BaseObjectID { get; set; }

      [DataMember]
      [Required]
      public bool ShowReferencedObjects { get; set; }

      [DataMember]
      [Required]
      public bool ShowObjectUsages { get; set; }
   }
}