using Acron.RestApi.Interfaces.Data.Request.StringCompData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Request.StringCompData
{
   [DataContract]
   public class GetGeneralCommentRequestResource : IGetGeneralCommentRequestResource
   {
      [DataMember]
      [Required]
      [JsonConverter(typeof(StringEnumConverter))]
      public AVComKinds_GeneralComment Kind { get; set; }

      [DataMember]
      [Required]
      public DateOnly Date { get; set; }
   }
}
