using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiProviderBaseObject : RestApiGroupBaseObject, IProviderBaseObject
   {
      #region cTor

      public RestApiProviderBaseObject(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      public RestApiProviderBaseObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IProviderBaseObject iProvBase = baseObject as IProviderBaseObject;

         this.PropProviderId = iProvBase.PropProviderId;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateProviderBaseObjectRequestResource iProvBase = baseObject as ICreateProviderBaseObjectRequestResource;

         this.PropProviderId = iProvBase.PropProviderId;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateProviderBaseObjectRequestResource iProvBase = baseObject as IUpdateProviderBaseObjectRequestResource;

         this.PropProviderId = iProvBase.PropProviderId;

         return true;
      }

      #region IProviderBaseObject

      private int _propProviderId;

      [DataMember]
      public int PropProviderId
      {
         get { return _propProviderId; }
         set 
         {
            _propProviderId = value;
            ModifiedProperties.Add(nameof(PropProviderId)); 
         }
      }

      #endregion IProviderBaseObject
   }
}