namespace Acron.RestApi.DataContracts.Data.Attributes
{

   public class FormatDoubleListMarkerAttribute : FormatBaseAttribute
   {
      public FormatDoubleListMarkerAttribute(string targetPropertyName, ValueFormatType formatType)
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


   public class FormatDoubleMarkerAttribute : FormatBaseAttribute
   {
      public FormatDoubleMarkerAttribute(string targetPropertyName, ValueFormatType formatType)
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
