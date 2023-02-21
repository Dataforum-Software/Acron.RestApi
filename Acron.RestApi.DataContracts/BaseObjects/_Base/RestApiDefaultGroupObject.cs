using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiDefaultGroupObject : RestApiGroupBaseObject, IDefaultGroupObject
   {
      #region cTor

      public RestApiDefaultGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.DefaultGroup)
      { }

      public RestApiDefaultGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IDefaultGroupObject iDefGrp = baseObject as IDefaultGroupObject;

         _propGroupType = iDefGrp.PropGroupType;
      }

      #region IDefaultGroupObject

      private DefaultGroupDefines.GroupType _propGroupType= DefaultGroupDefines.GroupType.DefaultAlerts;

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
