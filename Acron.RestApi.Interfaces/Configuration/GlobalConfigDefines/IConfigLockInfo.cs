namespace Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines
{
    public enum ConfigOwner : int
    {
        Nobody = 0,
        Me,
        AnotherUser,
    }

    /// <summary>
    /// Rückgabewerte von ConfigLock-Aktionen
    /// </summary>
    public enum ConfigLockResult : int
    {
        Ok = 0,

        /// <summary> Server nicht vorhanden </summary>
        NoClientToDBServer,
        /// <summary> Keine aktive Anlage </summary>
        NoActivePlant,
        /// <summary> Aktive Anlage ist nicht komplett geladen</summary>
        ActivePlantNotLoaded,

        /// <summary> Status-Abfrage erfolgreich</summary>
        CheckOk,
        /// <summary> Der Aufruf des Servers mit dem Befehl zur Ermittelung des Register-Status schlug fehl</summary>
        CheckRegisterFailed,
        /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
        CheckRegisterUnknown,

        /// <summary> Config-Lock wurde aufgehoben</summary>
        ResetOk,
        /// <summary> Unlock nicht möglich - mir gehört der ConfigLock nicht </summary>
        ResetIamNotOwner,
        /// <summary> Unlock nicht möglich - es liegt kein Lock vor </summary>
        ResetNoLock,
        /// <summary> Unlock abgebrochen wegen offenen Änderungen</summary>
        ResetCancelOpenChanges,
        /// <summary> Der Aufruf des Servers mit dem Unregister-Befehl schlug fehl</summary>
        ResetUnregisterFailed,
        /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
        ResetUnregisterUnknown,

        /// <summary> Config-Lock wurde gesetzt</summary>
        SetOk,
        /// <summary> Lock nicht möglich - in der Anlagenverwaltung ist der Zugriff auf die Konfiguration für dieses Modul nicht freigegeben </summary>
        SetNoConfigAccess,
        /// <summary> Lock nicht möglich - ich habe ihn bereits </summary>
        SetAlreadyLockedByMe,
        /// <summary> Lock nicht möglich - ein anderer Benutzer hat den Lock </summary>
        SetAlreadyLockedByAnotherUser,
        /// <summary> Lock nicht möglich - Zeitstempel nicht aktuell </summary>
        SetInvalidTimeStamps,
        /// <summary> Lock fehlgeschlagen - Aufruf des Servers schlug fehl </summary>
        SetRegisterFailed,
        /// <summary> Lock fehlgeschlagen - Unbekannter Server-Fehler </summary>
        SetRegisterUnknown,
    }

    public interface IConfigLockInfo
    {
        ConfigLockResult LastActionResult { get; set; }

        ConfigOwner Owner { get; set; }

        string OwnerName { get; }

    }
}