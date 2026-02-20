using Acron.RestApi.Interfaces.Common.Request.ChangeProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Request.ChangeProtocol
{
   [DataContract]
   public class GetDataProtocolRequestResource : IGetDataProtocolRequestResource
   {
      [DataMember]
      public DateTimeOffset FromTime { get; set; }

      public DateTime FromTime_UTC
      {
         get
         {
            return FromTime.UtcDateTime;
         }
      }

      [DataMember]
      public DateTimeOffset ToTime { get; set; }
      public DateTime ToTime_UTC
      {
         get
         {
            return ToTime.UtcDateTime;
         }
      }

      [DataMember]
      public DateTimeOffset FromTimeData { get; set; }

      public DateTime FromTimeData_UTC
      {
         get
         {
            return FromTimeData.UtcDateTime;
         }
      }

      [DataMember]
      public DateTimeOffset ToTimeData { get; set; }
      public DateTime ToTimeData_UTC
      {
         get
         {
            return ToTimeData.UtcDateTime;
         }
      }

      [DataMember]
      public string UserShortName { get; set; }
      [DataMember]
      public List<PROTFILTER_DataProtocol> PROTFILTERs { get; set; }
   }
}
