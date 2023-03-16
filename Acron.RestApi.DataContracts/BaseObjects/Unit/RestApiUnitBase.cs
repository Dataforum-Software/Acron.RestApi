using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiUnitBase : RestApiGroupBaseObject, IUnitBase
   {
      #region cTor

      public RestApiUnitBase(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      public RestApiUnitBase(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IUnitBase iUb = baseObject as IUnitBase;

         this.PropDescription = iUb.PropDescription;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateUnitBaseRequestResource iUb = baseObject as ICreateUnitBaseRequestResource;

         this.PropDescription = iUb.PropDescription;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateUnitBaseRequestResource iUb = baseObject as IUpdateUnitBaseRequestResource;

         this.PropDescription = iUb.PropDescription;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropDescription = string.Empty;
      }

      #region IUnitBase

      private string _propDescription;
      [DataMember]
      public string PropDescription 
      {
         get { return _propDescription; }
         set
         {
            _propDescription = value;
            ModifiedProperties.Add(nameof(PropDescription));
         }
      }

      #endregion IUnitBase
   }

}
