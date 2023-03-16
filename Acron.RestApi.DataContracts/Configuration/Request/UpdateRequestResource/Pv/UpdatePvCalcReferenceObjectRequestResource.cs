using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdatePvCalcReferenceObjectRequestResource : UpdatePvCalcObjectRequestResource, IUpdatePvCalcReferenceObjectRequestResource
   {
      #region cTor

      public UpdatePvCalcReferenceObjectRequestResource()
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
