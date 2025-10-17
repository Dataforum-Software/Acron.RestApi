using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ServiceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ServiceData
{
   [DataContract]
   public class GetServiceEntityDataItem : IGetServiceEntityDataItem
   {
      [DataMember]
      public uint EntityId { get; set; }
      [DataMember]
      public string EntityShortName { get; set; }
      [DataMember]
      public uint LastServiceId { get; set; }
      [DataMember]
      public string LastServiceShortName { get; set; }
      [DataMember]
      public string LastServiceLongName { get; set; }

      [DataMember]
      public DateOnly LastServiceDate { get; set; }

      [FormatDateTime(nameof(LastServiceDate_FORMATTED))]
      public DateTime LastServiceTime
      {
         get
         {
            return LastServiceDate.ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc);
         }

         set
         {
            if (value != null)
               LastServiceDate = DateOnly.FromDateTime(value);
         }
      }

      [DataMember]
      public string LastServiceDate_FORMATTED { get; set; }
   }
}
