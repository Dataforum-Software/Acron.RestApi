using System;

namespace Acron.RestApi.Interfaces
{
   public class SwaggerExampleValueAttribute : Attribute
   {
      public SwaggerExampleValueAttribute(object example)
      {
         Example = example;
      }

      public object Example { get; set; }
   }
}
