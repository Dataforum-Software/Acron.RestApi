using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.HandValStringData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.HandValStringData
{
   [DataContract]
   public class GetHandValStringDataResultItem : IGetHandValStringDataResultItem
   {
      [DataMember]
      public int PVId { get; set; }

      [DataMember]
      [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
      [Range(2, 5)]
      public List<CDAT_Kind> KindValues { get; set; }

      [DataMember]
      public List<string> StringValues { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(TimeStampsEdit_FORMATTED), DateTimeFormatType.DayX)]
      public List<DateTime> TimeStampsEdit { get; set; }

      [DataMember]
      public List<string> TimeStampsEdit_FORMATTED { get; set; }


      [DataMember]
      public List<string> UserValues { get; set; }
   }
}
