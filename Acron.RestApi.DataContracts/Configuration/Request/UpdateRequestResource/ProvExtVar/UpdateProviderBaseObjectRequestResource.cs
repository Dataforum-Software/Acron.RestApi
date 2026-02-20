using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateProviderBaseObjectRequestResource : UpdateGroupBaseObjectRequestResource, IUpdateProviderBaseObjectRequestResource
   {
      #region cTor

      public UpdateProviderBaseObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

      #region IProviderBaseObject

      private int _propProviderId;

      [DataMember]
      [Range(1, 99)]
      public int PropProviderId
      {
         get { return _propProviderId; }
         set
         {
            _propProviderId = value;
            ModifiedProperties.Add(nameof(PropProviderId));
         }
      }

      #endregion IProviderBaseObject
   }
}
