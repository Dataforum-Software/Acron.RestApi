using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.Interfaces.DataFormatter
{
   //ToDoSwagger

   public enum DataFormatter_HeaderKeys
   {
      FormatLocale,
      FormatTimeStampSettings,
      ConvertTargetTimeZone,
      FormatValueSettings,
   }

   public enum DataFormatter_DateTimeFormatTypes
   {
      [SwaggerEnumInfo("Time stamp format from 'FormatLocale' Header, or server locale if empty")]
      Culture,

      [SwaggerEnumInfo("Time stamp format as defined in ACRON Designer")]
      Acron,
   }

   public enum DataFormatter_ValueFormatTypes
   {
      [SwaggerEnumInfo("Value format from 'FormatLocale' Header, or server locale if empty")]
      Culture,

      [SwaggerEnumInfo("Value format as defined in ACRON Designer")]
      Acron,
   }

}
