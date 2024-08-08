using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiUserGroupObject : RestApiGroupBaseObject, IUserGroupObject
   {
      #region cTor

      public RestApiUserGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.UserGroup)
      { }

      public RestApiUserGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IUserGroupObject iUsGrp = baseObject as IUserGroupObject;
         //   this._propGroupType = iAlGrp.PropGroupType;
         this.ShortName = null;


         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         //   ICreateUserGroupObjectRequestResource iAlGrp = baseObject as ICreateUserGroupObjectRequestResource;
         this.ShortName = null;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         //   IUpdateUserGroupObjectRequestResource iAlGrp = baseObject as IUpdateUserGroupObjectRequestResource;
         this.ShortName = null;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.ShortName = string.Empty;
         this.LongName = string.Empty;
      }

      #region IUserGroupObject

      #endregion IUserGroupObject

   }
}