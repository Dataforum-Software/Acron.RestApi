using System;

namespace Acron.RestApi.Interfaces
{
   [AttributeUsage(AttributeTargets.Field)]
   public class SwaggerEnumInfoAttribute : Attribute
   {
      public SwaggerEnumInfoAttribute(string info)
      {
         Info = info;
      }

      public string Info { get; set; }
   }
}
