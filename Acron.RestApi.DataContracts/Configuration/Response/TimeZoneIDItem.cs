using Acron.RestApi.Interfaces.Configuration.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Configuration.Response
{
   [DataContract]
   public class TimeZoneIDItem : ITimeZoneIDItem
   {
      [DataMember]
      public string TimeZoneID { get; set; }

      [DataMember]
      public string DisplayName { get; set; }
   }
}
