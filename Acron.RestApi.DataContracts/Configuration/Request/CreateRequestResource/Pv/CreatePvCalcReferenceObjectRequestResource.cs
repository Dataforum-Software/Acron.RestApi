using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreatePvCalcReferenceObjectRequestResource : CreatePvCalcObjectRequestResource, ICreatePvCalcReferenceObjectRequestResource
   {
      #region cTor

      public CreatePvCalcReferenceObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.VgCalcReference)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropIdReferenceNumberTemplate = -1;
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
