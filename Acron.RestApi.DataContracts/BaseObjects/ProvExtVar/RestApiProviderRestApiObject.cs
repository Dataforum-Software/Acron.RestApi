using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiProviderRestApiObject : RestApiProviderBaseObject
   {
      #region cTor

      public RestApiProviderRestApiObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ProviderRestApi)
      { }

      public RestApiProviderRestApiObject(object source)
         : base(source)
      { }

      #endregion cTor
   }
}