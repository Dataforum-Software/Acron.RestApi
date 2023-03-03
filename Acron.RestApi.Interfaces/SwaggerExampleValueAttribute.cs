using System;

namespace Acron.RestApi.Interfaces
{
   [AttributeUsage(AttributeTargets.Property)]
   public class SwaggerExampleValueAttribute : Attribute
   {
      public SwaggerExampleValueAttribute(object example)
      {
         Example = example;
      }

      public object Example { get; set; }
   }
}
