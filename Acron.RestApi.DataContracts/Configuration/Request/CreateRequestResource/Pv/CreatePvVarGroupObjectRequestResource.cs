using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreatePvVarGroupObjectRequestResource : CreateGroupBaseObjectRequestResource, ICreatePvVarGroupObjectRequestResource
   {
      #region cTor

      public CreatePvVarGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.VgVarGroup)
      { }

      #endregion cTor

      [DataMember]
      [Required]
      public override string LongName
      {
         get { return base.LongName; }
         set { base.LongName = value; }
      }

      // Keine Zusatz-Properties => kein mapper erforderlich
   }
}
