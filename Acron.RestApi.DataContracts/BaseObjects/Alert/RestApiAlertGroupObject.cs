using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiAlertGroupObject : RestApiRealGroupObject, IAlertGroupObject
   {
      #region cTor

      public RestApiAlertGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.AlertGroup)
      { }

      public RestApiAlertGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IAlertGroupObject iAlGrp = baseObject as IAlertGroupObject;

         this._propGroupType = iAlGrp.PropGroupType;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateAlertGroupObjectRequestResource iAlGrp = baseObject as ICreateAlertGroupObjectRequestResource;

         this._propGroupType = iAlGrp.PropGroupType;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateAlertGroupObjectRequestResource iAlGrp = baseObject as IUpdateAlertGroupObjectRequestResource;

         this._propGroupType = iAlGrp.PropGroupType;

         return true;
      }

      public void SetReferencedObjects(List<int> referencedIds)
      {
         if (referencedIds == null || !referencedIds.Any())
            _referencedIds = null;
         else
            _referencedIds = new List<int>(referencedIds);
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