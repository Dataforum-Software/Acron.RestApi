using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateBaseUnitObjectRequestResource : UpdateUnitBaseRequestResource, IUpdateBaseUnitObjectRequestResource
   {
      #region cTor

      public UpdateBaseUnitObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.BaseUnit)
      { }

      #endregion cTor

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
         get { return _propCategory; }
         set
         {
            _propCategory = value;
            ModifiedProperties.Add(nameof(PropCategory));
         }
      }

      #endregion IBaseUnitObject
   }
}
