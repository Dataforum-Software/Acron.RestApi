using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateUnitObjectRequestResource : CreateUnitBaseRequestResource, ICreateUnitObjectRequestResource
   {
      #region cTor

      public CreateUnitObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.Unit)
      { }

      #endregion cTor

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
         get { return _propFactor; }
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
         get { return _propOffset; }
         set
         {
            _propOffset = value;
            ModifiedProperties.Add(nameof(PropOffset));
         }
      }

      #endregion IUnitObject
   }
}

