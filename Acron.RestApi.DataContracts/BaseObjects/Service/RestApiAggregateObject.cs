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
   public class RestApiAggregateObject : RestApiBaseObject, IAggregateObject
   {
      #region cTor

      public RestApiAggregateObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Aggregate)
      { }

      public RestApiAggregateObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IAggregateObject iAg = baseObject as IAggregateObject;

         //this.PropState = iAl.PropState;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         // ToDo
         //ICreateAggregateObjectRequestResource iAl = baseObject as ICreateAggregateObjectRequestResource;
         //this.PropState = iAl.PropState;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         // ToDo
         //IUpdateAggregateObjectRequestResource iAl = baseObject as IUpdateAggregateObjectRequestResource;
         //this.PropState = iAl.PropState;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         //this.PropState = AlertDefines.AlertState.Disturbance;
      }

      #region IAggregateObject

      /// <summary>
      /// Identifikation des BOs
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      [MinLength(1)]
      [MaxLength(32)]
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
      [MinLength(1)]
      [MaxLength(64)]
      public override string LongName
      {
         get { return base.LongName; }
         set
         {
            base.LongName = value;
         }
      }


      //private AlertDefines.AlertState _propState;

      //[DataMember]
      //[DefaultValue(1)]
      //[JsonConverter(typeof(StringEnumConverter))]
      //public AlertDefines.AlertState PropState
      //{
      //   get { return _propState; }
      //   set
      //   {
      //      _propState = value;
      //      ModifiedProperties.Add(nameof(PropState));
      //   }
      //}

      #endregion IAggregateObject
   }
}