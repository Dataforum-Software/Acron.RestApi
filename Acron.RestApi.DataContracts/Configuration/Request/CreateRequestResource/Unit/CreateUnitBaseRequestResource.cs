using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateUnitBaseRequestResource : CreateGroupBaseObjectRequestResource, ICreateUnitBaseRequestResource
   {
      #region cTor

      public CreateUnitBaseRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();

         this.PropDescription = string.Empty;
      }

      [DataMember]
      [Required]
      public override string ShortName
      {
         get { return base.ShortName; }
         set { base.ShortName = value; }
      }

      [DataMember]
      [Required]
      public override string LongName
      {
         get { return base.LongName; }
         set { base.LongName = value; }
      }

      #region IUnitBase

      private string _propDescription;
      [DataMember]
      public string PropDescription
      {
         get { return _propDescription; }
         set
         {
            _propDescription = value;
            ModifiedProperties.Add(nameof(PropDescription));
         }
      }

      #endregion IUnitBase
   }
}
