using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdatePvVarGroupObjectRequestResource : UpdateGroupBaseObjectRequestResource, IUpdatePvVarGroupObjectRequestResource
   {
      #region cTor

      public UpdatePvVarGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.VgVarGroup)
      { }

      #endregion cTor

      // Keine Zusatz-Properties => kein mapper erforderlich
   }
}
