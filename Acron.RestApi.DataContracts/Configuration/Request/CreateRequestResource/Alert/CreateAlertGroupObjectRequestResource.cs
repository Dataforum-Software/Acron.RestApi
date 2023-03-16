using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateAlertGroupObjectRequestResource : CreateGroupBaseObjectRequestResource, ICreateAlertGroupObjectRequestResource
   {
      #region cTor

      public CreateAlertGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.AlertGroup)
      { }


      #endregion cTor


      [DataMember]
      [Required]
      public override string LongName 
      {
         get { return base.LongName; }
         set { base.LongName = value; }
      }

      #region IAlertGroupObject

      private AlertGroupDefines.GroupType _propGroupType = AlertGroupDefines.GroupType.UserDefined;

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public AlertGroupDefines.GroupType PropGroupType
      {
         get
         {
            return _propGroupType;
         }
      }

      #endregion IAlertGroupObject

   }
}
