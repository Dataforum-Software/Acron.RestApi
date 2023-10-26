using Acron.RestApi.BaseObjects;
using Acron.RestApi.Interfaces.BaseObjects;
using Acron.RestApi.Interfaces.Configuration.Request.CreateRequestResponses;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Request.CreateRequestResources
{
   [DataContract]
   public class CreateRealGroupObjectRequestResource : CreateGroupBaseObjectRequestResource, ICreateRealGroupObjectRequestResource
   {
      #region cTor

      public CreateRealGroupObjectRequestResource(BaseObjectDefines.RestObjectTypeCode typeCode)
         : base(typeCode)
      { }

      #endregion cTor

      #region IGroupBaseObject

      private string _propGroupInfo = string.Empty;

      [DataMember]
      public string PropGroupInfo
      {
         get { return _propGroupInfo; }
         set
         {
            _propGroupInfo = value;
         }
      }

      private int _propColorIndex = 0;

      [DataMember]
      public int PropColorIndex
      {
         get { return _propColorIndex; }
         set
         {
            _propColorIndex = value;
         }
      }

      #endregion IGroupBaseObject
   }
}
