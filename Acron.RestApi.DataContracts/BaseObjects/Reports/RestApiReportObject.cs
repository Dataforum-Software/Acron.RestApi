using Acron.RestApi.Interfaces;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiReportObject : RestApiBaseObject, IReportObject
   {
      #region cTor

      public RestApiReportObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Report)
      { }

      public RestApiReportObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IReportObject iRep = baseObject as IReportObject;

         this._propReportKind = iRep.PropReportKind;
         this._propNeedIntervalWidth = iRep.PropNeedIntervalWidth;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         //ICreateReportObjectRequestResource iRep = baseObject as ICreateReportObjectRequestResource;

         //this._propReportKind = iRep.PropReportKind;
         //this._propNeedIntervalWidth = iRep.PropNeedIntervalWidth;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         //IUpdateReportObjectRequestResource iRep = baseObject as IUpdateReportObjectRequestResource;

         //this._propReportKind = iRep.PropReportKind;
         //this._propNeedIntervalWidth = iRep.PropNeedIntervalWidth;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this._propReportKind =  ReportDefines.ReportKind.FRM_DAY;
         this._propNeedIntervalWidth = false;
      }

      #region IReportObject

      private ReportDefines.ReportKind _propReportKind = ReportDefines.ReportKind.FRM_DAY;

      /// <summary> Report kind </summary>
      [DataMember]
      [DefaultValue(-1)]
      [JsonConverter(typeof(StringEnumConverter))]
      public ReportDefines.ReportKind PropReportKind 
      {
         get { return _propReportKind; }
      }

      private bool _propNeedIntervalWidth = false;

      /// <summary> Need interval width </summary>
      [DataMember]
      public bool PropNeedIntervalWidth 
      {
         get { return _propNeedIntervalWidth; }
      }

      #endregion IReportObject
   }
}