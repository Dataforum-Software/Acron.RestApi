using Acron.RestApi.Interfaces.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Response
{
   [DataContract]
   public class AcAuthenticationFailedResponse : AcBadRequestResponse, IAcAuthenticationFailedResponse
   {

   }
}
