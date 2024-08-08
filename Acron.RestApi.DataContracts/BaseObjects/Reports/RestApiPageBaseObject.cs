using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiPageBaseObject : RestApiBaseObject, IPageBaseObject
   {
      #region cTor

      public RestApiPageBaseObject(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      public RestApiPageBaseObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IPageBaseObject iPg = baseObject as IPageBaseObject;

         this.ShortName = null;
         this.PropReportId = iPg.PropReportId;
         this.PropPageInfo = iPg.PropPageInfo;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         //ICreatePageBaseObjectRequestResource iGrp = baseObject as ICreatePageBaseObjectRequestResource;

         this.ShortName = null;
         //this.PropReportId = iPg.PropReportId;
         //this.PropPageInfo = iPg.PropPageInfo;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         //IUpdatePageBaseObjectRequestResource iGrp = baseObject as IUpdatePageBaseObjectRequestResource;

         this.ShortName = null;
         //this.PropReportId = iPg.PropReportId;
         //this.PropPageInfo = iPg.PropPageInfo;

         return true;
      }

      #region IPageBaseObject

      private int _propReportId = 0;
      [DataMember]
      public int PropReportId
      {
         get { return _propReportId; }
         private set 
         { 
            _propReportId = value;
         }
      }

      private string _propPageInfo = string.Empty;
      [DataMember]
      public string PropPageInfo 
      {
         get { return _propPageInfo; }
         set 
         { 
            _propPageInfo = value;
         }
      }

      #endregion IPageBaseObject

   }
}