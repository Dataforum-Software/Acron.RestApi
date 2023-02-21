namespace Acron.RestApi.DataContracts.Data.Attributes
{
   public class FormatFloatListAttribute : FormatBaseAttribute
   {
      public FormatFloatListAttribute(string targetPropertyName, ValueFormatType formatType)
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


   public class FormatFloatAttribute : FormatBaseAttribute
   {
      public FormatFloatAttribute(string targetPropertyName, ValueFormatType formatType)
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
