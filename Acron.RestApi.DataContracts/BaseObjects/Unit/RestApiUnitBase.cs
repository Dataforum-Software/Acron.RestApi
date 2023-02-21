using Acron.RestApi.Interfaces.BaseObjects;
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

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IUnitBase iUb = baseObject as IUnitBase;

         this.PropDescription = iUb.PropDescription;
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
