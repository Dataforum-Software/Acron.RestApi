using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{

   [DataContract]
   public class RestApiPvMaskGroupObject : RestApiRealGroupObject, IPvMaskGroupObject
   {
      #region cTor

      public RestApiPvMaskGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.PvMaskGroup)
      { }

      public RestApiPvMaskGroupObject(object source)
         : base(source)
      { }

      #endregion cTor


      #region IPvMaskGroupObject

      #endregion IPvMaskGroupObject
   }
}