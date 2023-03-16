using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Client.Client.Defines
{
   public static class HeaderDefines
   {
      public static class Keys
      {
         public static class Content
         {
            public const string Accept = "Accept";
            public const string ContentType = "Content-Type";
            public const string Encoding = "Accept-Encoding";
         }

         public static class Authentication
         {
            public const string Authorization = "Authorization";
            public const string Acron = "Acron";
         }

         public static class Convert
         {
            public const string TargetTimeZone = "ConvertTargetTimeZone";
         }

         public static class Format
         {
            public const string Locale = "FormatLocale";
            public const string TimeStampSettings = "FormatTimeStampSettings";
            public const string ValueSettings = "FormatValueSettings";
         }
      }

      public static class Values
      {
         public static class Content
         {
            public const string Accept = "application/json";
            public const string ContentType = "application/json";
            public static class Encoding
            {
               public const string Brotli = "br";
               public const string GZip = "gzip";
               public const string None = "none";
            }
         }

         public static class Format
         {
            public const string Locale = "FormatLocale";

            public static class TimeStampSettings
            {
               public const string Acron = "Acron";
               public const string Culture = "Culture";
            }

            public static class ValueSettings
            {
               public const string Acron = "Acron";
               public const string Culture = "Culture";
            }
         }

      }
   }
}
