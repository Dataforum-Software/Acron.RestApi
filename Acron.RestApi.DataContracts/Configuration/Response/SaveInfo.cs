using Acron.RestApi.Interfaces.Configuration.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class SaveInfo : ISaveInfo
   {
      #region cTor
      public SaveInfo()
      { }

      public SaveInfo(bool success)
      {
         Saved = success;
      }

      #endregion cTor

      [DataMember]
      public bool Saved { get; set; } = false;
   }
}
