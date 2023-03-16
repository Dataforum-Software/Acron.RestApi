using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
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

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IDefaultGroupObject iDefGrp = baseObject as IDefaultGroupObject;

         _propGroupType = iDefGrp.PropGroupType;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateDefaultGroupObjectRequestResource iDefGrp = baseObject as ICreateDefaultGroupObjectRequestResource;

         _propGroupType = iDefGrp.PropGroupType;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateDefaultGroupObjectRequestResource iDefGrp = baseObject as IUpdateDefaultGroupObjectRequestResource;

         _propGroupType = iDefGrp.PropGroupType;

         return true;
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
