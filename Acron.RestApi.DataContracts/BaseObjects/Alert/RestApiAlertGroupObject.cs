using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiAlertGroupObject : RestApiGroupBaseObject, IAlertGroupObject
   {
      #region cTor

      public RestApiAlertGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.AlertGroup)
      { }

      public RestApiAlertGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IAlertGroupObject iAlGrp = baseObject as IAlertGroupObject;

         this._propGroupType = iAlGrp.PropGroupType;
      }

      #region IAlertGroupObject

      private AlertGroupDefines.GroupType _propGroupType= AlertGroupDefines.GroupType.UserDefined;

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