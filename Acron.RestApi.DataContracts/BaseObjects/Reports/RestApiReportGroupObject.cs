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
   public class RestApiReportGroupObject : RestApiRealGroupObject, IReportGroupObject
   {
      #region cTor

      public RestApiReportGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ReportGroup)
      { }

      public RestApiReportGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IReportGroupObject iGrp = baseObject as IReportGroupObject;

         this._propGroupType = iGrp.PropGroupType;

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

      public void SetReferencedObjects(List<int> referencedIds)
      {
         if (referencedIds == null || !referencedIds.Any())
            _referencedIds = null;
         else
            _referencedIds = new List<int>(referencedIds);
      }

      #region IReportGroupObject

      private ReportGroupDefines.GroupType _propGroupType = ReportGroupDefines.GroupType.Standard;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public ReportGroupDefines.GroupType PropGroupType
      {
         get
         {
            return _propGroupType;
         }
      }

      #endregion IReportGroupObject

   }
}