using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{
   [DataContract]
   public class PvCommentResultItem : IPvCommentResultItem
   {
      [DataMember]
      public uint PVId { get; set; }

      [DataMember]
      public string ShortName { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(TimeValues_FORMATTED), DateTimeFormatType.Default)]
      public List<DateTime> TimeValues { get; set; }

      [DataMember]
      public List<string> TimeValues_FORMATTED { get; set; }

      [DataMember]
      [Range(0, 4)]
      public List<CDAT_Kind> KindValues { get; set; }

      [DataMember]
      public List<string> CommentValues { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(TimeEditValues_FORMATTED), DateTimeFormatType.Process)]
      public List<DateTime> TimeEditValues { get; set; }

      [DataMember]
      public List<string> TimeEditValues_FORMATTED { get; set; }

      [DataMember]
      public List<string> UserValues { get; set; }
   }
}
