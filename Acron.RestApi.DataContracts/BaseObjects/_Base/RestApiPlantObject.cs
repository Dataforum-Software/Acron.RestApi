using Acron.RestApi.Interfaces.BaseObjects;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiPlantObject : RestApiBaseObject, IPlantObject
   {
      #region cTor

      public RestApiPlantObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Plant)
      { }

      public RestApiPlantObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         // Falls 'RestTypeCode' nicht passt - siehe Eigenschaft "RestTypeCode" in BaseObject_IBaseObject

         IPlantObject iplant = baseObject as IPlantObject;

         this.PropVersion = iplant.PropVersion;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();
      }

      #region IPlantObject

      private string _propVersion;

      /// <summary> Version der Anlage </summary>
      [DataMember]
      public string PropVersion 
      {
         get { return _propVersion; }
         private set 
         {
            _propVersion = value;
            ModifiedProperties.Add(nameof(PropVersion));
         }
      }

      #endregion IPlantObject
   }
}
