using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiProviderNoConfigObject : RestApiProviderBaseObject
   {
      #region cTor

      public RestApiProviderNoConfigObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ProviderNoConfig)
      { }

      public RestApiProviderNoConfigObject(object source)
         : base(source)
      { }

      #endregion cTor
   }
}