namespace Acron.RestApi.Interfaces.Configuration.GlobalConfigDefines
{
    /// <summary>
    /// Antwort-Klasse auf alle Anfragen an die Anlagenkonfiguration
    /// </summary>
    /// <typeparam name="T">Ergebnistyp der Antwort</typeparam>
    public class PlantConfigResult<T>
    {
        #region cTor

        public PlantConfigResult(T value)
        {
            ApiResult = ConfigDefines.ApiActionResult.Ok;
            InfoText = string.Empty;
            Value = value;
        }

        public PlantConfigResult(ConfigDefines.ApiActionResult apiResult, string infoText)
        {
            ApiResult = apiResult;
            InfoText = infoText;
            Value = default;
        }

        public PlantConfigResult(ConfigDefines.ApiActionResult apiResult, string infoText, T value)
        {
            ApiResult = apiResult;
            InfoText = infoText;
            Value = value;
        }

        #endregion cTor

        /// <summary>
        /// Enum-Wert des Ergebnisses
        /// </summary>
        public ConfigDefines.ApiActionResult ApiResult
        {
            get;
            internal set;
        }

        /// <summary>
        /// true - es liegt ein Fehler vor
        /// </summary>
        public bool HasError
        {
            get
            {
                if (ApiResult < 0)
                    return true;

                return false;
            }
        }

        /// <summary>
        /// Allgemeine Information (optional)
        /// </summary>
        public string InfoText { get; internal set; }

        /// <summary>
        /// Ergebnis der Anfrage (true/false, Liste von Objekten, ...)
        /// </summary>
        public T Value { get; internal set; }

    }
}