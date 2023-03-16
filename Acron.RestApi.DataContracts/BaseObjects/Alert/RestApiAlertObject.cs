using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IAlertObject iAl = baseObject as IAlertObject;

         this.PropState = iAl.PropState;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         ICreateAlertObjectRequestResource iAl = baseObject as ICreateAlertObjectRequestResource;

         this.PropState = iAl.PropState;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         IUpdateAlertObjectRequestResource iAl = baseObject as IUpdateAlertObjectRequestResource;

         this.PropState = iAl.PropState;

         return true;
      }

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