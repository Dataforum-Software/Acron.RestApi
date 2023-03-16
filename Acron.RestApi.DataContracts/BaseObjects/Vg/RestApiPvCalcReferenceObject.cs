using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiPvCalcReferenceObject : RestApiPvCalcObject, IPvCalcReferenceObject
   {
      #region cTor

      public RestApiPvCalcReferenceObject()
         : base(BaseObjectDefines.RestObjectTypeCode.VgCalcReference)
      { }

      public RestApiPvCalcReferenceObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropIdReferenceNumberTemplate = -1;
      }

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IPvCalcReferenceObject iKz = baseObject as IPvCalcReferenceObject;

         this.PropIdReferenceNumberTemplate = iKz.PropIdReferenceNumberTemplate;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreatePvCalcReferenceObjectRequestResource iKz = baseObject as ICreatePvCalcReferenceObjectRequestResource;

         this.PropIdReferenceNumberTemplate = iKz.PropIdReferenceNumberTemplate;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdatePvCalcReferenceObjectRequestResource iKz = baseObject as IUpdatePvCalcReferenceObjectRequestResource;

         this.PropIdReferenceNumberTemplate = iKz.PropIdReferenceNumberTemplate;

         return true;
      }

      #region IVgCalcReferenceObject

      private int _propIdReferenceNumberTemplate;

      /// <summary> Id der zugeordneten Kennzahlvorlage </summary>
      [DataMember]
      public int PropIdReferenceNumberTemplate 
      {
         get { return _propIdReferenceNumberTemplate; }
         private set 
         {
            _propIdReferenceNumberTemplate = value;
            ModifiedProperties.Add(nameof(PropIdReferenceNumberTemplate));
         }
      }

      #endregion IVgCalcReferenceObject


   }

}