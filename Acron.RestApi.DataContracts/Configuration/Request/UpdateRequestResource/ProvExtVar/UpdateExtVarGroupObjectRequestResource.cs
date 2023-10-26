using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateExtVarGroupObjectRequestResource : UpdateRealGroupObjectRequestResource, IUpdateExtVarGroupObjectRequestResource
   {
      #region cTor

      public UpdateExtVarGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.ExtVarGroup)
      { }

      #endregion cTor

      public void SetProviderId(int providerId)
      {
         this._propIdProvider = providerId;
      }

      #region IExtVarGroupObject

      private int _propIdProvider = 0;

      [DataMember]
      [Required]
      public int PropIdProvider
      {
         get { return _propIdProvider; }
         private set
         {
            _propIdProvider = value;
            //   ModifiedProperties.Add(nameof(PropIdProvider));
         }
      }

      #endregion IExtVarGroupObject

   }
}
