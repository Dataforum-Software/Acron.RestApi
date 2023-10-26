using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateExtVarGroupObjectRequestResource : CreateRealGroupObjectRequestResource, ICreateExtVarGroupObjectRequestResource
   {
      #region cTor

      public CreateExtVarGroupObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.ExtVarGroup)
      { }

      #endregion cTor

      public void SetProviderId(int providerId)
      {
         this._propIdProvider = providerId;
      }

      [DataMember]
      [Required]
      public override string LongName
      {
         get { return base.LongName; }
         set { base.LongName = value; }
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
