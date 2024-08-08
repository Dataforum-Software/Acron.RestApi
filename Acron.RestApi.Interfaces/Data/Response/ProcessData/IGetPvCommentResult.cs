using Acron.RestApi.Interfaces.Data.Request.HandValRawData.GetHandValRawDataComments;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.Data.Response.ProcessData
{
    public interface IGetPvCommentResult<T> where T : IPvCommentResultItem
    {
        [SwaggerSchema("List of comment data items")]
        [SwaggerExampleValue(typeof(IPvCommentResultItem))]
        List<T> CommentItems { get; set; }
    }
}
