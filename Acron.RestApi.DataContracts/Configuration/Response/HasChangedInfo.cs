using Acron.RestApi.Interfaces.Configuration.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class HasChangedInfo : IHasChangedInfo
   {
      #region cTor
      public HasChangedInfo()
      { }

      public HasChangedInfo(bool success)
      {
         HasChanged = success;
      }

      #endregion cTor

      [DataMember]
      public bool HasChanged { get; set; } = false;
   }
}
