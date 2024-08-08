using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiModelPageObject : RestApiPageBaseObject, IModelPageObject
   {
      #region cTor

      public RestApiModelPageObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ModelPage)
      { }

      public RestApiModelPageObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IModelPageObject iPg = baseObject as IModelPageObject;

         this.ShortName = null;
         this.PropType = iPg.PropType;
         this.PropNumber = iPg.PropNumber;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         //ICreateModelPageObjectRequestResource iGrp = baseObject as ICreateModelPageObjectRequestResource;

         this.ShortName = null;
         //this.PropType = iPg.PropType;
         //this.PropNumber = iPg.PropNumber;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         //IUpdateModelPageObjectRequestResource iGrp = baseObject as IUpdateModelPageRequestResource;

         this.ShortName = null;
         //this.PropType = iPg.PropType;
         //this.PropNumber = iPg.PropNumber;

         return true;
      }

      #region IModelPageObject

      private PageBaseDefines.Type _propType = PageBaseDefines.Type.ModelUnknown;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PageBaseDefines.Type PropType
      {
         get { return _propType; }
         private set 
         {
            _propType = value;
         }
      }

      private int _propNumber=0;
      [DataMember]
      public int PropNumber 
      { 
         get { return _propNumber; }
         set 
         {
            _propNumber = value;
         }
      }

      #endregion IModelPageObject

   }
}