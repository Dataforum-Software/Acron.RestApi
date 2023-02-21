namespace Acron.RestApi.DataContracts.Data.GlobalDataDefines
{
   public static class GlobalDataDef
   {
      /// <summary>
      /// Groesster gueltiger Wert
      /// </summary>
      public const double MAX_VALID = +1.0e+35;
      /// <summary>
      /// Kleinster gueltiger Wert
      /// </summary>
      public const double MIN_VALID = -1.0e+35;
      /// <summary>
      /// Wert fuer Markierung "kein Wert"
      /// </summary>
      public const double NO_VALID = +1.1e+35;

      /// <summary>Wert fuer Markierung "kein Wert" (float) </summary>
      public const double NO_VALIDFLOAT = +1.1e+35F;

      /// <summary>Wert fuer Markierung "kein Wert" (uint) </summary>
      public const uint NO_VALIDULONG = 999999999;

   }
}
