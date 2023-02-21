namespace Acron.RestApi.DataContracts.Data.Attributes
{
   [System.AttributeUsage(System.AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
   public abstract class FormatBaseAttribute : System.Attribute
   {      
      protected FormatBaseAttribute(string pTargetPropertyName)
      {
         _targetPropertyName = pTargetPropertyName;
      }

      private readonly string _targetPropertyName;
      public string TargetPropertyName
      {
         get { return _targetPropertyName; }
      }
   }
}
