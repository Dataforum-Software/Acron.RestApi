
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiConnectionGroupObject : RestApiRealGroupObject, IConnectionGroupObject
   {
      #region cTor

      public RestApiConnectionGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ConnectionGroup)
      { }

      public RestApiConnectionGroupObject(object source)
         : base(source)
      { }

      #endregion cTor


      #region IConnectionGroupObject

      #endregion IComnnectionGroupObject
   }
}