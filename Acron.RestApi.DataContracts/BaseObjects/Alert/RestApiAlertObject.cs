using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiAlertObject : RestApiBaseObject, IAlertObject
   {
      #region cTor

      public RestApiAlertObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Alert)
      { }

      public RestApiAlertObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override void memberMapper(object baseObject)
      {
         base.memberMapper(baseObject);

         IAlertObject iAl = baseObject as IAlertObject;

         this.PropState = iAl.PropState;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropState = AlertDefines.AlertState.Disturbance;
      }

      #region IAlertObject

      private AlertDefines.AlertState _propState;

      [DataMember]
      [DefaultValue(1)]
      [JsonConverter(typeof(StringEnumConverter))]
      public AlertDefines.AlertState PropState
      {
         get { return _propState; }
         set
         {
            _propState = value;
            ModifiedProperties.Add(nameof(PropState));
         }
      }

      #endregion IAlertObject
   }
}