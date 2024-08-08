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
   public class RestApiEventObject : RestApiEventBaseObject, IEventObject
   {
      #region cTor

      public RestApiEventObject()
         : base(BaseObjectDefines.RestObjectTypeCode.Event)
      { }

      public RestApiEventObject(object source)
         : base(source)
      { }

      #endregion cTor


      #region IEventObject

      #endregion IEventObject
   }
}