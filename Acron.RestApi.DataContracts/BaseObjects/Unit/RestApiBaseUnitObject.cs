using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiBaseUnitObject : RestApiUnitBase, IBaseUnitObject
   {
      #region cTor

      public RestApiBaseUnitObject()
         : base(BaseObjectDefines.RestObjectTypeCode.BaseUnit)
      { }

      public RestApiBaseUnitObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IBaseUnitObject iUb = baseObject as IBaseUnitObject;

         this._restApiUnitType = iUb.RestApiUnitType;
         this.PropCategory = iUb.PropCategory;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this._restApiUnitType = UnitDefines.UnitType.User;
      }

      #region IBaseUnitObject

      private UnitDefines.UnitType _restApiUnitType;

      /// <summary>
      /// Type of main unit (DaFo defined, user defined...)
      /// </summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public UnitDefines.UnitType RestApiUnitType 
      { 
         get { return _restApiUnitType; } 
      }

      private string _propCategory;
      /// <summary>
      /// Category of main unit
      /// </summary>
      [DataMember]
      public string PropCategory 
      {
         get { return _propCategory;}
         set 
         { 
            _propCategory = value;
            ModifiedProperties.Add(nameof(PropCategory));
         }
      }

      #endregion IBaseUnitObject
   }

}
