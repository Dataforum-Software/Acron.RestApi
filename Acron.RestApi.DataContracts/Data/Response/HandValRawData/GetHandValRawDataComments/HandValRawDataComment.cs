using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.GlobalDataDefines;
using Acron.RestApi.Interfaces.Data.Response.HandValRawData.GetHandValRawData.GetHandValRawDataCommentsResult;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.GetHandValRawDataComments
{
   [DataContract]
   public class HandValRawDataComment : IHandValRawDataComment
   {
      [DataMember]
      public uint PVId { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(TimeValues_FORMATTED), DateTimeFormatType.Default)]
      public List<DateTime> TimeValues { get; set; }

      [DataMember]
      public List<string> TimeValues_FORMATTED { get; set; }

      [DataMember]
      public List<CDAT_Kind> KindValues { get; set; }

      [DataMember]
      public List<string> CommentValues { get; set; }

      [DataMember]
      [FormatDateTimeList(nameof(TimeEditValues_FORMATTED), DateTimeFormatType.Default)]
      public List<DateTime> TimeEditValues { get; set; }

      [DataMember]
      public List<string> TimeEditValues_FORMATTED { get; set; }

      [DataMember]
      public List<string> UserValues { get; set; }

   }
}
