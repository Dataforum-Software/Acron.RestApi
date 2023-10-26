using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateConnectionGroupObjectRequestResource : UpdateRealGroupObjectRequestResource, IUpdateConnectionGroupObjectRequestResource
   {
      #region cTor

      public UpdateConnectionGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.ConnectionGroup)
      { }

      #endregion cTor

      // Keine Zusatz-Properties => kein mapper erforderlich
   }
}
