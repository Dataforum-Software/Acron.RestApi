using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiExtVarGroupObject : RestApiRealGroupObject, IExtVarGroupObject
   {
      #region cTor

      public RestApiExtVarGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ExtVarGroup)
      { }

      public RestApiExtVarGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      public void SetProviderId(int providerId)
      {
         this._propIdProvider = providerId;
      }

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IExtVarGroupObject iExtVarGrp = baseObject as IExtVarGroupObject;

         this.SetProviderId(iExtVarGrp.PropIdProvider);

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateExtVarGroupObjectRequestResource iExtVarGrp = baseObject as ICreateExtVarGroupObjectRequestResource;

         this.SetProviderId(iExtVarGrp.PropIdProvider);

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateExtVarGroupObjectRequestResource iExtVarGrp = baseObject as IUpdateExtVarGroupObjectRequestResource;

         this.SetProviderId(iExtVarGrp.PropIdProvider);

         return true;
      }

      #region IExtVarGroupObject

      private int _propIdProvider=0;

      [DataMember]
      [Required]
      public int PropIdProvider
      {
         get { return _propIdProvider; }
         private set
         {
            _propIdProvider = value;
         //   ModifiedProperties.Add(nameof(PropIdProvider));
         }
      }

      #endregion IExtVarGroupObject

   }
}



      