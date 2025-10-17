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
   public class RestApiPvMaskObject : RestApiBaseObject, IPvMaskObject
   {
      #region cTor

      public RestApiPvMaskObject()
         : base(BaseObjectDefines.RestObjectTypeCode.PvMask)
      { }

      public RestApiPvMaskObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IPvMaskObject io = baseObject as IPvMaskObject;
         this.PropMaskType = io.PropMaskType;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         // ToDo
         //ICreatePvMaskObjectRequestResource iAl = baseObject as ICreatePvMaskObjectRequestResource;
         //this.PropMaskType = iAl.PropMaskType;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         // ToDo
         //IUpdatePvMaskObjectRequestResource iAl = baseObject as IUpdatePvMaskObjectRequestResource;
         //this.PropMaskType = iAl.PropMaskType;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();
         this.PropMaskType = PvMaskDefines.MaskType.ColumnWithDaysOfOneMonth;
      }

      #region IPvMaskObject

      /// <summary>
      /// Bezeichnung des BOs
      /// </summary>
      [DataMember]
      [DefaultValue("")]
      [MinLength(1)]
      [MaxLength(256)]
      public override string LongName
      {
         get { return base.LongName; }
         set
         {
            base.LongName = value;
         }
      }


      private PvMaskDefines.MaskType _propMaskType;

      [DataMember]
      [DefaultValue(1)]
      [JsonConverter(typeof(StringEnumConverter))]
      public PvMaskDefines.MaskType PropMaskType
      {
         get { return _propMaskType; }
         set
         {
            _propMaskType = value;
            ModifiedProperties.Add(nameof(PropMaskType));
         }
      }

      #endregion IPvMaskObject
   }
}