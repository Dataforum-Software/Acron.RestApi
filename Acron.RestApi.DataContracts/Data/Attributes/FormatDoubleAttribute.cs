namespace Acron.RestApi.DataContracts.Data.Attributes
{
   public enum ValueFormatType : int
   {
      Default = 0,

      Process = 0,
      Interval,
      Day,
      WeekOrMonth,
      Year,
      ManualValue,

      Currency,
   }


   public class FormatDoubleListAttribute : FormatBaseAttribute
   {
      public FormatDoubleListAttribute(string targetPropertyName, ValueFormatType formatType)
               : base(targetPropertyName)
      {
         _formatType = formatType;
      }

      private ValueFormatType _formatType;

      public ValueFormatType FormatType
      {
         get { return _formatType; }
      }
   }


   public class FormatDoubleAttribute : FormatBaseAttribute
   {
      public FormatDoubleAttribute(string targetPropertyName, ValueFormatType formatType)
               : base(targetPropertyName)
      {
         _formatType = formatType;
      }

      private ValueFormatType _formatType;
      public ValueFormatType FormatType
      {
         get { return _formatType; }
      }
   }

}
