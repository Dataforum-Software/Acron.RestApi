using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.Serialization;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateAlertObjectRequestResource : UpdateBaseObjectRequestResource, IUpdateAlertObjectRequestResource
   {
      #region cTor

      public UpdateAlertObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.Alert)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropState = AlertDefines.AlertState.Disturbance;
      }

      #region IAlertObject

      /// <summary>
      /// Identifikation des BOs
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      [MinLength(1)]
      [MaxLength(299)]
      public override string ShortName
      {
         get { return base.ShortName; }
         set
         {
            base.ShortName = value;
         }
      }

      /// <summary>
      /// Bezeichnung des BOs
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      [MinLength(0)]
      [MaxLength(299)]
      public override string LongName
      {
         get { return base.LongName; }
         set
         {
            base.LongName = value;
         }
      }


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
