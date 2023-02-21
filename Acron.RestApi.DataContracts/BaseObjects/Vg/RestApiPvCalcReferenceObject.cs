using Acron.RestApi.Interfaces.BaseObjects;
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

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IPvCalcReferenceObject iKz = baseObject as IPvCalcReferenceObject;

         this.PropIdReferenceNumberTemplate = iKz.PropIdReferenceNumberTemplate;
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