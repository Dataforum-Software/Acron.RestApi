using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateGroupBaseObjectRequestResource : CreateBaseObjectRequestResource, ICreateGroupBaseObjectRequestResource
   {
      #region cTor

      public CreateGroupBaseObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
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
