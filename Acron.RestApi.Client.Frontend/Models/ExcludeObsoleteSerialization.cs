using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Frontend.Models
{
    public class ExcludeObsoletePropertiesResolver : DefaultContractResolver
    {
        protected override List<MemberInfo> GetSerializableMembers(Type objectType)
        {
            var members = base.GetSerializableMembers(objectType);
            members.RemoveAll(m => m.IsDefined(typeof(ObsoleteAttribute), true));
            return members;
        }

      public static JsonSerializerSettings NoObsolete = new JsonSerializerSettings()
      {
         ContractResolver = new ExcludeObsoletePropertiesResolver()
      };
    }

}
