using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateDefaultGroupObjectRequestResource : CreateGroupBaseObjectRequestResource, ICreateDefaultGroupObjectRequestResource
   {
      #region cTor

      public CreateDefaultGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.DefaultGroup)
      { }

      #endregion cTor

      #region IDefaultGroupObject

      private DefaultGroupDefines.GroupType _propGroupType = DefaultGroupDefines.GroupType.DefaultAlerts;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public DefaultGroupDefines.GroupType PropGroupType
      {
         get
         {
            return _propGroupType;
         }
      }

      #endregion IDefaultGroupObject

   }
}
