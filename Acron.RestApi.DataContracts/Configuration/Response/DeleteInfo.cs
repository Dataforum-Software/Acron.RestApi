using Acron.RestApi.Interfaces.Configuration.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class DeleteInfo : IDeleteInfo
   {
      #region cTor
      public DeleteInfo()
      { }

      public DeleteInfo(bool success)
      {
         Deleted = success;
      }

      #endregion cTor

      [DataMember]
      public bool Deleted { get; set; } = false;
   }
}
