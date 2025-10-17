using Acron.RestApi.Interfaces.Common.Request.ChangeProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Common.Request.ChangeProtocol
{
   public class GetConfigProtocolRequestResource : IGetConfigProtocolRequestResource
   {
      [DataMember]
      public DateTime FromTime { get; set; }
      [DataMember]
      public DateTime ToTime { get; set; }
      [DataMember]
      public string UserShortName { get; set; }
      [DataMember]
      public List<PROTFILTER_ConfigProtocol> PROTFILTERs { get; set; }
      [DataMember]
      public LanguageType Language { get; set; }
   }
}
