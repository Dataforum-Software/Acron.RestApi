using Swashbuckle.AspNetCore.Annotations;

namespace Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines
{
   public enum ConfigOwner : int
   {
      [SwaggerEnumInfo("Config not locked")]
      Nobody = 0,

      [SwaggerEnumInfo("Config locked by current user")]
      Me,

      [SwaggerEnumInfo("Config locked by another user")]
      AnotherUser,
   }

   /// <summary>
   /// Rückgabewerte von ConfigLock-Aktionen
   /// </summary>
   public enum ConfigLockResult : int
   {
      Ok = 0,

      /// <summary> Server nicht vorhanden </summary>
      [SwaggerEnumInfo("Connecting to database server failed")]
      NoClientToDBServer,

      /// <summary> Keine aktive Anlage </summary>
      [SwaggerEnumInfo("Active plant not set")]
      NoActivePlant,

      [SwaggerEnumInfo("Active plant not loaded")]
      /// <summary> Aktive Anlage ist nicht komplett geladen</summary>
      ActivePlantNotLoaded,

      [SwaggerEnumInfo("Status check successful")]
      /// <summary> Status-Abfrage erfolgreich</summary>
      CheckOk,

      [SwaggerEnumInfo("Checking registered user failed")]
      /// <summary> Der Aufruf des Servers mit dem Befehl zur Ermittelung des Register-Status schlug fehl</summary>
      CheckRegisterFailed,

      [SwaggerEnumInfo("Checking registered user encountered unknown error")]
      /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
      CheckRegisterUnknown,

      [SwaggerEnumInfo("Config lock reset sucessfully")]
      /// <summary> Config-Lock wurde aufgehoben</summary>
      ResetOk,

      [SwaggerEnumInfo("Config lock reset failed, current user is not config lock owner")]
      /// <summary> Unlock nicht möglich - mir gehört der ConfigLock nicht </summary>
      ResetIamNotOwner,

      [SwaggerEnumInfo("Config lock reset failed, config is not locked")]
      /// <summary> Unlock nicht möglich - es liegt kein Lock vor </summary>
      ResetNoLock,

      [SwaggerEnumInfo("Config lock reset failed, current user has unsaved changes")]
      /// <summary> Unlock abgebrochen wegen offenen Änderungen</summary>
      ResetCancelOpenChanges,

      [SwaggerEnumInfo("Config lock reset failed")]
      /// <summary> Der Aufruf des Servers mit dem Unregister-Befehl schlug fehl</summary>
      ResetUnregisterFailed,

      [SwaggerEnumInfo("Config lock reset encountered unknown error")]
      /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
      ResetUnregisterUnknown,

      [SwaggerEnumInfo("Config lock set sucessful")]
      /// <summary> Config-Lock wurde gesetzt</summary>
      SetOk,

      [SwaggerEnumInfo("Config lock set failed, config access for REST API is disabled in plant settings")]
      /// <summary> Lock nicht möglich - in der Anlagenverwaltung ist der Zugriff auf die Konfiguration für dieses Modul nicht freigegeben </summary>
      SetNoConfigAccess,

      [SwaggerEnumInfo("Config lock set failed, current user is already config lock owner")]
      /// <summary> Lock nicht möglich - ich habe ihn bereits </summary>
      SetAlreadyLockedByMe,

      [SwaggerEnumInfo("Config lock set failed, another user is config lock owner")]
      /// <summary> Lock nicht möglich - ein anderer Benutzer hat den Lock </summary>
      SetAlreadyLockedByAnotherUser,

      [SwaggerEnumInfo("Config lock set failed, plant config not up to date")]
      /// <summary> Lock nicht möglich - Zeitstempel nicht aktuell </summary>
      SetInvalidTimeStamps,

      [SwaggerEnumInfo("Config lock set failed, connection to database server lost")]
      /// <summary> Lock fehlgeschlagen - Aufruf des Servers schlug fehl </summary>
      SetRegisterFailed,

      [SwaggerEnumInfo("Config lock set failed, operation encountered unknown error")]
      /// <summary> Lock fehlgeschlagen - Unbekannter Server-Fehler </summary>
      SetRegisterUnknown,
   }

   public interface IConfigLockInfo
   {
      [SwaggerSchema("Operation result")]
      [SwaggerExampleValue(ConfigLockResult.Ok)]
      ConfigLockResult LastActionResult { get; set; }

      [SwaggerSchema("Config locked for nobody/me/another user")]
      [SwaggerExampleValue(ConfigOwner.Nobody)]
      ConfigOwner Owner { get; set; }

      [SwaggerSchema("User name of config lock owner")]
      [SwaggerExampleValue("")]
      string OwnerName { get; }

   }
}