using Acron.RestApi.Interfaces.DataFormatter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Acron.RestApi.Client.Client.Request.Base
{
   public class DataRequestBase : RestClientAuthorizedRequestBase
   {
      public DataRequestBase(RestClient pClient) : base(pClient)
      {
         CustomHeaders = new()
         {
            new KeyValuePair<string, string>(
               DataFormatter_HeaderKeys.FormatTimeStampSettings.ToString(),
               DataFormatter_DateTimeFormatTypes.Acron.ToString()),
            new KeyValuePair<string, string>(
               DataFormatter_HeaderKeys.FormatValueSettings.ToString(),
               DataFormatter_ValueFormatTypes.Acron.ToString()),
            new KeyValuePair<string, string>(
               DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString(),
               TimeZoneInfo.Local.Id),
            new KeyValuePair<string, string>(
               DataFormatter_HeaderKeys.FormatLocale.ToString(),
               CultureInfo.CurrentCulture.Name),
         };
      }

      protected List<KeyValuePair<string, string>> CustomHeaders { get; set; }

      /// <summary>
      /// Retrieves the current List of Custom Headers
      /// </summary>
      /// <returns></returns>
      public List<KeyValuePair<string, string>> GetCustomHeaders()
      {
         return CustomHeaders;
      }

      protected KeyValuePair<string, string> GetHeader(DataFormatter_HeaderKeys key)
      {
         return CustomHeaders.FirstOrDefault(x => x.Key == key.ToString());
      }

      /// <summary>
      /// Removes Header from the CustomHeaders collection
      /// </summary>
      /// <param name="key">One of the pre-defined header keys accepted by the API</param>
      public void RemoveHeader(DataFormatter_HeaderKeys key)
      {
         KeyValuePair<string, string>? targetTime = GetHeader(key);
         if (targetTime.HasValue)
            CustomHeaders.Remove(targetTime.Value);
      }

      #region Format Timestamp Settings Header
      /// <summary>
      /// Sets the Timestamp Settings
      /// </summary>
      /// <param name="Settings">Either Acron or Culture</param>
      /// <returns>True on success, false on failure</returns>
      public bool SetTimestampSettingsHeader(DataFormatter_DateTimeFormatTypes Settings)
      {
         var header = GetHeader(DataFormatter_HeaderKeys.FormatTimeStampSettings);
         if (header.Key is null)
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.FormatTimeStampSettings.ToString(), Settings.ToString()));
         else
         {
            CustomHeaders.Remove(header);
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.FormatTimeStampSettings.ToString(), Settings.ToString()));
         }
         return true;
      }

      #endregion

      #region Format Value Settings Header
      /// <summary>
      /// Sets the Formatting of Values
      /// </summary>
      /// <param name="Settings">Either Acron or Culture</param>
      /// <returns>True on success, false on failure</returns>
      public bool SetFormatValueSettingsHeader(DataFormatter_ValueFormatTypes Settings)
      {
         var header = GetHeader(DataFormatter_HeaderKeys.FormatValueSettings);
         if (header.Key is null)
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.FormatValueSettings.ToString(), Settings.ToString()));
         else
         {
            CustomHeaders.Remove(header);
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.FormatValueSettings.ToString(), Settings.ToString()));
         }
         return true;
      }

      #endregion

      #region Format Locale Header
      /// <summary>
      /// Sets the Locale, returns false if not predefined Culture
      /// </summary>
      /// <param name="info">Predefined Culture</param>
      /// <returns>True on success, false on failure</returns>
      public bool SetFormatLocale(CultureInfo info)
      {
         try
         {
            CultureInfo.GetCultureInfo(info.Name, true);
            KeyValuePair<string, string> header = GetHeader(DataFormatter_HeaderKeys.FormatLocale);
            if (header.Key is null)
               CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.FormatLocale.ToString(), info.Name));
            else
            {
               CustomHeaders.Remove(header);
               CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.FormatLocale.ToString(), info.Name));
            }
            return true;
         }
         catch
         {
            return false;
         }
      }
      /// <summary>
      /// Sets the Locale
      /// </summary>
      /// <param name="format">Identifier of Culture ("en-US")</param>
      /// <returns>True on success, false on failure</returns>
      public bool SetFormatLocale(string format)
      {
         try
         {
            CultureInfo culture = CultureInfo.GetCultureInfo(format, true);
            return SetFormatLocale(culture);
         }
         catch
         {
            return false;
         }
      }

      #endregion

      #region Convert Target Time Zone Header

      /// <summary>
      /// Sets the target timezone for formatted timestamps
      /// </summary>
      /// <param name="targetTimeZoneId">Unique string Id of a given Timezone</param>
      /// <returns>True on success, false on failure</returns>
      public bool SetTargetTimeZone(string targetTimeZoneId)
      {
         if (!TimeZoneInfo.GetSystemTimeZones().Any(x => x.Id == targetTimeZoneId))
            return false;
         KeyValuePair<string, string> header = GetHeader(DataFormatter_HeaderKeys.ConvertTargetTimeZone);
         if (header.Key is null)
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString(), targetTimeZoneId));
         else
         {
            CustomHeaders.Remove(header);
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString(), targetTimeZoneId));
         }
         return true;

      }
      /// <summary>
      /// Sets the target timezone for formatted timestamps
      /// </summary>
      /// <param name="BaseUTCOffset">Offset of Timezone to UTC, does not consider Daylight Savings</param>
      /// <returns>True on success, false on failure</returns>
      public bool SetTargetTimeZone(TimeSpan BaseUTCOffset)
      {
         if (!TimeZoneInfo.GetSystemTimeZones().Any(x => x.BaseUtcOffset == BaseUTCOffset))
            return false;
         KeyValuePair<string, string> header = GetHeader(DataFormatter_HeaderKeys.ConvertTargetTimeZone);
         if (header.Key is null)
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString(), TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(x => x.BaseUtcOffset == BaseUTCOffset).Id));
         else
         {
            CustomHeaders.Remove(header);
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString(), TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(x => x.BaseUtcOffset == BaseUTCOffset).Id));

         }
         return true;
      }
      /// <summary>
      /// Sets the target timezone for formatted timestamps
      /// </summary>
      /// <param name="targetTimeZone"></param>
      /// <returns>True on success, false on failure</returns>
      public bool SetTargetTimeZone(TimeZoneInfo targetTimeZone)
      {
         KeyValuePair<string, string> header = GetHeader(DataFormatter_HeaderKeys.ConvertTargetTimeZone);
         if (header.Key is null)
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString(), targetTimeZone.Id));
         else
         {
            CustomHeaders.Remove(header);
            CustomHeaders.Add(new KeyValuePair<string, string>(DataFormatter_HeaderKeys.ConvertTargetTimeZone.ToString(), targetTimeZone.Id));
         }
         return true;
      }
      #endregion
   }
}
