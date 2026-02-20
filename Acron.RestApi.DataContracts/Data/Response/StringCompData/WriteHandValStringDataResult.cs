using Acron.RestApi.Interfaces.Data.Response.StringCompData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.StringCompData
{
   [DataContract]
   public class WriteHandValStringDataResult : IWriteHandValStringDataResult
   {
      [DataMember]
      public bool Result { get; set; }
   }
}
