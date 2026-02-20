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

      public object[] UsedParams { get; }

      public TranslateKeyAttribute(FallbackTranslationType fallbackTranslationType = FallbackTranslationType.None, params string[] usedParams)
      {
         FallbackTranslationType = fallbackTranslationType;
         if (usedParams.Length > 0)
            UsedParams = usedParams;
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
