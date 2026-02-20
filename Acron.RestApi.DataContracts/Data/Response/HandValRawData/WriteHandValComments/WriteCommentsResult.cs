using Acron.RestApi.Interfaces.Data.Response.HandValRawData.WriteHandValComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.HandValRawData.WriteHandValComments
{
   public class WriteCommentsResult : IWriteCommentsResult
   {
      public bool Result { get; set; }
   }
}
