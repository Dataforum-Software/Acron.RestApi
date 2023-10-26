using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateUnitObjectRequestResource : UpdateUnitBaseRequestResource, IUpdateUnitObjectRequestResource
   {
      #region cTor

      public UpdateUnitObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.Unit)
      { }

      #endregion cTor

      #region IUnitObject

      private const UnitDefines.UnitType _restApiUnitType = UnitDefines.UnitType.Default;

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
