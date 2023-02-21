using Acron.RestApi.Interfaces.BaseObjects;
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

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IProviderBaseObject iProvBase = baseObject as IProviderBaseObject;

         this.PropProviderId = iProvBase.PropProviderId;
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