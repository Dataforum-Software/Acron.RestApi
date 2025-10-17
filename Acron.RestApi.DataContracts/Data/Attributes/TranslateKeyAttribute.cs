using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acron.RestApi.DataContracts.Data.Attributes
{
   [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
   public class TranslateKeyAttribute : Attribute
   {
      public FallbackTranslationType FallbackTranslationType { get; }

      public TranslateKeyAttribute(FallbackTranslationType translationType = FallbackTranslationType.None)
      {
         FallbackTranslationType = translationType;
      }
   }

   public enum FallbackTranslationType : short
   {
      None,
      Empty,
      Common,
      Key,
      FullKey,

   }
}
