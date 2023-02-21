namespace Acron.RestApi.DataContracts.Data.Attributes
{
   public sealed class FormatDateTimeUTCRequestAttribute : FormatBaseAttribute
   {
      public FormatDateTimeUTCRequestAttribute(string targetPropertyName)
               : this(targetPropertyName, DateTimeFormatType.Default)
      { }

      public FormatDateTimeUTCRequestAttribute(string targetPropertyName, DateTimeFormatType formatType)
               : base(targetPropertyName)
      {
         _formatType = formatType;
      }

      private DateTimeFormatType _formatType;
      public DateTimeFormatType FormatType { get { return _formatType; } }
   }

}