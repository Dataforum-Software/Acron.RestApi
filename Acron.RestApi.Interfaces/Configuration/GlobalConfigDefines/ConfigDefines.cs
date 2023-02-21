using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines
{
   public static class ConfigDefines
    {

        static private Dictionary<ApiActionResult, string> _actionResultTexts
           = new Dictionary<ApiActionResult, string>()
        {
         /// <summary> Einwandfrei abgearbeitet </summary>
         { ApiActionResult.Ok, "ok" },

         /// <summary> FEHLER - Fehlender Übergabeparameter </summary>
         { ApiActionResult.ErrorParam, "Missing parameter" },
         /// <summary> FEHLER - Unerwarteter Ausnahmefehler </summary>
         { ApiActionResult.ErrorException, "An exception occured" },

         /// <summary> Exception bei der Initialisierung des PlantConfigManagers </summary>
         { ApiActionResult.ErrorExceptionInit, "Init plant config manager - an exception occured." },
         /// <summary> Anlage wurde nicht gefunden </summary>
         { ApiActionResult.ErrorPlantNotFound, "Init plant config manager - plant not found." },
         /// <summary> Exception bei Anlagensuche </summary>
         { ApiActionResult.ErrorExceptionFindPlant, "Init plant config manager - exception while searching for plant." },
         /// <summary> Exception bei PathLocator </summary>
         { ApiActionResult.ErrorExceptionPathLocator, "Init plant config manager - exception while creating plant path locator." },
         /// <summary> Keine Infos zur BV erhalten </summary>
         { ApiActionResult.ErrorGetUserManagement, "Init plant config manager - user management can not be detected." },
         /// <summary> Benutzerverwaltung der Anlage ist deaktiviert </summary>
         { ApiActionResult.ErrorNoUserManagement, "Init plant config manager - user management is not active." },
         /// <summary> Benutzerverwaltung der Anlage hat keine Benutzer </summary>
         { ApiActionResult.ErrorNoUsers, "Init plant config manager - user management without users." },


         /// <summary> Schreibzugriff kann nicht ermittelt werden</summary>
         { ApiActionResult.ErrorConfigAccessDetection, "Config access can not be detected." },


         /// <summary> Kontaktierung des DBServers wirft Exception </summary>
         { ApiActionResult.ErrorDBServerException, "Exception from DBServer." },


         /// <summary> Exception beim neu Laden der Anlage </summary>
         { ApiActionResult.ErrorLoadPlantException, "Exception while loading plant." },
         /// <summary> Exception beim neu Laden der Anlage </summary>
         { ApiActionResult.ErrorReloadPlantException, "Exception while reloading plant." },


         /// <summary> Speichern der Anlage schlug fehl </summary>
         { ApiActionResult.ErrorSaveFailed, "Saving of plant configuration failed." },
         /// <summary> Exception beim Speichern </summary>
         { ApiActionResult.ErrorSaveException, "Exception while saving plant configuration." },



         /// <summary> Benutzer hat keinen Zugriff auf diesen Bereich </summary>
         { ApiActionResult.RegionAccessDenied, "User has no access to region." },
         /// <summary> Die API unterstützt diesen Bereich der Konfiguration zur Zeit nicht </summary>
         { ApiActionResult.RegionNotSupported, "Region not supported by RestAPI." },
         /// <summary> Die API unterstützt diesen Typecode zur Zeit nicht </summary>
         { ApiActionResult.TypeCodeNotSupported, "Typecode not supported by RestAPI" },
         /// <summary> Update/Create - es wurden keine geeigneten Objekte übergegeben </summary>
         { ApiActionResult.NoInterfaceObjectsOfGivenType, "Typecode of given objects does not match given type code" },  //e.g. TypeCode =Alerts, Objects==PVs
         /// <summary> Das BaseObject mit der angegebenen Id ist nicht in der Konfiguration enthalten </summary>
         { ApiActionResult.BaseObjectNotFound, "BaseObject with given id does not exist." },

         /// <summary> Die RestAPI ist unter Vollast und kann keine Anfaragen beantworten </summary>
         { ApiActionResult.ApiToBusy, "RestAPI is busy.." },

         #region User Management

         /// <summary> Benutzerverwaltung der Anlage ist nicht aktiv </summary>
         { ApiActionResult.UserCheckNoUserManagement, "User management is not active." },
         /// <summary> Benutzer nicht gefunden </summary>
         { ApiActionResult.UserCheckUserNotFound, "User with given login does not exist." },
         /// <summary> Falsches Pwd </summary>
         { ApiActionResult.UserCheckPwd, "Wrong password." },

         #endregion User Management

         #region Config Access Infos

         /// <summary> RestAPI hat keinen Schreibzugriff auf die Konfiguration</summary>
         { ApiActionResult.RestApiConfigWriteAccess, "RestAPI has no write access to configuration." },
         /// <summary> Benutzer hat keinen Exclusiv-Schreibzugriff </summary>
         { ApiActionResult.NoConfigWriteAccess, "User has no config access." },
         /// <summary> Keiner hat den Exclusiv-Schreibzugriff </summary>
         { ApiActionResult.ConfigAccessNobody, "Nobody has config access." },
         /// <summary> Ein anderer Benutzer hat den Exclusiv-Schreibzugriff </summary>
         { ApiActionResult.ConfigAccessOtherUser, "Another user has config access." },
         /// <summary> Properties können nicht geändert werden </summary>
         { ApiActionResult.ConfigChangesLocked, "Properties can not be changed." },

         /// <summary> Server nicht vorhanden </summary>
         { ApiActionResult.ConfigAccessNoClientToDBServer, "Config access - no access DBServer." },
         /// <summary> Keine aktive Anlage </summary>
         { ApiActionResult.ConfigAccessNoActivePlant, "Config access - no active plant." },
         /// <summary> Aktive Anlage ist nicht komplett geladen</summary>
         { ApiActionResult.ConfigAccessActivePlantNotLoaded, "Config access - active plant is not completely loaded." },

         /// <summary> Der Aufruf des Servers mit dem Befehl zur Ermittelung des Register-Status schlug fehl</summary>
         { ApiActionResult.ConfigAccessCheckRegisterFailed, "Check config access - request to DBServer failed." },
         /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
         { ApiActionResult.ConfigAccessCheckRegisterUnknown, "Check config access - unknown error." },

         /// <summary> Unlock nicht möglich - mir gehört der ConfigLock nicht </summary>
         { ApiActionResult.ConfigAccessResetIamNotOwner, "Reset config access - another user has config access." },
         /// <summary> Unlock nicht möglich - es liegt kein Lock vor </summary>
         { ApiActionResult.ConfigAccessResetNoLock, "Reset config access - nobody has config access." },
         /// <summary> Unlock abgebrochen wegen offenen Änderungen</summary>
         { ApiActionResult.ConfigAccessResetCancelOpenChanges, "Reset config access - open changes exist." },
         /// <summary> Der Aufruf des Servers mit dem Unregister-Befehl schlug fehl</summary>
         { ApiActionResult.ConfigAccessResetUnregisterFailed, "Reset config access - request to DBServer failed." },
         /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
         { ApiActionResult.ConfigAccessResetUnregisterUnknown, "Reset config access - unknown error." },

         /// <summary> Lock nicht möglich - ich habe ihn bereits </summary>
         { ApiActionResult.ConfigAccessSetAlreadyLockedByMe, "Set config access - user has already access." },
         /// <summary> Lock nicht möglich - ein anderer Benutzer hat den Lock </summary>
         { ApiActionResult.ConfigAccessSetAlreadyLockedByAnotherUser, "Set config access - another user has config access." },
         /// <summary> Lock nicht möglich - Zeitstempel nicht aktuell </summary>
         { ApiActionResult.ConfigAccessSetInvalidTimeStamps, "Set config access - invalid time stamps." },
         /// <summary> Lock fehlgeschlagen - Aufruf des Servers schlug fehl </summary>
         { ApiActionResult.ConfigAccessSetRegisterFailed, "Set config access - request to DBServer failed." },
         /// <summary> Lock fehlgeschlagen - Unbekannter Server-Fehler </summary>
         { ApiActionResult.ConfigAccessSetRegisterUnknown, "Set config access - unknown error." },

         #endregion Config Access Infos

         #region Delete

         /// <summary> Das BaseObject konnte nicht gelöscht werden, da es von anderen BaseObjects verwendet wird </summary>
         { ApiActionResult.DeleteFailedObjectUsed, "Delete object - object is used by other objects." },
         /// <summary> Das BaseObject konnte nicht gelöscht werden </summary>
         { ApiActionResult.DeleteFailedGeneral, "Delete object - unknown error." },

         #endregion Delete

         #region DBServer communication

         /// <summary> Allgemeiner Verbindungsfehler zum DBServer </summary>
         { ApiActionResult.DBServerGeneral, "General connection error to DBServer." },
         /// <summary> DBServer läuft nicht </summary>
         { ApiActionResult.DBServerNotRunning, "DBServer is not running." },
         /// <summary> DBServer meldet : Anlage hat die false Version </summary>
         { ApiActionResult.DBServerPlantNeedsUpdate, "DBServer - plant needs update." },

         #endregion DBServer communication

         #region Save

         /// <summary> Speichern nicht möglich - es gibt keine Änderungen </summary>
         { ApiActionResult.SaveNoChanges, "Save config - no changes exist." },
         /// <summary> Speichern nicht möglich - Anlage wurde nicht validiert </summary>
         { ApiActionResult.SaveMissingValidation, "Save config - missing validation call." },

               #endregion Save

        };

        #region Defines

        /// <summary>
        /// Der Name der mitgelieferten XSD Datei zum Parsen der Acron*_de-de.xml und anderer Sprachdateien
        /// </summary>
        public const string LanguageXSD = "Language.xsd";

        #endregion Defines

        static private Dictionary<string, string> _userDefinedTexts = new Dictionary<string, string>();

        private static string _guiPath
        {
            get
            {
                string appPath = AppDomain.CurrentDomain.BaseDirectory.ToLower();

                if (appPath.EndsWith("debug\\"))
                    appPath = appPath.Substring(0, appPath.Length - 7);

                if (appPath.EndsWith("debug"))
                    appPath = appPath.Substring(0, appPath.Length - 6);

                string result = Path.Combine(appPath, "GUI");

                return result;
            }
        }

        private static void readOneLanguageFile(string languageFileWithPath, List<string> listErrors, Dictionary<string, string> translationDict)
        {

            string langPath = _guiPath;

            XmlDocument xmlDoc = new XmlDocument();

            // Einlesen mit XSD-Validierung
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();

                // im Visual Studio nicht validieren
                settings.Schemas.Add("", Path.Combine(langPath, LanguageXSD));
                settings.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(languageFileWithPath, settings);
                xmlDoc.Load(reader);
            }

            catch (XmlSchemaValidationException ex)
            {
                int line = ex.LineNumber;

                string pathSourceUri = ex.SourceUri.ToString();
                string fileSourceUri = Path.GetFileName(pathSourceUri);

                string text = string.Format("Error validating line {2} of xml file '{0}':\r\n{1}\r\n", fileSourceUri, ex.Message, line);
                listErrors.Add(text);
                //Logger.Error(text);
            }
            catch (XmlException ex)
            {
                string pathSourceUri = ex.SourceUri.ToString();
                string fileSourceUri = Path.GetFileName(pathSourceUri);

                string text = string.Format("Error loading REST API file '{0}':\r\n{1}\r\n", fileSourceUri, ex.Message);
                listErrors.Add(text);
                //Logger.Error(text);
            }

            foreach (XmlNode rootNode in xmlDoc.SelectNodes("xml"))
            {

                foreach (XmlNode regionNode in rootNode.ChildNodes)
                {
                    // Parallel.Foreach geht okay, alle Schreibzugriffe benutzen lock()
                    foreach (XmlNode objectNode in regionNode.ChildNodes.Cast<XmlNode>())
                    {
                        string key = "";

                        if (objectNode.Attributes == null || objectNode.Attributes.Count < 1)
                        {
                            continue;
                        }

                        key = objectNode.Attributes["id"].Value.ToString();

                        if (translationDict.ContainsKey(key))
                        {
                            lock (listErrors)
                            {
                                listErrors.Add(string.Format("Key duplicated: {0} (country code {1})\r\n",
                                               objectNode.Attributes["id"].Value, "xyz"));
                            }
                        }
                        else
                        {
                            string text = objectNode.InnerText; //  TEST .ToUpper();
                            lock (translationDict)
                            {
                                translationDict.Add(key, text);
                            }
                        }
                    }
                }
            }

            xmlDoc = null;
        }

        static public string GetResultText(ApiActionResult actionResult)
        {
            string guiPath = _guiPath;

            string languageFileWithPath = Path.Combine(guiPath, "AcronRestAPI.xml");
            if (File.Exists(languageFileWithPath))
            {
                if (!_userDefinedTexts.Any())
                {
                    List<string> listErrors = new List<string>();

                    readOneLanguageFile(languageFileWithPath, listErrors, _userDefinedTexts);
                }
            }

            string result = string.Empty;

            string key = string.Format("EnumValue.ApiActionResult.{0}", actionResult.ToString());

            if (_userDefinedTexts.TryGetValue(key, out result))
                return result;

            if (_actionResultTexts.TryGetValue(actionResult, out result))
                return result;

            return "no text";
        }

        /// <summary>
        /// Rückgabewert für alle RestAPI-Methoden
        /// </summary>
        /// <remarks>
        /// int-Val < 0   ===> Error
        /// int-Val == 0  ===> Ok
        /// int-Val > 0   ===> Warning or hint
        /// </remarks>
        public enum ApiActionResult : int
        {
            /// <summary> Einwandfrei abgearbeitet </summary>
            Ok = 0,

            /// <summary> FEHLER - Fehlender Übergabeparameter </summary>
            ErrorParam = -1,
            /// <summary> FEHLER - Unerwarteter Ausnahmefehler </summary>
            ErrorException = -2,

            /// <summary> Exception bei der Initialisierung des PlantConfigManagers </summary>
            ErrorExceptionInit = -1000,
            /// <summary> Anlage wurde nicht gefunden </summary>
            ErrorPlantNotFound = -1001,
            /// <summary> Exception bei Anlagensuche </summary>
            ErrorExceptionFindPlant = -1002,
            /// <summary> Exception bei PathLocator </summary>
            ErrorExceptionPathLocator = -1003,
            /// <summary> Keine Infos zur BV erhalten </summary>
            ErrorGetUserManagement = -1004,
            /// <summary> Benutzerverwaltung der Anlage ist deaktiviert </summary>
            ErrorNoUserManagement = -1005,
            /// <summary> Benutzerverwaltung der Anlage hat keine Benutzer </summary>
            ErrorNoUsers = -1006,


            /// <summary> Schreibzugriff kann nicht ermittelt werden</summary>
            ErrorConfigAccessDetection = -100,


            /// <summary> Kontaktierung des DBServers wirft Exception </summary>
            ErrorDBServerException = -300,


            /// <summary> Exception beim neu Laden der Anlage </summary>
            ErrorLoadPlantException = -500,
            /// <summary> Exception beim neu Laden der Anlage </summary>
            ErrorReloadPlantException = -501,


            /// <summary> Speichern der Anlage schlug fehl </summary>
            ErrorSaveFailed = -400,
            /// <summary> Exception beim Speichern </summary>
            ErrorSaveException = -401,



            /// <summary> Benutzer hat keinen Zugriff auf diesen Bereich </summary>
            RegionAccessDenied = 1,
            /// <summary> Die API unterstützt diesen Bereich der Konfiguration zur Zeit nicht </summary>
            RegionNotSupported = 2,
            /// <summary> Die API unterstützt diesen Typecode zur Zeit nicht </summary>
            TypeCodeNotSupported = 3,
            /// <summary> Update/Create - es wurden keine geeigneten Objekte übergegeben </summary>
            NoInterfaceObjectsOfGivenType = 4,
            /// <summary> Das BaseObject mit der angegebenen Id ist nicht in der Konfiguration enthalten </summary>
            BaseObjectNotFound = 5,
            /// <summary> Das BaseObject mit der angegebenen Id ist ein Read-Only Acron Objekt </summary>
            ReadOnlyAcronObject = 6,

            /// <summary> Die RestAPI ist unter Vollast und kann keine Anfragen beantworten </summary>
            ApiToBusy = 7,

            /// <summary> Das Schreiben von Daten via REST API ist nicht gestattet </summary>
            NoWriteAccess = 8,

            #region User Management

            /// <summary> Benutzerverwaltung der Anlage ist nicht aktiv </summary>
            UserCheckNoUserManagement = 50,
            /// <summary> Benutzer nicht gefunden </summary>
            UserCheckUserNotFound = 51,
            /// <summary> Falsches Pwd </summary>
            UserCheckPwd = 52,
            /// <summary> Benutzer hat keinen Zugriff auf die Rest API </summary>
            NoRestApiAccess = 53,
            /// <summary> Der Zeitbereich der angeforderten Daten überschreitet das vom Benutzer vorgegebene Maß </summary>
            UserDataLimit = 54,
            /// <summary> Die angegebene Verfahrensgröße existiert nicht. </summary>
            UserDataPvNotFound = 55,
            /// <summary> Die angegebene Verfahrensgröße besitzt nicht die erforderlichen Zugriffsrechte für den angegebenen Benutzer </summary>
            UserDataPvNoAccess = 56,
            /// <summary> Die angegebene Verfahrensgröße besitzt nicht die erforderlichen Zugriffsrechte für den angegebenen Benutzer </summary>
            UserDataPvNoWriteAccess = 57,

         #endregion User Management

         #region Config Access Infos

         /// <summary> Die RestAPI hat keinen Schreib-Zugriff auf die Konfiguration </summary>
         RestApiConfigWriteAccess = 100,

            /// <summary> Benutzer hat keinen Exclusiv-Schreibzugriff </summary>
            NoConfigWriteAccess = 101,
            /// <summary> Keiner hat den Exclusiv-Schreibzugriff </summary>
            ConfigAccessNobody = 102,
            /// <summary> Ein anderer Benutzer hat den Exclusiv-Schreibzugriff </summary>
            ConfigAccessOtherUser = 103,
            /// <summary> Properties können nicht geändert werden </summary>
            ConfigChangesLocked = 104,

            /// <summary> Server nicht vorhanden </summary>
            ConfigAccessNoClientToDBServer = 105,
            /// <summary> Keine aktive Anlage </summary>
            ConfigAccessNoActivePlant = 106,
            /// <summary> Aktive Anlage ist nicht komplett geladen</summary>
            ConfigAccessActivePlantNotLoaded = 107,

            /// <summary> Der Aufruf des Servers mit dem Befehl zur Ermittelung des Register-Status schlug fehl</summary>
            ConfigAccessCheckRegisterFailed = 108,
            /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
            ConfigAccessCheckRegisterUnknown = 109,

            /// <summary> Unlock nicht möglich - mir gehört der ConfigLock nicht </summary>
            ConfigAccessResetIamNotOwner = 110,
            /// <summary> Unlock nicht möglich - es liegt kein Lock vor </summary>
            ConfigAccessResetNoLock = 111,
            /// <summary> Unlock abgebrochen wegen offenen Änderungen</summary>
            ConfigAccessResetCancelOpenChanges = 112,
            /// <summary> Der Aufruf des Servers mit dem Unregister-Befehl schlug fehl</summary>
            ConfigAccessResetUnregisterFailed = 113,
            /// <summary> Unbekannter Fehler beim Aufruf des Servers </summary>
            ConfigAccessResetUnregisterUnknown = 114,

            /// <summary> Lock nicht möglich - die RestAPI hat keinen Zugriff auf die Konfiguration (Flag in Anlage)</summary>
            ConfigAccessSetNoConfigAccess = 115,
            /// <summary> Lock nicht möglich - ich habe ihn bereits </summary>
            ConfigAccessSetAlreadyLockedByMe = 116,
            /// <summary> Lock nicht möglich - ein anderer Benutzer hat den Lock </summary>
            ConfigAccessSetAlreadyLockedByAnotherUser = 117,
            /// <summary> Lock nicht möglich - Zeitstempel nicht aktuell </summary>
            ConfigAccessSetInvalidTimeStamps = 118,
            /// <summary> Lock fehlgeschlagen - Aufruf des Servers schlug fehl </summary>
            ConfigAccessSetRegisterFailed = 119,
            /// <summary> Lock fehlgeschlagen - Unbekannter Server-Fehler </summary>
            ConfigAccessSetRegisterUnknown = 120,

            #endregion Config Access Infos

            #region Delete

            /// <summary> Das BaseObject konnte nicht gelöscht werden, da es von anderen BaseObjects verwendet wird </summary>
            DeleteFailedObjectUsed = 200,
            /// <summary> Das BaseObject konnte nicht gelöscht werden </summary>
            DeleteFailedGeneral = 201,

            #endregion Delete

            #region DBServer communication

            /// <summary> Allgemeiner Verbindungsfehler zum DBServer </summary>
            DBServerGeneral = 300,
            /// <summary> DBServer läuft nicht </summary>
            DBServerNotRunning = 301,
            /// <summary> DBServer meldet : Anlage hat die false Version </summary>
            DBServerPlantNeedsUpdate = 302,

            #endregion DBServer communication

            #region Save

            /// <summary> Speichern nicht möglich - es gibt keine Änderungen </summary>
            SaveNoChanges = 400,
            /// <summary> Speichern nicht möglich - Anlage wurde nicht validiert </summary>
            SaveMissingValidation = 401,
            /// <summary> Speichern nicht möglich - Der Zeitstempel für die Neukompression ist nicht gültig </summary>
            SaveInvalidTimeStamp = 402,

         #endregion Save

         #region ChangeInfo

            /// <summary> Es gibt keine Änderungen </summary>
            ChangeInfoNothing = 450,

         #endregion ChangeInfo

         #region ApiDataRequest

            /// <summary>
            /// Wenn es einen Fehler gibt bei einer ProcessDatenabfrage
            /// </summary>
            Error_DataRequest = 500,

         #endregion ApiDataRequest

        }

    }
}
