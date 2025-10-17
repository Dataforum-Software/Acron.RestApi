using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiServiceGroupObject : RestApiRealGroupObject, IServiceGroupObject
   {
      #region cTor

      public RestApiServiceGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ServiceGroup)
      { }

      public RestApiServiceGroupObject(object source)
         : base(source)
      { }

      #endregion cTor


      #region IServiceGroupObject

      #endregion IServiceGroupObject
   }
}