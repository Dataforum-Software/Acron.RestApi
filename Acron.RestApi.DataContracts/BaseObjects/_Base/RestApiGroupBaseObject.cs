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
   public class RestApiGroupBaseObject : RestApiBaseObject, IGroupBaseObject
   {
      #region cTor

      public RestApiGroupBaseObject(BaseObjectDefines.RestObjectTypeCode typeCode)
         :base(typeCode)
      { }

      public RestApiGroupBaseObject(object source)
         :base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IGroupBaseObject iGroupBase = baseObject as IGroupBaseObject;

         _isDefaultGroup = iGroupBase.IsDefaultGroup;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateGroupBaseObjectRequestResource iGroupBase = baseObject as ICreateGroupBaseObjectRequestResource;

         _isDefaultGroup = iGroupBase.IsDefaultGroup;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateGroupBaseObjectRequestResource iGroupBase = baseObject as IUpdateGroupBaseObjectRequestResource;

         _isDefaultGroup = iGroupBase.IsDefaultGroup;

         return true;
      }

      #region IGroupBaseObject

      private bool _isDefaultGroup = false;

      [DataMember]
      public bool IsDefaultGroup
      {
         get
         {
            return _isDefaultGroup;
         }
      }

      public IGroupBaseObject Parent { get => null; }

      #endregion IGroupBaseObject
   }
}
