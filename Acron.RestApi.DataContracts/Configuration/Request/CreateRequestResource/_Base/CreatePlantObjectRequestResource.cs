using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreatePlantObjectRequestResource : CreateBaseObjectRequestResource, ICreatePlantObjectRequestResource
   {
      #region cTor

      public CreatePlantObjectRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.Plant)
      { }

      #endregion cTor

      protected override void setDefaultValues()
      {
         base.setDefaultValues();
      }

      #region IPlantObject

      private string _propVersion;

      /// <summary> Version der Anlage </summary>
      [DataMember]
      public string PropVersion
      {
         get { return _propVersion; }
         private set
         {
            _propVersion = value;
            ModifiedProperties.Add(nameof(PropVersion));
         }
      }

      #endregion IPlantObject
   }
}
