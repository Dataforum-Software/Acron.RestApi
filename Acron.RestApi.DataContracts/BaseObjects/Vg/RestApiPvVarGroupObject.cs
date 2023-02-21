using Acron.RestApi.Interfaces.BaseObjects;
using System.Runtime.Serialization;

namespace Acron.RestApi.BaseObjects
{
   
   [DataContract]
   public class RestApiPvVarGroupObject : RestApiGroupBaseObject, IPvVarGroupObject
   {
      #region cTor

      public RestApiPvVarGroupObject()
         : base(BaseObjectDefines.RestObjectTypeCode.VgVarGroup)
      { }

      public RestApiPvVarGroupObject(object source)
         : base(source)
      { }

      #endregion cTor

      // Keine Zusatz-Properties => kein mapper erforderlich
   }
}