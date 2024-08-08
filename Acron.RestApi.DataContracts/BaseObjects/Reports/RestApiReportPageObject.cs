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
   public class RestApiReportPageObject : RestApiPageBaseObject, IReportPageObject
   {
      #region cTor

      public RestApiReportPageObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ReportPage)
      { }

      public RestApiReportPageObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IReportPageObject iPg = baseObject as IReportPageObject;

         this.PropFormularType = iPg.PropFormularType;
         this.PropFormularSource = iPg.PropFormularSource;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         //ICreateAlertGroupObjectRequestResource iGrp = baseObject as ICreateReportGroupObjectRequestResource;

         //this._propGroupType = iGrp.PropGroupType;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         //IUpdateReportGroupObjectRequestResource iGrp = baseObject as IUpdateReportGroupObjectRequestResource;

         //this._propGroupType = iGrp.PropGroupType;

         return true;
      }

      #region IReportPageObject

      private PageBaseDefines.FormularType _propFormularType = PageBaseDefines.FormularType.Unknown;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PageBaseDefines.FormularType PropFormularType
      {
         get { return _propFormularType; }
         private set 
         { 
            _propFormularType = value;
         }
      }

      private PageBaseDefines.DataSource _propFormularSource = PageBaseDefines.DataSource.Unknown;
      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public PageBaseDefines.DataSource PropFormularSource 
      {
         get { return _propFormularSource; }
         set 
         {
            _propFormularSource = value;
         }
      }

      #endregion IReportPageObject

   }
}