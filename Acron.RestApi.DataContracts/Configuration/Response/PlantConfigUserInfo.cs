using Acron.RestApi.Interfaces.Configuration.Response;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{
   [DataContract]
   public class PlantConfigUserInfo : IPlantConfigUserInfo
   {
      /// <summary>
      /// true if prperties are filled with valid values
      /// </summary>
      [DataMember]
      public bool ContentIsValid { get; set; }

      /// <summary>
      /// Program
      /// </summary>
      [DataMember] 
      public string Program { get; set; }

      /// <summary>
      /// HostOrIp
      /// </summary>
      [DataMember] 
      public string HostOrIp { get; set; }

      /// <summary>
      /// Port
      /// </summary>
      [DataMember] 
      public int Port { get; set; }

      /// <summary>
      /// ClientID
      /// </summary>
      [DataMember] 
      public long ClientID { get; set; }

      /// <summary>
      /// SessionID
      /// </summary>
      [DataMember] 
      public string SessionID { get; set; }

      /// <summary>
      /// user from acron user management
      /// </summary>
      [DataMember] 
      public string AcronUser { get; set; }

      /// <summary>
      /// Text with formated informations of complete content
      /// </summary>
      [DataMember] 
      public string DisplayText { get; set; }
   }
}
