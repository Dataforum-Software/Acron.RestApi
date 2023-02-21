
using Acron.RestApi.Interfaces.BaseObjects;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiConnectionGroupObject : RestApiGroupBaseObject, IConnectionGroupObject
   {
      #region cTor

      public RestApiConnectionGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.ConnectionGroup)
      { }

      public RestApiConnectionGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      // Keine Zusatz-Properties => kein mapper erforderlich
   }
}