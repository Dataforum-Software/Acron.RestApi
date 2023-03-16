using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateDefaultGroupObjectRequestResource : UpdateGroupBaseObjectRequestResource, IUpdateDefaultGroupObjectRequestResource
   {
      #region cTor

      public UpdateDefaultGroupObjectRequestResource()
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
