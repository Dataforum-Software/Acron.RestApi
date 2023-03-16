using Acron.RestApi.Interfaces.Configuration.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{

   [DataContract]
   public class DiscardChangesInfo : IDiscardChangesInfo
   {
      #region cTor
      public DiscardChangesInfo()
      { }

      public DiscardChangesInfo(bool success)
      {
         ChangesDiscarded = success;
      }

      #endregion cTor

      [DataMember]
      public bool ChangesDiscarded { get; set; } = false;
   }
}
