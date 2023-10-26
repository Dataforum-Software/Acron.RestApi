using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateAlertGroupObjectRequestResource : UpdateRealGroupObjectRequestResource, IUpdateAlertGroupObjectRequestResource
   {
      #region cTor

      public UpdateAlertGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.AlertGroup)
      { }

      #endregion cTor

      #region IAlertGroupObject

      private AlertGroupDefines.GroupType _propGroupType = AlertGroupDefines.GroupType.UserDefined;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public AlertGroupDefines.GroupType PropGroupType
      {
         get
         {
            return _propGroupType;
         }
      }

      #endregion IAlertGroupObject

   }
}
