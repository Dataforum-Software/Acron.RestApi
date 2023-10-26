using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiPvVarGroupObject : RestApiRealGroupObject, IPvVarGroupObject
   {
      #region cTor

      public RestApiPvVarGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.VgVarGroup)
      { }

      public RestApiPvVarGroupObject(object source)
         : base(source)
      { }

      #endregion cTor


      #region IPvVarGroupObject

      #endregion IPvVarGroupObject
   }
}