﻿namespace Acron.RestApi.DataContracts.Data.Attributes
{
   public enum DateTimeFormatType : int
   {
      Default = 0,

      Process = 1, //0, // Default und Process hatten den gleichen Wert. Warum??

      /// <summary> Verwendetes Intervall muss ermittelt werden </summary>
      IntervalX,
      Interval1,
      Interval2,
      Interval3,
      Interval4,
      Interval5,
      Interval6,
      Interval7,
      Interval8,

      /// <summary> Verwendeter Tag muss ermittelt werden </summary>
      DayX,
      Day1,
      Day2,

      /// <summary> Wird Woche oder Monats verwendet? </summary>
      WeekOrMonth,
      Week,
      Month,

      Year,

      /// <summary> "Prozessdaten" für Alarme </summary>
      ProcessAlert = Year+10,
   }

   public sealed class FormatDateTimeListAttribute : FormatBaseAttribute
   {
      public FormatDateTimeListAttribute(string targetPropertyName/*, string extraTimeZoneProperty*/) 
               : this(targetPropertyName, /*extraTimeZoneProperty,*/ DateTimeFormatType.Default)
      { }

      public FormatDateTimeListAttribute(string targetPropertyName, /*string extraTimeZoneProperty,*/ DateTimeFormatType formatType) 
               : base(targetPropertyName)
      {
         //_extraTimeZoneProperty = extraTimeZoneProperty;
         _formatType = formatType;
      }

      //private readonly string _extraTimeZoneProperty;
      //public string ExtraTimeZoneProperty { get { return _extraTimeZoneProperty; } }

      private DateTimeFormatType _formatType;
      public DateTimeFormatType FormatType { get { return _formatType; } }
   }

   public sealed class FormatDateTimeAttribute : FormatBaseAttribute
   {
      public FormatDateTimeAttribute(string targetPropertyName/*, string extraTimeZoneProperty*/) 
               : this(targetPropertyName, /*extraTimeZoneProperty,*/ DateTimeFormatType.Default)
      { }

      public FormatDateTimeAttribute(string targetPropertyName, /*string extraTimeZoneProperty,*/ DateTimeFormatType formatType)
               : base(targetPropertyName)
      {
         //_extraTimeZoneProperty = extraTimeZoneProperty;
         _formatType = formatType;
      }

      //private readonly string _extraTimeZoneProperty;
      //public string ExtraTimeZoneProperty { get { return _extraTimeZoneProperty; } }

      private DateTimeFormatType _formatType;
      public DateTimeFormatType FormatType { get { return _formatType; } }
   }

   public sealed class FormatDateOnlyAttribute : FormatBaseAttribute
   {
      public FormatDateOnlyAttribute(string targetPropertyName)
               : this(targetPropertyName, DateTimeFormatType.Default)
      { }

      public FormatDateOnlyAttribute(string targetPropertyName, DateTimeFormatType formatType)
               : base(targetPropertyName)
      {
         _formatType = formatType;
      }

      private DateTimeFormatType _formatType;
      public DateTimeFormatType FormatType { get { return _formatType; } }
   }


}
