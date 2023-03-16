using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiUnitObject : RestApiUnitBase, IUnitObject
   {
      #region cTor

      public RestApiUnitObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Unit)
      { }

      public RestApiUnitObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IUnitObject iUb = baseObject as IUnitObject;

         this.PropOffset = iUb.PropOffset;
         this.PropFactor = iUb.PropFactor;
         this._restApiUnitType = iUb.RestApiUnitType;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateUnitObjectRequestResource iUb = baseObject as ICreateUnitObjectRequestResource;

         this.PropOffset = iUb.PropOffset;
         this.PropFactor = iUb.PropFactor;
         this._restApiUnitType = iUb.RestApiUnitType;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateUnitObjectRequestResource iUb = baseObject as IUpdateUnitObjectRequestResource;

         this.PropOffset = iUb.PropOffset;
         this.PropFactor = iUb.PropFactor;
         this._restApiUnitType = iUb.RestApiUnitType;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this._restApiUnitType = UnitDefines.UnitType.User;
         this.PropFactor = 1.0f;
         this.PropOffset = 0.0f;
      }

      #region IUnitObject

      private UnitDefines.UnitType _restApiUnitType;

      /// <summary>
      /// Type of unit (DaFo defined, user defined...)
      /// </summary>
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public UnitDefines.UnitType RestApiUnitType
      {
         get { return _restApiUnitType; }
      }

      private double _propFactor;
      /// <summary>
      /// Factor to be multiplied with base unit
      /// </summary>
      [DataMember]
      public double PropFactor 
      {
         get { return _propFactor;}
         set 
         { 
            _propFactor = value;
            ModifiedProperties.Add(nameof(PropFactor));
         }
      }

      private double _propOffset;
      /// <summary>
      /// Offset to base unit
      /// </summary>
      [DataMember]
      public double PropOffset 
      {
         get { return _propOffset;}
         set 
         { 
            _propOffset = value;
            ModifiedProperties.Add(nameof(PropOffset));
         }
      }

      #endregion IUnitObject
   }

}
