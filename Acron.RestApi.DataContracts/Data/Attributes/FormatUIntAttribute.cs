namespace Acron.RestApi.DataContracts.Data.Attributes
{

   public class FormatUIntListAttribute : FormatBaseAttribute
   {
      public FormatUIntListAttribute(string targetPropertyName)
               : base(targetPropertyName)
      { }
   }


   public class FormatUIntAttribute : FormatBaseAttribute
   {
      public FormatUIntAttribute(string targetPropertyName)
               : base(targetPropertyName)
      { }
   }

}
