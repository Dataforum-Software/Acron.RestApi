using Acron.RestApi.DataContracts.Configuration.Response;
using Acron.RestApi.Interfaces.Configuration.Response;
using Acron.RestApi.Interfaces.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcBadCreateUpdateResponse : AcBadRequestResponse, IAcBadCreateUpdateResponse<CreateUpdateResult, CreateUpdateResultItem>
   {
      [DataMember]
      public string ResultType { get; set; }

      [DataMember]
      public int ResultCount { get; set; }

      [DataMember]
      public CreateUpdateResult Result { get; set; }

   }
}
