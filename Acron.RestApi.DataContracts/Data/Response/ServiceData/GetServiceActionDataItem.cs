using Acron.RestApi.DataContracts.Data.Attributes;
using Acron.RestApi.Interfaces.Data.Response.ServiceData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ServiceData
{
   [DataContract]
   public class GetServiceActionDataItem : IGetServiceActionDataItem
   {
      [DataMember]
      public uint ServiceId { get; set; }
      [DataMember]
      public uint ParentId { get; set; }
      [DataMember]
      [DefaultValue(false)]
      public bool IsActive { get; set; }
      [DataMember]
      public double LPerc { get; set; }
      [DataMember]
      public double SPerc { get; set; }


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


      [DataMember]
      public DateOnly NextServiceDate { get; set; }

      [FormatDateTime(nameof(NextServiceDate_FORMATTED))]
      public DateTime NextServiceTime
      {
         get
         {
            return NextServiceDate.ToDateTime(TimeOnly.MinValue, DateTimeKind.Utc);
         }

         set
         {
            if (value != null)
               NextServiceDate = DateOnly.FromDateTime(value);
         }
      }

      [DataMember]
      public string NextServiceDate_FORMATTED { get; set; }


      [DataMember]      
      public char? NextServiceType { get; set; }


      [DataMember]
      [FormatDateTime(nameof(PrintTime_FORMATTED))]
      public DateTime PrintTime { get; set; }
      [DataMember]
      public string PrintTime_FORMATTED { get; set; }


      [DataMember]
      public uint BCount { get; set; }
      [DataMember]
      public uint LCount { get; set; }
      [DataMember]
      public uint SCount { get; set; }
      [DataMember]
      public uint BSum { get; set; }
      [DataMember]
      public uint LSum { get; set; }
      [DataMember]
      public uint SSum { get; set; }
      [DataMember]
      public uint BIntervall { get; set; }
      [DataMember]
      public uint LIntervall { get; set; }
      [DataMember]
      public uint SIntervall { get; set; }
      [DataMember]
      public uint Duration { get; set; }
      [DataMember]
      public double Cost { get; set; }
      [DataMember]
      public char? LastType { get; set; }
      [DataMember]
      public string Comment1 { get; set; }
      [DataMember]
      public string Comment2 { get; set; }
      [DataMember]
      public string Comment3 { get; set; }
      [DataMember]
      public string ServUser { get; set; }                  
   }
}
