using Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Acron.RestApi.DataContracts.Configuration.Response
{
   
   [DataContract]
   public class ConfigLockInfo : IConfigLockInfo
   {

      #region cTor

      public ConfigLockInfo(bool? status):this(status, null, null, false)
      {}

      public ConfigLockInfo(bool? status, string host, string user, bool ownerMe)
      {
         SetConfigOwner(status);

         OwnerHost = host;
         OwnerUser = user;
         OwnerMe = ownerMe;
      }

      #endregion cTor

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public ConfigLockResult LastActionResult { get; set; }

      /// <summary>
      /// Name des den Lock besitzenden Programmes 
      /// </summary>
      public string OwnerProgram { get; set; }

      /// <summary>
      /// Hostname des aktuellen Config-Zugriffs
      /// </summary>
      public string OwnerHost { get; set; }

      /// <summary>
      /// Loginname des aktuellen Config-Zugriffs
      /// </summary>
      public string OwnerUser { get; set; }

      /// <summary>
      /// true - diese Konfiguration hat den Zugriff auf die Config
      /// </summary>
      public bool OwnerMe { get; set; }

      /// <summary>
      /// Login des Benutzers, der den Config-Zugriff besitzt
      /// </summary>
      /// <remarks>
      /// Wird nur gefüllt, wenn die aktuelle Config den Zugriff hat.
      /// Benötigt für RestAPI. Andernfalls ist dies der Login des aktuellen Benutzers
      /// </remarks>
      public string LocalLoggedUser { get; set; }

      //public AcronProgramInfo.AcronProgID IdOfLockingProgram { get; set; }

      [DataMember]
      [JsonConverter(typeof(StringEnumConverter))]
      public ConfigOwner Owner { get; set; }

      [DataMember]
      public string OwnerName
      {
         get
         {
            return OwnerHost + " / " + OwnerUser;
         }
      }

      /// <summary>
      /// true - Zugriff auf Config wurde entfernt, Änderungen sind aber noch offen
      /// </summary>
      public bool DoLogout { get; set; }

      public bool? IsLocked
      {
         get
         {
            switch (Owner)
            {
               case ConfigOwner.Nobody:
                  return null;

               case ConfigOwner.Me:
                  return true;

               case ConfigOwner.AnotherUser:
                  return false;

               default:
                  break;
            }

            return null;
         }
      }

      public void SetConfigOwner(bool? status)
      {
         if (status == null)
            Owner = ConfigOwner.Nobody;
         else if (status == false)
            Owner = ConfigOwner.AnotherUser;
         else if (status == true)
            Owner = ConfigOwner.Me;
      }

   }
}
