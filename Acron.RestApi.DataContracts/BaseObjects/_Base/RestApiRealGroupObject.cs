using Acron.RestApi.Interfaces;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiRealGroupObject: RestApiGroupBaseObject, IRealGroupObject
   {
      #region cTor

      public RestApiRealGroupObject(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      public RestApiRealGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IRealGroupObject iGrp = baseObject as IRealGroupObject;

         this.ShortName = null;

         _propGroupInfo = iGrp.PropGroupInfo;
         _propColorIndex = iGrp.PropColorIndex;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateRealGroupObjectRequestResource iGrp = baseObject as ICreateRealGroupObjectRequestResource;

         this.ShortName = null;

         _propGroupInfo = iGrp.PropGroupInfo;
         _propColorIndex = iGrp.PropColorIndex;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateRealGroupObjectRequestResource iGrp = baseObject as IUpdateRealGroupObjectRequestResource;

         this.ShortName = null;

         _propGroupInfo = iGrp.PropGroupInfo;
         _propColorIndex = iGrp.PropColorIndex;

         return true;
      }

      #region IRealGroupObject

      private string _propGroupInfo = string.Empty;

      [DataMember]
      [DefaultValue("")]
      public string PropGroupInfo
      {
         get { return _propGroupInfo; }
         set
         {
            _propGroupInfo = value;
         }
      }

      private int _propColorIndex = 0;

      [DataMember]
      [DefaultValue(0)]
      public int PropColorIndex
      {
         get { return _propColorIndex; }
         set
         {
            _propColorIndex = value;
         }
      }

      #endregion IRealGroupObject
   }
}
