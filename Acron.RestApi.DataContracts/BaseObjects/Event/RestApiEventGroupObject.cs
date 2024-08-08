using Acron.RestApi.Interfaces;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiEventGroupObject : RestApiRealGroupObject, IEventGroupObject
   {
      #region cTor

      public RestApiEventGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.EventGroup)
      { }

      public RestApiEventGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IEventGroupObject iGrp = baseObject as IEventGroupObject;
         this.PropReportId = iGrp.PropReportId;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         // ToDo
         //ICreateEventGroupObjectRequestResource iGrp = baseObject as ICreateEventGroupObjectRequestResource;
         //this.PropReportId = iGrp.PropReportId;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         // ToDo
         //IUpdateEventGroupObjectRequestResource iGrp = baseObject as IUpdateEventGroupObjectRequestResource;
         //this.PropReportId = iGrp.PropReportId;

         return true;
      }

      public void SetReferencedObjects(List<int> referencedIds)
      {
         if (referencedIds == null || !referencedIds.Any())
            _referencedIds = null;
         else
            _referencedIds = new List<int>(referencedIds);
      }

      #region IEventGroupObject

      private int _propReportId = 0;

      /// <summary>
      /// Id of event report of this group
      /// </summary>
      public int PropReportId
      {
         get { return _propReportId; }
         set
         {
            _propReportId = value;
            ModifiedProperties.Add(nameof(PropReportId));
         }
      }

      #endregion IEventGroupObject

   }
}