using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateConnectionGroupObjectRequestResource : CreateGroupBaseObjectRequestResource, ICreateConnectionGroupObjectRequestResource
   {
      #region cTor

      public CreateConnectionGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.ConnectionGroup)
      { }

      #endregion cTor

      // Keine Zusatz-Properties => kein mapper erforderlich

      [DataMember]
      [Required]
      public override string LongName
      {
         get { return base.LongName; }
         set { base.LongName = value; }
      }

   }
}
