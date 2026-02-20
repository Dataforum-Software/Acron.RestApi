using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateProviderBaseObjectRequestResource : CreateGroupBaseObjectRequestResource, ICreateProviderBaseObjectRequestResource
   {
      #region cTor

      public CreateProviderBaseObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
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

      [OnDeserialized]
      private void OnDeserialized(StreamingContext context)
      {

      }

      #endregion IProviderBaseObject
   }
}
