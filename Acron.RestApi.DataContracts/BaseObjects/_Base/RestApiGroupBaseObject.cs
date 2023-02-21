using Acron.RestApi.Interfaces.BaseObjects;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiGroupBaseObject : RestApiBaseObject, IGroupBaseObject
   {
      #region cTor

      public RestApiGroupBaseObject(BaseObjectDefines.RestObjectTypeCode typeCode)
         :base(typeCode)
      { }

      public RestApiGroupBaseObject(object source)
         :base(source)
      { }

      #endregion cTor

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IGroupBaseObject iGroupBase = baseObject as IGroupBaseObject;

         _isDefaultGroup = iGroupBase.IsDefaultGroup;
         
      }

      #region IGroupBaseObject

      private bool _isDefaultGroup = false;

      [DataMember]
      public bool IsDefaultGroup
      {
         get
         {
            return _isDefaultGroup;
         }
      }

      #endregion IGroupBaseObject
   }
}
