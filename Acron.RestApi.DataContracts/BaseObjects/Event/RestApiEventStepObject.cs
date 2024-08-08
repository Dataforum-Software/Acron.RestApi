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
   public class RestApiEventStepObject : RestApiEventBaseObject, IEventStepObject
   {
      #region cTor

      public RestApiEventStepObject()
         : base(BaseObjectDefines.RestObjectTypeCode.EventStep)
      { }

      public RestApiEventStepObject(object source)
         : base(source)
      { }

      #endregion cTor


      #region IEventStepObject

      #endregion IEventStepObject
   }
}