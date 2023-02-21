using Acron.RestApi.Interfaces.BaseObjects;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiExtVarGroupObject : RestApiGroupBaseObject, IExtVarGroupObject
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

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IExtVarGroupObject iExtVarGrp = baseObject as IExtVarGroupObject;

         this.SetProviderId(iExtVarGrp.PropIdProvider);
      }

      #region IExtVarGroupObject

      private int _propIdProvider=0;

      [DataMember]
      public int PropIdProvider
      {
         get { return _propIdProvider; }
         //set
         //{
         //   _propIdProvider = value;
         //   ModifiedProperties.Add(nameof(PropIdProvider));
         //}
      }

      #endregion IExtVarGroupObject

   }
}



      