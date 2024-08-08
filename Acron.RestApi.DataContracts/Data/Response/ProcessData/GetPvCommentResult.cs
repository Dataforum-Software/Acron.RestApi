using Acron.RestApi.Interfaces.Data.Response.ProcessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Response.ProcessData
{
    [DataContract]
    public class GetPvCommentResult : IGetPvCommentResult<PvCommentResultItem>
    {
        [DataMember]
        public List<PvCommentResultItem> CommentItems { get; set; }
    }
}
