using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateUnitBaseRequestResource : UpdateGroupBaseObjectRequestResource, IUpdateUnitBaseRequestResource
   {
      #region cTor

      public UpdateUnitBaseRequestResource()
         : base(BaseObjectDefines.RestObjectTypeCode.Unit)
      { }

      public UpdateUnitBaseRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

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
