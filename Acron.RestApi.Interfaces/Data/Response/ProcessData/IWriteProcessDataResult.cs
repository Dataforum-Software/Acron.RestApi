using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
   public interface IWriteProcessDataResult<WriteProcessDataResultItemType> where WriteProcessDataResultItemType : IWriteProcessDataResultItem
   {
      [SwaggerSchema("List of result items")]
      [SwaggerExampleValue(typeof(IWriteProcessDataResultItem))]
      List<WriteProcessDataResultItemType> ResultItems { get; set; }
   }
}
