using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request
{
   [DataContract]
   public class DefaultValuesRequestResource : IDefaultValuesRequestResource
   {
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      [Required]
      public BaseObjectDefines.RestObjectTypeCode? RestApiTypeCode { get; set; }

   }
}
