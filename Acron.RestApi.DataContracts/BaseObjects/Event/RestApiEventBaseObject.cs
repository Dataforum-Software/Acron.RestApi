using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiEventBaseObject : RestApiBaseObject, IEventBaseObject
   {
      #region cTor

      public RestApiEventBaseObject(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      public RestApiEventBaseObject(object source)
         : base(source)
      { }

      #endregion cTor

      protected override bool memberMapperBaseObject(object baseObject)
      {
         if (!base.memberMapperBaseObject(baseObject))
            return false;

         IEventBaseObject iEv = baseObject as IEventBaseObject;
//         this.PropState = iEv.PropState;

         return true;
      }

      protected override bool memberMapperCreate(object baseObject)
      {
         if (!base.memberMapperCreate(baseObject))
            return false;

         // ToDo
         //ICreateEventBaseObjectRequestResource iAl = baseObject as ICreateEventBaseObjectRequestResource;
         //this.PropState = iAl.PropState;

         return true;
      }

      protected override bool memberMapperUpdate(object baseObject)
      {
         if (!base.memberMapperUpdate(baseObject))
            return false;

         // ToDo
         //IUpdateEventObjectRequestResource iEv = baseObject as IUpdateEventObjectRequestResource;
         //this.PropState = iEv.PropState;

         return true;
      }

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         // ToDo
         //this.PropState = AlertDefines.AlertState.Disturbance;
      }


      #region IEventBaseObject



      #endregion IEventBaseObject

   }


}
