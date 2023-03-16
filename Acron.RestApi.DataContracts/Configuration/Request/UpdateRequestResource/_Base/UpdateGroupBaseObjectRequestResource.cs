using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.UpdateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.UpdateRequestResources
{
   [DataContract]
   public class UpdateGroupBaseObjectRequestResource : UpdateBaseObjectRequestResource, IUpdateGroupBaseObjectRequestResource
   {
      #region cTor

      public UpdateGroupBaseObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

      #region IGroupBaseObject

      private bool _isDefaultGroup = false;

      [DataMember]
      public bool IsDefaultGroup
      {
         get
         {
            return _isDefaultGroup;
         }
      }

      #endregion IGroupBaseObject
   }
}
